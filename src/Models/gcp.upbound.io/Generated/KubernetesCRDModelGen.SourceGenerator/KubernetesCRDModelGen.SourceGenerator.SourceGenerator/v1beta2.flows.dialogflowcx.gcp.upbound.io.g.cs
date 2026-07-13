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
/// <summary>Flow is the Schema for the Flows API. Flows represents the conversation flows when you build your chatbot agent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FlowList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Flow>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FlowList";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FlowList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Flow objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Flow> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecDeletionPolicyEnum>))]
public enum V1beta2FlowSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>
    /// Client-specific URI that points to an audio clip accessible to the client. Dialogflow does not impose any validation on it.
    /// This field is part of a union field content: Only one of audio or uri may be set.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderAdvancedSettingsDtmfSettings
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

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderAdvancedSettingsLoggingSettings
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
public partial class V1beta2FlowSpecForProviderAdvancedSettingsSpeechSettings
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
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("noSpeechTimeout")]
    public string? NoSpeechTimeout { get; set; }

    /// <summary>Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.</summary>
    [JsonPropertyName("useTimeoutBasedEndpointing")]
    public bool? UseTimeoutBasedEndpointing { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public V1beta2FlowSpecForProviderAdvancedSettingsAudioExportGcsDestination? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2FlowSpecForProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2FlowSpecForProviderAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2FlowSpecForProviderAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessages
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
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowSpecForProviderEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowSpecForProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderEventHandlers
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
    public V1beta2FlowSpecForProviderEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsDataStoreConnections
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelector
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
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicy? Policy { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings
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
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard
{
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages
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
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// This type has no fields.
    /// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
    /// Otherwise, the info card response is skipped.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("knowledgeInfoCard")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard? KnowledgeInfoCard { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector
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
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The fulfillment to be triggered.
/// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillment
{
    /// <summary>
    /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
    /// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookRef")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef? WebhookRef { get; set; }

    /// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookSelector")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector? WebhookSelector { get; set; }
}

/// <summary>
/// Knowledge connector configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderKnowledgeConnectorSettings
{
    /// <summary>
    /// Optional. List of related data store connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataStoreConnections")]
    public IList<V1beta2FlowSpecForProviderKnowledgeConnectorSettingsDataStoreConnections>? DataStoreConnections { get; set; }

    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects//locations//agents//flows/.
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTargetFlowSelector? TargetFlowSelector { get; set; }

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
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettingsTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// NLU related settings of the flow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderNluSettings
{
    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold.
    /// If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.
    /// </summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode.</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderParentRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderParentRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecForProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderParentSelector
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
    public V1beta2FlowSpecForProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelector
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
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessages
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
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProviderTransitionRoutes
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

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta2FlowSpecForProviderTransitionRoutesTargetFlowSelector? TargetFlowSelector { get; set; }

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
    public V1beta2FlowSpecForProviderTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecForProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2FlowSpecForProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// A flow&apos;s event handlers serve two purposes:
    /// They are responsible for handling events (e.g. no match, webhook errors) in the flow.
    /// They are inherited by every page&apos;s [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow.
    /// Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta2FlowSpecForProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>
    /// Marks this as the Default Start Flow for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the google_dialogflow_cx_flow resource does nothing to the underlying GCP resources.
    /// </summary>
    [JsonPropertyName("isDefaultStartFlow")]
    public bool? IsDefaultStartFlow { get; set; }

    /// <summary>
    /// Knowledge connector configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("knowledgeConnectorSettings")]
    public V1beta2FlowSpecForProviderKnowledgeConnectorSettings? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&apos;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// NLU related settings of the flow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nluSettings")]
    public V1beta2FlowSpecForProviderNluSettings? NluSettings { get; set; }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects//locations//agents/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta2FlowSpecForProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta2FlowSpecForProviderParentSelector? ParentSelector { get; set; }

    /// <summary>
    /// A flow&apos;s transition route group serve two purposes:
    /// They are responsible for matching the user&apos;s first utterances in the flow.
    /// They are inherited by every page&apos;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
    /// Format:projects//locations//agents//flows//transitionRouteGroups/.
    /// </summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// A flow&apos;s transition routes serve two purposes:
    /// They are responsible for matching the user&apos;s first utterances in the flow.
    /// They are inherited by every page&apos;s [transition routes][Page.transition_routes] and can support use cases such as the user saying &quot;help&quot; or &quot;can I talk to a human?&quot;, which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow.
    /// TransitionRoutes are evalauted in the following order:
    /// TransitionRoutes with intent specified.
    /// TransitionRoutes with only condition specified.
    /// TransitionRoutes with intent specified are inherited by pages in the flow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta2FlowSpecForProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>
    /// Client-specific URI that points to an audio clip accessible to the client. Dialogflow does not impose any validation on it.
    /// This field is part of a union field content: Only one of audio or uri may be set.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderAdvancedSettingsDtmfSettings
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

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderAdvancedSettingsLoggingSettings
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
public partial class V1beta2FlowSpecInitProviderAdvancedSettingsSpeechSettings
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
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("noSpeechTimeout")]
    public string? NoSpeechTimeout { get; set; }

    /// <summary>Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.</summary>
    [JsonPropertyName("useTimeoutBasedEndpointing")]
    public bool? UseTimeoutBasedEndpointing { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public V1beta2FlowSpecInitProviderAdvancedSettingsAudioExportGcsDestination? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2FlowSpecInitProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2FlowSpecInitProviderAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2FlowSpecInitProviderAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessages
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
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderEventHandlers
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
    public V1beta2FlowSpecInitProviderEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsDataStoreConnections
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelector
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
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelectorPolicy? Policy { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings
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
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard
{
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages
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
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// This type has no fields.
    /// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
    /// Otherwise, the info card response is skipped.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("knowledgeInfoCard")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard? KnowledgeInfoCard { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector
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
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The fulfillment to be triggered.
/// When the answers from the Knowledge Connector are selected by Dialogflow, you can utitlize the request scoped parameter $request.knowledge.answers (contains up to the 5 highest confidence answers) and $request.knowledge.questions (contains the corresponding questions) to construct the fulfillment.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillment
{
    /// <summary>
    /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
    /// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }

    /// <summary>Reference to a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookRef")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookRef? WebhookRef { get; set; }

    /// <summary>Selector for a Webhook in dialogflowcx to populate webhook.</summary>
    [JsonPropertyName("webhookSelector")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillmentWebhookSelector? WebhookSelector { get; set; }
}

/// <summary>
/// Knowledge connector configuration.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderKnowledgeConnectorSettings
{
    /// <summary>
    /// Optional. List of related data store connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataStoreConnections")]
    public IList<V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsDataStoreConnections>? DataStoreConnections { get; set; }

    /// <summary>Whether Knowledge Connector is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// The target flow to transition to. Format: projects//locations//agents//flows/.
    /// This field is part of a union field target: Only one of targetPage or targetFlow may be set.
    /// </summary>
    [JsonPropertyName("targetFlow")]
    public string? TargetFlow { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTargetFlowSelector? TargetFlowSelector { get; set; }

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
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettingsTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// NLU related settings of the flow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderNluSettings
{
    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold.
    /// If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.
    /// </summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode.</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderParentRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderParentRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderParentRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderParentRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderParentRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderParentRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderParentRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderParentRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecInitProviderParentRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderParentSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderParentSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderParentSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderParentSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderParentSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderParentSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderParentSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderParentSelector
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
    public V1beta2FlowSpecInitProviderParentSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum>))]
public enum V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum>))]
public enum V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelector
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
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesText
{
    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public IList<string>? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessages
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
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecInitProviderTransitionRoutes
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

    /// <summary>Reference to a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowRef")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowRef? TargetFlowRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate targetFlow.</summary>
    [JsonPropertyName("targetFlowSelector")]
    public V1beta2FlowSpecInitProviderTransitionRoutesTargetFlowSelector? TargetFlowSelector { get; set; }

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
    public V1beta2FlowSpecInitProviderTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
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
public partial class V1beta2FlowSpecInitProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2FlowSpecInitProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// A flow&apos;s event handlers serve two purposes:
    /// They are responsible for handling events (e.g. no match, webhook errors) in the flow.
    /// They are inherited by every page&apos;s [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow.
    /// Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta2FlowSpecInitProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>
    /// Marks this as the Default Start Flow for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the google_dialogflow_cx_flow resource does nothing to the underlying GCP resources.
    /// </summary>
    [JsonPropertyName("isDefaultStartFlow")]
    public bool? IsDefaultStartFlow { get; set; }

    /// <summary>
    /// Knowledge connector configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("knowledgeConnectorSettings")]
    public V1beta2FlowSpecInitProviderKnowledgeConnectorSettings? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&apos;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// NLU related settings of the flow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nluSettings")]
    public V1beta2FlowSpecInitProviderNluSettings? NluSettings { get; set; }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects//locations//agents/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>Reference to a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentRef")]
    public V1beta2FlowSpecInitProviderParentRef? ParentRef { get; set; }

    /// <summary>Selector for a Agent in dialogflowcx to populate parent.</summary>
    [JsonPropertyName("parentSelector")]
    public V1beta2FlowSpecInitProviderParentSelector? ParentSelector { get; set; }

    /// <summary>
    /// A flow&apos;s transition route group serve two purposes:
    /// They are responsible for matching the user&apos;s first utterances in the flow.
    /// They are inherited by every page&apos;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
    /// Format:projects//locations//agents//flows//transitionRouteGroups/.
    /// </summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// A flow&apos;s transition routes serve two purposes:
    /// They are responsible for matching the user&apos;s first utterances in the flow.
    /// They are inherited by every page&apos;s [transition routes][Page.transition_routes] and can support use cases such as the user saying &quot;help&quot; or &quot;can I talk to a human?&quot;, which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow.
    /// TransitionRoutes are evalauted in the following order:
    /// TransitionRoutes with intent specified.
    /// TransitionRoutes with only condition specified.
    /// TransitionRoutes with intent specified are inherited by pages in the flow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta2FlowSpecInitProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecManagementPoliciesEnum>))]
public enum V1beta2FlowSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FlowSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FlowSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FlowSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FlowSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FlowSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FlowSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FlowSpec defines the desired state of Flow</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowSpec
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
    public V1beta2FlowSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FlowSpecForProvider ForProvider { get; set; }

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
    public V1beta2FlowSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FlowSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FlowSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FlowSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>
    /// Client-specific URI that points to an audio clip accessible to the client. Dialogflow does not impose any validation on it.
    /// This field is part of a union field content: Only one of audio or uri may be set.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderAdvancedSettingsDtmfSettings
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

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderAdvancedSettingsLoggingSettings
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
public partial class V1beta2FlowStatusAtProviderAdvancedSettingsSpeechSettings
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
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("noSpeechTimeout")]
    public string? NoSpeechTimeout { get; set; }

    /// <summary>Use timeout based endpointing, interpreting endpointer sensitivity as seconds of timeout value.</summary>
    [JsonPropertyName("useTimeoutBasedEndpointing")]
    public bool? UseTimeoutBasedEndpointing { get; set; }
}

/// <summary>
/// Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public V1beta2FlowStatusAtProviderAdvancedSettingsAudioExportGcsDestination? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2FlowStatusAtProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2FlowStatusAtProviderAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2FlowStatusAtProviderAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesText
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessages
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
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderEventHandlers
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
    public V1beta2FlowStatusAtProviderEventHandlersTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsDataStoreConnections
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings
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
    /// A duration in seconds with up to nine fractional digits, ending with &apos;s&apos;. Example: &quot;3.5s&quot;.
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings
{
    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesEndInteraction
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard
{
}

/// <summary>
/// Indicates that the conversation should be handed off to a live agent.
/// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
/// You may set this, for example:
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff
{
    /// <summary>Custom metadata. Dialogflow doesn&apos;t impose any structure on this.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudioSegments
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudio
{
    /// <summary>
    /// Segments this audio response is composed of.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("segments")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudioSegments>? Segments { get; set; }
}

/// <summary>
/// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages
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
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// (Output)
    /// This type has no fields.
    /// Indicates that interaction with the Dialogflow agent has ended. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("endInteraction")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesEndInteraction>? EndInteraction { get; set; }

    /// <summary>
    /// This type has no fields.
    /// Represents info card response. If the response contains generative knowledge prediction, Dialogflow will return a payload with Infobot Messenger compatible info card.
    /// Otherwise, the info card response is skipped.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// </summary>
    [JsonPropertyName("knowledgeInfoCard")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesKnowledgeInfoCard? KnowledgeInfoCard { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// (Output)
    /// Represents an audio message that is composed of both segments synthesized from the Dialogflow agent prompts and ones hosted externally at the specified URIs. The external URIs are specified via playAudio. This message is generated by Dialogflow only and not supposed to be defined by the user.
    /// This field is part of a union field message: Only one of text, payload, conversationSuccess, outputAudioText, liveAgentHandoff, endInteraction, playAudio, mixedAudio, telephonyTransferCall, or knowledgeInfoCard may be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mixedAudio")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesMixedAudio>? MixedAudio { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillment
{
    /// <summary>
    /// Hierarchical advanced settings for agent/flow/page/fulfillment/parameter. Settings exposed at lower level overrides the settings exposed at higher level. Overriding occurs at the sub-setting level. For example, the playbackInterruptionSettings at fulfillment level only overrides the playbackInterruptionSettings at the agent level, leaving other settings at the agent level unchanged.
    /// DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// If the flag is true, the agent will utilize LLM to generate a text response.
    /// If LLM generation fails, the defined responses in the fulfillment will be respected.
    /// This flag is only useful for fulfillments associated with no-match event handlers.
    /// </summary>
    [JsonPropertyName("enableGenerativeFallback")]
    public bool? EnableGenerativeFallback { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

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
public partial class V1beta2FlowStatusAtProviderKnowledgeConnectorSettings
{
    /// <summary>
    /// Optional. List of related data store connections.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dataStoreConnections")]
    public IList<V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsDataStoreConnections>? DataStoreConnections { get; set; }

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
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettingsTriggerFulfillment? TriggerFulfillment { get; set; }
}

/// <summary>
/// NLU related settings of the flow.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderNluSettings
{
    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent, you can tune the machine learning classification threshold.
    /// If the returned score value is less than the threshold value, then a no-match event will be triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.
    /// </summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>Indicates NLU model training mode.</summary>
    [JsonPropertyName("modelTrainingMode")]
    public string? ModelTrainingMode { get; set; }

    /// <summary>Indicates the type of NLU model.</summary>
    [JsonPropertyName("modelType")]
    public string? ModelType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentConditionalCases
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall
{
    /// <summary>Transfer the call to a phone number in E.164 format.</summary>
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
}

/// <summary>A collection of text responses.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesText
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessages
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
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesConversationSuccess? ConversationSuccess { get; set; }

    /// <summary>
    /// Indicates that the conversation should be handed off to a live agent.
    /// Dialogflow only uses this to determine which conversations were handed off to a human agent for measurement purposes. What else to do with this signal is up to you and your handoff procedures.
    /// You may set this, for example:
    /// </summary>
    [JsonPropertyName("liveAgentHandoff")]
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesLiveAgentHandoff? LiveAgentHandoff { get; set; }

    /// <summary>
    /// A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the comment on the ResponseMessage message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("outputAudioText")]
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesOutputAudioText? OutputAudioText { get; set; }

    /// <summary>A custom, platform-specific payload.</summary>
    [JsonPropertyName("payload")]
    public string? Payload { get; set; }

    /// <summary>
    /// Specifies an audio clip to be played by the client as part of the response.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("playAudio")]
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesPlayAudio? PlayAudio { get; set; }

    /// <summary>
    /// Represents the signal that telles the client to transfer the phone call connected to the agent to a third-party endpoint.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("telephonyTransferCall")]
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesTelephonyTransferCall? TelephonyTransferCall { get; set; }

    /// <summary>A collection of text responses.</summary>
    [JsonPropertyName("text")]
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessagesText? Text { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentSetParameterActions
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
public partial class V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillment
{
    /// <summary>
    /// Conditional cases for this fulfillment.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionalCases")]
    public IList<V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentConditionalCases>? ConditionalCases { get; set; }

    /// <summary>
    /// The list of rich message responses to present to the user.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("messages")]
    public IList<V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentMessages>? Messages { get; set; }

    /// <summary>Whether Dialogflow should return currently queued fulfillment response messages in streaming APIs. If a webhook is specified, it happens before Dialogflow invokes webhook. Warning: 1) This flag only affects streaming API. Responses are still queued and returned once in non-streaming API. 2) The flag can be enabled in any fulfillment but only the first 3 partial responses will be returned. You may only want to apply it to fulfillments that have slow webhooks.</summary>
    [JsonPropertyName("returnPartialResponses")]
    public bool? ReturnPartialResponses { get; set; }

    /// <summary>
    /// Set parameter values before executing the webhook.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("setParameterActions")]
    public IList<V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillmentSetParameterActions>? SetParameterActions { get; set; }

    /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required if webhook is specified.</summary>
    [JsonPropertyName("tag")]
    public string? Tag { get; set; }

    /// <summary>The webhook to call. Format: projects//locations//agents//webhooks/.</summary>
    [JsonPropertyName("webhook")]
    public string? Webhook { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProviderTransitionRoutes
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
    public V1beta2FlowStatusAtProviderTransitionRoutesTriggerFulfillment? TriggerFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusAtProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this flow. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2FlowStatusAtProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the flow.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// A flow&apos;s event handlers serve two purposes:
    /// They are responsible for handling events (e.g. no match, webhook errors) in the flow.
    /// They are inherited by every page&apos;s [event handlers][Page.event_handlers], which can be used to handle common events regardless of the current page. Event handlers defined in the page have higher priority than those defined in the flow.
    /// Unlike transitionRoutes, these handlers are evaluated on a first-match basis. The first one that matches the event get executed, with the rest being ignored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventHandlers")]
    public IList<V1beta2FlowStatusAtProviderEventHandlers>? EventHandlers { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/flows/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Marks this as the Default Start Flow for an agent. When you create an agent, the Default Start Flow is created automatically.
    /// The Default Start Flow cannot be deleted; deleting the google_dialogflow_cx_flow resource does nothing to the underlying GCP resources.
    /// </summary>
    [JsonPropertyName("isDefaultStartFlow")]
    public bool? IsDefaultStartFlow { get; set; }

    /// <summary>
    /// Knowledge connector configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("knowledgeConnectorSettings")]
    public V1beta2FlowStatusAtProviderKnowledgeConnectorSettings? KnowledgeConnectorSettings { get; set; }

    /// <summary>
    /// The language of the following fields in flow:
    /// Flow.event_handlers.trigger_fulfillment.messages
    /// Flow.event_handlers.trigger_fulfillment.conditional_cases
    /// Flow.transition_routes.trigger_fulfillment.messages
    /// Flow.transition_routes.trigger_fulfillment.conditional_cases
    /// If not specified, the agent&apos;s default language is used. Many languages are supported. Note: languages must be enabled in the agent before they can be used.
    /// </summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>
    /// The unique identifier of the flow.
    /// Format: projects//locations//agents//flows/.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// NLU related settings of the flow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nluSettings")]
    public V1beta2FlowStatusAtProviderNluSettings? NluSettings { get; set; }

    /// <summary>
    /// The agent to create a flow for.
    /// Format: projects//locations//agents/.
    /// </summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// A flow&apos;s transition route group serve two purposes:
    /// They are responsible for matching the user&apos;s first utterances in the flow.
    /// They are inherited by every page&apos;s [transition route groups][Page.transition_route_groups]. Transition route groups defined in the page have higher priority than those defined in the flow.
    /// Format:projects//locations//agents//flows//transitionRouteGroups/.
    /// </summary>
    [JsonPropertyName("transitionRouteGroups")]
    public IList<string>? TransitionRouteGroups { get; set; }

    /// <summary>
    /// A flow&apos;s transition routes serve two purposes:
    /// They are responsible for matching the user&apos;s first utterances in the flow.
    /// They are inherited by every page&apos;s [transition routes][Page.transition_routes] and can support use cases such as the user saying &quot;help&quot; or &quot;can I talk to a human?&quot;, which can be handled in a common way regardless of the current page. Transition routes defined in the page have higher priority than those defined in the flow.
    /// TransitionRoutes are evalauted in the following order:
    /// TransitionRoutes with intent specified.
    /// TransitionRoutes with only condition specified.
    /// TransitionRoutes with intent specified are inherited by pages in the flow.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transitionRoutes")]
    public IList<V1beta2FlowStatusAtProviderTransitionRoutes>? TransitionRoutes { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatusConditions
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

/// <summary>FlowStatus defines the observed state of Flow.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FlowStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FlowStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FlowStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Flow is the Schema for the Flows API. Flows represents the conversation flows when you build your chatbot agent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Flow : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FlowSpec>, IStatus<V1beta2FlowStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Flow";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "flows";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Flow";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FlowSpec defines the desired state of Flow</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FlowSpec Spec { get; set; }

    /// <summary>FlowStatus defines the observed state of Flow.</summary>
    [JsonPropertyName("status")]
    public V1beta2FlowStatus? Status { get; set; }
}