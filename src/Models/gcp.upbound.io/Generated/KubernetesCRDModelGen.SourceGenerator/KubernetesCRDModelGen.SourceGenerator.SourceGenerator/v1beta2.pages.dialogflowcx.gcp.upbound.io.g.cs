#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflowcx.gcp.upbound.io;
/// <summary>Page is the Schema for the Pages API. A Dialogflow CX conversation (session) can be described and visualized as a state machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Page>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PageList";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "pages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Page objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Page> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecDeletionPolicyEnum>))]
public enum V1beta2PageSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderAdvancedSettingsDtmfSettings
{
    /// <summary>If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a &quot;3&quot; was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this page. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageSpecForProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecForProviderEntryFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecForProviderEntryFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecForProviderEntryFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecForProviderEntryFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecForProviderEntryFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecForProviderEntryFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the session is entering the page.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEntryFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecForProviderEntryFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecForProviderEntryFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecForProviderEntryFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecForProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>
    /// The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecForProviderEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersAdvancedSettingsDtmfSettings
{
    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this parameter. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageSpecForProviderFormParametersAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelector
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
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelector
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
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelector
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
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookRef")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRef? WebhookRef { get; set; }

    /// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookSelector")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelector? WebhookSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelector? TargetFlowSelector { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageRef")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRef? TargetPageRef { get; set; }

    /// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageSelector")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelector? TargetPageSelector { get; set; }

    /// <summary>
    /// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// Defines fill behavior for the parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParametersFillBehavior
{
    /// <summary>
    /// The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("initialPromptFulfillment")]
    public V1beta2PageSpecForProviderFormParametersFillBehaviorInitialPromptFulfillment? InitialPromptFulfillment { get; set; }

    /// <summary>The handlers for parameter-level events, used to provide reprompt for the parameter or transition to a different page/flow. The supported events are:</summary>
    [JsonPropertyName("repromptEventHandlers")]
    public IList<V1beta2PageSpecForProviderFormParametersFillBehaviorRepromptEventHandlers>? RepromptEventHandlers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderFormParameters
{
    /// <summary>
    /// Hierarchical advanced settings for this parameter. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageSpecForProviderFormParametersAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The default value of an optional parameter. If the parameter is required, the default value will be ignored.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The human-readable name of the parameter, unique within the form.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/ for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects//locations//agents//entityTypes/ for developer entity types.
    /// </summary>
    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    /// <summary>
    /// Defines fill behavior for the parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fillBehavior")]
    public V1beta2PageSpecForProviderFormParametersFillBehavior? FillBehavior { get; set; }

    /// <summary>Indicates whether the parameter represents a list of values.</summary>
    [JsonPropertyName("isList")]
    public bool? IsList { get; set; }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log.
    /// If redaction is enabled, the parameter content will be replaced by parameter name during logging. Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    [JsonPropertyName("redact")]
    public bool? Redact { get; set; }

    /// <summary>
    /// Indicates whether the parameter is required. Optional parameters will not trigger prompts; however, they are filled if the user specifies them.
    /// Required parameters must be filled before form filling concludes.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }
}

/// <summary>
/// The form associated with the page, used for collecting parameters relevant to the page.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderForm
{
    /// <summary>
    /// Parameters to collect from the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta2PageSpecForProviderFormParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsDataStoreConnections
{
    /// <summary>The full name of the referenced data store. Formats: projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore} projects/{project}/locations/{location}/dataStores/{dataStore}</summary>
    [JsonPropertyName("dataStore")]
    public string? DataStore { get; set; }

    /// <summary>The type of the connected data store.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The document processing mode for the data store connection. Should only be set for PUBLIC_WEB and UNSTRUCTURED data stores. If not set it is considered as DOCUMENTS, as this is the legacy mode.</summary>
    [JsonPropertyName("documentProcessingMode")]
    public string? DocumentProcessingMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelector
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
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelectorPolicy? Policy { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings
{
    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Endpoint timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("endpointingTimeoutDuration")]
    public string? EndpointingTimeoutDuration { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>
    /// Interdigit timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("interdigitTimeoutDuration")]
    public string? InterdigitTimeoutDuration { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings
{
    /// <summary>Enables consent-based end-user input redaction, if true, a pre-defined session parameter $session.params.conversation-redaction will be used to determine if the utterance should be redacted.</summary>
    [JsonPropertyName("enableConsentBasedRedaction")]
    public bool? EnableConsentBasedRedaction { get; set; }

    /// <summary>Enables DF Interaction logging.</summary>
    [JsonPropertyName("enableInteractionLogging")]
    public bool? EnableInteractionLogging { get; set; }

    /// <summary>Enables Google Cloud Logging.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }
}

/// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings
{
    /// <summary>Sensitivity of the speech model that detects the end of speech. Scale from 0 to 100.</summary>
    [JsonPropertyName("endpointerSensitivity")]
    public double? EndpointerSensitivity { get; set; }

    /// <summary>
    /// Mapping from language to Speech-to-Text model. The mapped Speech-to-Text model will be selected for requests from its corresponding language. For more information, see Speech models.
    /// An object containing a list of &quot;key&quot;: value pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("models")]
    public IDictionary<string, string>? Models { get; set; }

    /// <summary>
    /// Timeout before detecting no speech.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("noSpeechTimeout")]
    public string? NoSpeechTimeout { get; set; }

    /// <summary>Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.</summary>
    [JsonPropertyName("useTimeoutBasedEndpointing")]
    public bool? UseTimeoutBasedEndpointing { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
/// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// This type has no fields.
/// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
/// Otherwise, the info card response is skipped.
/// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard
{
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// This type has no fields.
    /// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
    /// Otherwise, the info card response is skipped.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("knowledgeInfoCard")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard? KnowledgeInfoCard { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector
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
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The fulfillment to be triggered.
/// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillment
{
    /// <summary>
    /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
    /// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>If the flag is true, the agent will utilize LLM to generate a text response. If LLM generation fails, the defined responses in the fulfillment will be respected. This flag is only useful for fulfillments associated with no-match event handlers.</summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookRef")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef? WebhookRef { get; set; }

    /// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookSelector")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector? WebhookSelector { get; set; }
}

/// <summary>
/// Knowledge connector configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderKnowledgeConnectorSettings
{
    /// <summary>
    /// Optional. List of related data store connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataStoreConnections")]
    public IList<V1beta2PageSpecForProviderKnowledgeConnectorSettingsDataStoreConnections>? DataStoreConnections { get; set; }

    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects//locations//agents//flows/.
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to. Format: projects//locations//agents//flows//pages/.
    /// The page must be in the same host flow (the flow that owns this KnowledgeConnectorSettings).
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageRef")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageRef? TargetPageRef { get; set; }

    /// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageSelector")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTargetPageSelector? TargetPageSelector { get; set; }

    /// <summary>
    /// The fulfillment to be triggered.
    /// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettingsTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderParentRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderParentRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderParentRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderParentSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderParentSelector
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
    public V1beta2PageSpecForProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTargetPageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTargetPageSelector
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
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProviderTransitionRoutes
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects//locations//agents//intents/. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageRef")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageRef? TargetPageRef { get; set; }

    /// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageSelector")]
    public V1beta2PageSpecForProviderTransitionRoutesTargetPageSelector? TargetPageSelector { get; set; }

    /// <summary>
    /// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecForProviderTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecForProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this page. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageSpecForProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The human-readable name of the page, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The fulfillment to call when the session is entering the page.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("entryFulfillment")]
    public V1beta2PageSpecForProviderEntryFulfillment? EntryFulfillment { get; set; }

    /// <summary>
    /// Handlers associated with the page to handle events such as webhook errors, no match or no input.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta2PageSpecForProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>
    /// The form associated with the page, used for collecting parameters relevant to the page.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("form")]
    public V1beta2PageSpecForProviderForm? Form { get; set; }

    /// <summary>
    /// Knowledge connector configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("knowledgeConnectorSettings")]
    public V1beta2PageSpecForProviderKnowledgeConnectorSettings? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// The language of the following fields in page:
    /// Page.entry_fulfillment.messages
    /// Page.entry_fulfillment.conditional_cases
    /// Page.event_handlers.trigger_fulfillment.messages
    /// Page.event_handlers.trigger_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.messages
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.conditional_cases
    /// Page.transition_routes.trigger_fulfillment.messages
    /// Page.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&apos;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta2PageSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta2PageSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&apos;s transition route -&gt; page&apos;s transition route group -&gt; flow&apos;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects//locations//agents//flows//transitionRouteGroups/.
    /// </summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow.
    /// When we are in a certain page, the TransitionRoutes are evalauted in the following order:
    /// TransitionRoutes defined in the page with intent specified.
    /// TransitionRoutes defined in the transition route groups with intent specified.
    /// TransitionRoutes defined in flow with intent specified.
    /// TransitionRoutes defined in the transition route groups with intent specified.
    /// TransitionRoutes defined in the page with only condition specified.
    /// TransitionRoutes defined in the transition route groups with only condition specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta2PageSpecForProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderAdvancedSettingsDtmfSettings
{
    /// <summary>If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a &quot;3&quot; was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this page. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageSpecInitProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecInitProviderEntryFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecInitProviderEntryFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecInitProviderEntryFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecInitProviderEntryFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecInitProviderEntryFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecInitProviderEntryFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the session is entering the page.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEntryFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecInitProviderEntryFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecInitProviderEntryFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecInitProviderEntryFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecInitProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>
    /// The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecInitProviderEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersAdvancedSettingsDtmfSettings
{
    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this parameter. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageSpecInitProviderFormParametersAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelector
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
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelector
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
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelector
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
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookRef")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookRef? WebhookRef { get; set; }

    /// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookSelector")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentWebhookSelector? WebhookSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetFlowSelector? TargetFlowSelector { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageRef")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageRef? TargetPageRef { get; set; }

    /// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageSelector")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTargetPageSelector? TargetPageSelector { get; set; }

    /// <summary>
    /// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// Defines fill behavior for the parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParametersFillBehavior
{
    /// <summary>
    /// The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("initialPromptFulfillment")]
    public V1beta2PageSpecInitProviderFormParametersFillBehaviorInitialPromptFulfillment? InitialPromptFulfillment { get; set; }

    /// <summary>The handlers for parameter-level events, used to provide reprompt for the parameter or transition to a different page/flow. The supported events are:</summary>
    [JsonPropertyName("repromptEventHandlers")]
    public IList<V1beta2PageSpecInitProviderFormParametersFillBehaviorRepromptEventHandlers>? RepromptEventHandlers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderFormParameters
{
    /// <summary>
    /// Hierarchical advanced settings for this parameter. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageSpecInitProviderFormParametersAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The default value of an optional parameter. If the parameter is required, the default value will be ignored.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The human-readable name of the parameter, unique within the form.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/ for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects//locations//agents//entityTypes/ for developer entity types.
    /// </summary>
    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    /// <summary>
    /// Defines fill behavior for the parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fillBehavior")]
    public V1beta2PageSpecInitProviderFormParametersFillBehavior? FillBehavior { get; set; }

    /// <summary>Indicates whether the parameter represents a list of values.</summary>
    [JsonPropertyName("isList")]
    public bool? IsList { get; set; }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log.
    /// If redaction is enabled, the parameter content will be replaced by parameter name during logging. Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    [JsonPropertyName("redact")]
    public bool? Redact { get; set; }

    /// <summary>
    /// Indicates whether the parameter is required. Optional parameters will not trigger prompts; however, they are filled if the user specifies them.
    /// Required parameters must be filled before form filling concludes.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }
}

/// <summary>
/// The form associated with the page, used for collecting parameters relevant to the page.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderForm
{
    /// <summary>
    /// Parameters to collect from the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta2PageSpecInitProviderFormParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsDataStoreConnections
{
    /// <summary>The full name of the referenced data store. Formats: projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore} projects/{project}/locations/{location}/dataStores/{dataStore}</summary>
    [JsonPropertyName("dataStore")]
    public string? DataStore { get; set; }

    /// <summary>The type of the connected data store.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The document processing mode for the data store connection. Should only be set for PUBLIC_WEB and UNSTRUCTURED data stores. If not set it is considered as DOCUMENTS, as this is the legacy mode.</summary>
    [JsonPropertyName("documentProcessingMode")]
    public string? DocumentProcessingMode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelector
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
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelectorPolicy? Policy { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings
{
    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Endpoint timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("endpointingTimeoutDuration")]
    public string? EndpointingTimeoutDuration { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>
    /// Interdigit timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("interdigitTimeoutDuration")]
    public string? InterdigitTimeoutDuration { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings
{
    /// <summary>Enables consent-based end-user input redaction, if true, a pre-defined session parameter $session.params.conversation-redaction will be used to determine if the utterance should be redacted.</summary>
    [JsonPropertyName("enableConsentBasedRedaction")]
    public bool? EnableConsentBasedRedaction { get; set; }

    /// <summary>Enables DF Interaction logging.</summary>
    [JsonPropertyName("enableInteractionLogging")]
    public bool? EnableInteractionLogging { get; set; }

    /// <summary>Enables Google Cloud Logging.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }
}

/// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings
{
    /// <summary>Sensitivity of the speech model that detects the end of speech. Scale from 0 to 100.</summary>
    [JsonPropertyName("endpointerSensitivity")]
    public double? EndpointerSensitivity { get; set; }

    /// <summary>
    /// Mapping from language to Speech-to-Text model. The mapped Speech-to-Text model will be selected for requests from its corresponding language. For more information, see Speech models.
    /// An object containing a list of &quot;key&quot;: value pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("models")]
    public IDictionary<string, string>? Models { get; set; }

    /// <summary>
    /// Timeout before detecting no speech.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("noSpeechTimeout")]
    public string? NoSpeechTimeout { get; set; }

    /// <summary>Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.</summary>
    [JsonPropertyName("useTimeoutBasedEndpointing")]
    public bool? UseTimeoutBasedEndpointing { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
/// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// This type has no fields.
/// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
/// Otherwise, the info card response is skipped.
/// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard
{
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// This type has no fields.
    /// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
    /// Otherwise, the info card response is skipped.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("knowledgeInfoCard")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard? KnowledgeInfoCard { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector
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
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The fulfillment to be triggered.
/// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillment
{
    /// <summary>
    /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
    /// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>If the flag is true, the agent will utilize LLM to generate a text response. If LLM generation fails, the defined responses in the fulfillment will be respected. This flag is only useful for fulfillments associated with no-match event handlers.</summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookRef")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef? WebhookRef { get; set; }

    /// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookSelector")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector? WebhookSelector { get; set; }
}

/// <summary>
/// Knowledge connector configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderKnowledgeConnectorSettings
{
    /// <summary>
    /// Optional. List of related data store connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataStoreConnections")]
    public IList<V1beta2PageSpecInitProviderKnowledgeConnectorSettingsDataStoreConnections>? DataStoreConnections { get; set; }

    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects//locations//agents//flows/.
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to. Format: projects//locations//agents//flows//pages/.
    /// The page must be in the same host flow (the flow that owns this KnowledgeConnectorSettings).
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageRef")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageRef? TargetPageRef { get; set; }

    /// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageSelector")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTargetPageSelector? TargetPageSelector { get; set; }

    /// <summary>
    /// The fulfillment to be triggered.
    /// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderParentRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderParentRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderParentRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderParentSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderParentSelector
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
    public V1beta2PageSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTargetPageRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicyResolutionEnum>))]
public enum V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicyResolveEnum>))]
public enum V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelector
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
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProviderTransitionRoutes
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects//locations//agents//intents/. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>Reference to a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageRef")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageRef? TargetPageRef { get; set; }

    /// <summary>Selector for a Page in dialogflowcx to populate targetPage.</summary>
    [JsonPropertyName("targetPageSelector")]
    public V1beta2PageSpecInitProviderTransitionRoutesTargetPageSelector? TargetPageSelector { get; set; }

    /// <summary>
    /// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageSpecInitProviderTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecInitProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this page. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageSpecInitProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The human-readable name of the page, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The fulfillment to call when the session is entering the page.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("entryFulfillment")]
    public V1beta2PageSpecInitProviderEntryFulfillment? EntryFulfillment { get; set; }

    /// <summary>
    /// Handlers associated with the page to handle events such as webhook errors, no match or no input.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta2PageSpecInitProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>
    /// The form associated with the page, used for collecting parameters relevant to the page.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("form")]
    public V1beta2PageSpecInitProviderForm? Form { get; set; }

    /// <summary>
    /// Knowledge connector configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("knowledgeConnectorSettings")]
    public V1beta2PageSpecInitProviderKnowledgeConnectorSettings? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// The language of the following fields in page:
    /// Page.entry_fulfillment.messages
    /// Page.entry_fulfillment.conditional_cases
    /// Page.event_handlers.trigger_fulfillment.messages
    /// Page.event_handlers.trigger_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.messages
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.conditional_cases
    /// Page.transition_routes.trigger_fulfillment.messages
    /// Page.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&apos;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta2PageSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta2PageSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&apos;s transition route -&gt; page&apos;s transition route group -&gt; flow&apos;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects//locations//agents//flows//transitionRouteGroups/.
    /// </summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow.
    /// When we are in a certain page, the TransitionRoutes are evalauted in the following order:
    /// TransitionRoutes defined in the page with intent specified.
    /// TransitionRoutes defined in the transition route groups with intent specified.
    /// TransitionRoutes defined in flow with intent specified.
    /// TransitionRoutes defined in the transition route groups with intent specified.
    /// TransitionRoutes defined in the page with only condition specified.
    /// TransitionRoutes defined in the transition route groups with only condition specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta2PageSpecInitProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecManagementPoliciesEnum>))]
public enum V1beta2PageSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PageSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PageSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PageSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PageSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PageSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PageSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PageSpec defines the desired state of Page</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageSpec
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
    public V1beta2PageSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PageSpecForProvider ForProvider { get; set; }

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
    public V1beta2PageSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PageSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderAdvancedSettingsDtmfSettings
{
    /// <summary>If true, incoming audio is processed for DTMF (dual tone multi frequency) events. For example, if the caller presses a button on their telephone keypad and DTMF processing is enabled, Dialogflow will detect the event (e.g. a &quot;3&quot; was pressed) in the incoming audio and pass the event to the bot to drive business logic (e.g. when 3 is pressed, return the account balance).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this page. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageStatusAtProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessagesOutputAudioText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessagesPlayAudio
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessagesText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageStatusAtProviderEntryFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageStatusAtProviderEntryFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageStatusAtProviderEntryFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageStatusAtProviderEntryFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageStatusAtProviderEntryFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageStatusAtProviderEntryFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the session is entering the page.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEntryFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageStatusAtProviderEntryFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageStatusAtProviderEntryFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageStatusAtProviderEntryFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageStatusAtProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// (Output)
    /// The unique identifier of this event handler.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>
    /// The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling webhooks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageStatusAtProviderEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersAdvancedSettingsDtmfSettings
{
    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this parameter. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageStatusAtProviderFormParametersAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlers
{
    /// <summary>The name of the event to handle.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// (Output)
    /// The unique identifier of this transition route.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>
    /// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// Defines fill behavior for the parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParametersFillBehavior
{
    /// <summary>
    /// The fulfillment to provide the initial prompt that the agent can present to the user in order to fill the parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("initialPromptFulfillment")]
    public V1beta2PageStatusAtProviderFormParametersFillBehaviorInitialPromptFulfillment? InitialPromptFulfillment { get; set; }

    /// <summary>The handlers for parameter-level events, used to provide reprompt for the parameter or transition to a different page/flow. The supported events are:</summary>
    [JsonPropertyName("repromptEventHandlers")]
    public IList<V1beta2PageStatusAtProviderFormParametersFillBehaviorRepromptEventHandlers>? RepromptEventHandlers { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderFormParameters
{
    /// <summary>
    /// Hierarchical advanced settings for this parameter. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageStatusAtProviderFormParametersAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The default value of an optional parameter. If the parameter is required, the default value will be ignored.</summary>
    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    /// <summary>The human-readable name of the parameter, unique within the form.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The entity type of the parameter.
    /// Format: projects/-/locations/-/agents/-/entityTypes/ for system entity types (for example, projects/-/locations/-/agents/-/entityTypes/sys.date), or projects//locations//agents//entityTypes/ for developer entity types.
    /// </summary>
    [JsonPropertyName("entityType")]
    public string? EntityType { get; set; }

    /// <summary>
    /// Defines fill behavior for the parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fillBehavior")]
    public V1beta2PageStatusAtProviderFormParametersFillBehavior? FillBehavior { get; set; }

    /// <summary>Indicates whether the parameter represents a list of values.</summary>
    [JsonPropertyName("isList")]
    public bool? IsList { get; set; }

    /// <summary>
    /// Indicates whether the parameter content should be redacted in log.
    /// If redaction is enabled, the parameter content will be replaced by parameter name during logging. Note: the parameter content is subject to redaction if either parameter level redaction or entity type level redaction is enabled.
    /// </summary>
    [JsonPropertyName("redact")]
    public bool? Redact { get; set; }

    /// <summary>
    /// Indicates whether the parameter is required. Optional parameters will not trigger prompts; however, they are filled if the user specifies them.
    /// Required parameters must be filled before form filling concludes.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }
}

/// <summary>
/// The form associated with the page, used for collecting parameters relevant to the page.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderForm
{
    /// <summary>
    /// Parameters to collect from the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IList<V1beta2PageStatusAtProviderFormParameters>? Parameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsDataStoreConnections
{
    /// <summary>The full name of the referenced data store. Formats: projects/{project}/locations/{location}/collections/{collection}/dataStores/{dataStore} projects/{project}/locations/{location}/dataStores/{dataStore}</summary>
    [JsonPropertyName("dataStore")]
    public string? DataStore { get; set; }

    /// <summary>The type of the connected data store.</summary>
    [JsonPropertyName("dataStoreType")]
    public string? DataStoreType { get; set; }

    /// <summary>The document processing mode for the data store connection. Should only be set for PUBLIC_WEB and UNSTRUCTURED data stores. If not set it is considered as DOCUMENTS, as this is the legacy mode.</summary>
    [JsonPropertyName("documentProcessingMode")]
    public string? DocumentProcessingMode { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings
{
    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Endpoint timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("endpointingTimeoutDuration")]
    public string? EndpointingTimeoutDuration { get; set; }

    /// <summary>The digit that terminates a DTMF digit sequence.</summary>
    [JsonPropertyName("finishDigit")]
    public string? FinishDigit { get; set; }

    /// <summary>
    /// Interdigit timeout setting for matching dtmf input to regex.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("interdigitTimeoutDuration")]
    public string? InterdigitTimeoutDuration { get; set; }

    /// <summary>Max length of DTMF digits.</summary>
    [JsonPropertyName("maxDigits")]
    public double? MaxDigits { get; set; }
}

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings
{
    /// <summary>Enables consent-based end-user input redaction, if true, a pre-defined session parameter $session.params.conversation-redaction will be used to determine if the utterance should be redacted.</summary>
    [JsonPropertyName("enableConsentBasedRedaction")]
    public bool? EnableConsentBasedRedaction { get; set; }

    /// <summary>Enables DF Interaction logging.</summary>
    [JsonPropertyName("enableInteractionLogging")]
    public bool? EnableInteractionLogging { get; set; }

    /// <summary>Enables Google Cloud Logging.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }
}

/// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings
{
    /// <summary>Sensitivity of the speech model that detects the end of speech. Scale from 0 to 100.</summary>
    [JsonPropertyName("endpointerSensitivity")]
    public double? EndpointerSensitivity { get; set; }

    /// <summary>
    /// Mapping from language to Speech-to-Text model. The mapped Speech-to-Text model will be selected for requests from its corresponding language. For more information, see Speech models.
    /// An object containing a list of &quot;key&quot;: value pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;: &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("models")]
    public IDictionary<string, string>? Models { get; set; }

    /// <summary>
    /// Timeout before detecting no speech.
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.500s&quot;.
    /// </summary>
    [JsonPropertyName("noSpeechTimeout")]
    public string? NoSpeechTimeout { get; set; }

    /// <summary>Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.</summary>
    [JsonPropertyName("useTimeoutBasedEndpointing")]
    public bool? UseTimeoutBasedEndpointing { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
/// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesEndInteraction
{
}

/// <summary>
/// This type has no fields.
/// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
/// Otherwise, the info card response is skipped.
/// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard
{
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudioSegments
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>
    /// Raw audio synthesized from the Dialogflow agent&apos;s response using the output config specified in the request.
    /// A base64-encoded string.
    /// This field is part of a union field content: Only one of audio or uri may be set.
    /// </summary>
    [JsonPropertyName("audio")]
    public string? Audio { get; set; }

    /// <summary>
    /// Client-specific URI that points to an audio clip accessible to the client. Dialogflow does not impose any validation on it.
    /// This field is part of a union field content: Only one of audio or uri may be set.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudio
{
    /// <summary>
    /// Segments this audio response is composed of.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("segments")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudioSegments>? Segments { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// (Output)
    /// This type has no fields.
    /// Indicates that interaction with the Dialogflow agent has ended. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("endInteraction")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesEndInteraction>? EndInteraction { get; set; }

    /// <summary>
    /// This type has no fields.
    /// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
    /// Otherwise, the info card response is skipped.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("knowledgeInfoCard")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard? KnowledgeInfoCard { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// (Output)
    /// Represents an audio message that is composed of both segments synthesized from the Dialogflow agent prompts and ones hosted externally at the specified URIs. The external URIs are specified via playAudio. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mixedAudio")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudio>? MixedAudio { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to be triggered.
/// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillment
{
    /// <summary>
    /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
    /// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>If the flag is true, the agent will utilize LLM to generate a text response. If LLM generation fails, the defined responses in the fulfillment will be respected. This flag is only useful for fulfillments associated with no-match event handlers.</summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

/// <summary>
/// Knowledge connector configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderKnowledgeConnectorSettings
{
    /// <summary>
    /// Optional. List of related data store connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataStoreConnections")]
    public IList<V1beta2PageStatusAtProviderKnowledgeConnectorSettingsDataStoreConnections>? DataStoreConnections { get; set; }

    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects//locations//agents//flows/.
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to. Format: projects//locations//agents//flows//pages/.
    /// The page must be in the same host flow (the flow that owns this KnowledgeConnectorSettings).
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>
    /// The fulfillment to be triggered.
    /// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentConditionalCases
{
    /// <summary>
    /// A JSON encoded list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching condition is selected, all the rest ignored.
    /// See Case for the schema.
    /// </summary>
    [JsonPropertyName("cases")]
    public string? Cases { get; set; }
}

/// <summary>
/// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
/// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>The SSML text to be synthesized. For more information, see SSML.</summary>
    [JsonPropertyName("ssml")]
    public string? Ssml { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>
/// Specifies an audio clip to be played by the client as part of the response.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>URI of the audio clip. Dialogflow does not impose any validation on this value. It is specific to the client that reads it.</summary>
    [JsonPropertyName("audioUri")]
    public string? AudioUri { get; set; }
}

/// <summary>
/// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>
    /// (Output)
    /// Whether the playback of this message can be interrupted by the end user&apos;s speech and the client can then starts the next Dialogflow request.
    /// </summary>
    [JsonPropertyName("allowPlaybackInterruption")]
    public bool? AllowPlaybackInterruption { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessages
{
    /// <summary>The channel which the response is associated with. Clients can specify the channel via QueryParameters.channel, and only associated channel response will be returned.</summary>
    [JsonPropertyName("channel")]
    public string? Channel { get; set; }

    /// <summary>
    /// Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to it about.
    /// Dialogflow only uses this to determine which conversations should be counted as successful and doesn&apos;t process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to the conversation end page as successful even if they don&apos;t return ConversationSuccess.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("conversationSuccess")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentSetParameterActions
{
    /// <summary>Display name of the parameter.</summary>
    [JsonPropertyName("parameter")]
    public string? Parameter { get; set; }

    /// <summary>The new JSON-encoded value of the parameter. A null value clears the parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProviderTransitionRoutes
{
    /// <summary>
    /// The condition to evaluate against form parameters or session parameters.
    /// At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

    /// <summary>
    /// The unique identifier of an Intent.
    /// Format: projects//locations//agents//intents/. Indicates that the transition can only happen when the given intent is matched. At least one of intent or condition must be specified. When both intent and condition are specified, the transition can only happen when both are fulfilled.
    /// </summary>
    [JsonPropertyName("intent")]
    public string? Intent { get; set; }

    /// <summary>
    /// (Output)
    /// The unique identifier of this transition route.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The target flow to transition to.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>
    /// The target page to transition to.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("targetPage")]
    public string? TargetPage { get; set; }

    /// <summary>
    /// The fulfillment to call when the condition is satisfied. At least one of triggerFulfillment and target must be specified. When both are defined, triggerFulfillment is executed first.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("triggerFulfillment")]
    public V1beta2PageStatusAtProviderTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusAtProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this page. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2PageStatusAtProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The human-readable name of the page, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The fulfillment to call when the session is entering the page.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("entryFulfillment")]
    public V1beta2PageStatusAtProviderEntryFulfillment? EntryFulfillment { get; set; }

    /// <summary>
    /// Handlers associated with the page to handle events such as webhook errors, no match or no input.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta2PageStatusAtProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>
    /// The form associated with the page, used for collecting parameters relevant to the page.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("form")]
    public V1beta2PageStatusAtProviderForm? Form { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/pages/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Knowledge connector configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("knowledgeConnectorSettings")]
    public V1beta2PageStatusAtProviderKnowledgeConnectorSettings? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// The language of the following fields in page:
    /// Page.entry_fulfillment.messages
    /// Page.entry_fulfillment.conditional_cases
    /// Page.event_handlers.trigger_fulfillment.messages
    /// Page.event_handlers.trigger_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages
    /// Page.form.parameters.fill_behavior.initial_prompt_fulfillment.conditional_cases
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.messages
    /// Page.form.parameters.fill_behavior.reprompt_event_handlers.conditional_cases
    /// Page.transition_routes.trigger_fulfillment.messages
    /// Page.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&apos;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// The unique identifier of the page.
    /// Format: projects//locations//agents//flows//pages/.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The flow to create a page for.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// Ordered list of TransitionRouteGroups associated with the page. Transition route groups must be unique within a page.
    /// If multiple transition routes within a page scope refer to the same intent, then the precedence order is: page&apos;s transition route -&gt; page&apos;s transition route group -&gt; flow&apos;s transition routes.
    /// If multiple transition route groups within a page contain the same intent, then the first group in the ordered list takes precedence.
    /// Format:projects//locations//agents//flows//transitionRouteGroups/.
    /// </summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// A list of transitions for the transition rules of this page. They route the conversation to another page in the same flow, or another flow.
    /// When we are in a certain page, the TransitionRoutes are evalauted in the following order:
    /// TransitionRoutes defined in the page with intent specified.
    /// TransitionRoutes defined in the transition route groups with intent specified.
    /// TransitionRoutes defined in flow with intent specified.
    /// TransitionRoutes defined in the transition route groups with intent specified.
    /// TransitionRoutes defined in the page with only condition specified.
    /// TransitionRoutes defined in the transition route groups with only condition specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta2PageStatusAtProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatusConditions
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

/// <summary>PageStatus defines the observed state of Page.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PageStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PageStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Page is the Schema for the Pages API. A Dialogflow CX conversation (session) can be described and visualized as a state machine.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Page : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PageSpec>, IStatus<V1beta2PageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Page";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "pages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Page";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PageSpec defines the desired state of Page</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PageSpec Spec { get; set; }

    /// <summary>PageStatus defines the observed state of Page.</summary>
    [JsonPropertyName("status")]
    public V1beta2PageStatus? Status { get; set; }
}