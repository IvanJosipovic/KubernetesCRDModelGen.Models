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
/// <summary>Agent is the Schema for the Agents API. Agents are best described as Natural Language Understanding (NLU) modules that transform user requests into actionable data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AgentList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Agent>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AgentList";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "agents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AgentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Agent objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Agent> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AgentSpecDeletionPolicyEnum>))]
public enum V1beta2AgentSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>
    /// The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation.
    /// Format: gs://bucket/object-name-or-prefix
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderAdvancedSettingsDtmfSettings
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

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderAdvancedSettingsLoggingSettings
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
public partial class V1beta2AgentSpecForProviderAdvancedSettingsSpeechSettings
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
/// Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public V1beta2AgentSpecForProviderAdvancedSettingsAudioExportGcsDestination? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2AgentSpecForProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2AgentSpecForProviderAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2AgentSpecForProviderAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

/// <summary>
/// Gen App Builder-related agent-level settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderGenAppBuilderSettings
{
    /// <summary>
    /// The full name of the Gen App Builder engine related to this agent if there is one.
    /// Format: projects/{Project ID}/locations/{Location ID}/collections/{Collection ID}/engines/{Engine ID}
    /// </summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }
}

/// <summary>
/// The access token used to authenticate the access to the GitHub repository.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef
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

/// <summary>
/// Settings of integration with GitHub.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderGitIntegrationSettingsGithubSettings
{
    /// <summary>
    /// The access token used to authenticate the access to the GitHub repository.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2AgentSpecForProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>A list of branches configured to be used from Dialogflow.</summary>
    [JsonPropertyName("branches")]
    public IList<string>? Branches { get; set; }

    /// <summary>The unique repository display name for the GitHub repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The GitHub repository URI related to the agent.</summary>
    [JsonPropertyName("repositoryUri")]
    public string? RepositoryUri { get; set; }

    /// <summary>The branch of the GitHub repository tracked for this agent.</summary>
    [JsonPropertyName("trackingBranch")]
    public string? TrackingBranch { get; set; }
}

/// <summary>
/// Git integration settings for this agent.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderGitIntegrationSettings
{
    /// <summary>
    /// Settings of integration with GitHub.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubSettings")]
    public V1beta2AgentSpecForProviderGitIntegrationSettingsGithubSettings? GithubSettings { get; set; }
}

/// <summary>
/// Settings related to speech recognition.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

/// <summary>
/// Settings related to speech synthesizing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProviderTextToSpeechSettings
{
    /// <summary>
    /// Configuration of how speech should be synthesized, mapping from language to SynthesizeSpeechConfig.
    /// These settings affect:
    /// </summary>
    [JsonPropertyName("synthesizeSpeechConfigs")]
    public string? SynthesizeSpeechConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecForProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2AgentSpecForProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The URI of the agent&apos;s avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>
    /// The default language of the agent as a language tag. See Language Support
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>Otherwise, the chat engine will persist.</summary>
    [JsonPropertyName("deleteChatEngineOnDestroy")]
    public bool? DeleteChatEngineOnDestroy { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Gen App Builder-related agent-level settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genAppBuilderSettings")]
    public V1beta2AgentSpecForProviderGenAppBuilderSettings? GenAppBuilderSettings { get; set; }

    /// <summary>
    /// Git integration settings for this agent.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitIntegrationSettings")]
    public V1beta2AgentSpecForProviderGitIntegrationSettings? GitIntegrationSettings { get; set; }

    /// <summary>
    /// The name of the location this agent is located in.
    /// ~&gt; Note: The first time you are deploying an Agent in your project you must configure location settings.
    /// This is a one time step but at the moment you can only configure location settings via the Dialogflow CX console.
    /// Another options is to use global location so you don&apos;t need to manually configure location settings.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>
    /// Settings related to speech recognition.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("speechToTextSettings")]
    public V1beta2AgentSpecForProviderSpeechToTextSettings? SpeechToTextSettings { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>
    /// Settings related to speech synthesizing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textToSpeechSettings")]
    public V1beta2AgentSpecForProviderTextToSpeechSettings? TextToSpeechSettings { get; set; }

    /// <summary>
    /// The time zone of this agent from the time zone database, e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>
    /// The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation.
    /// Format: gs://bucket/object-name-or-prefix
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderAdvancedSettingsDtmfSettings
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

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderAdvancedSettingsLoggingSettings
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
public partial class V1beta2AgentSpecInitProviderAdvancedSettingsSpeechSettings
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
/// Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public V1beta2AgentSpecInitProviderAdvancedSettingsAudioExportGcsDestination? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2AgentSpecInitProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2AgentSpecInitProviderAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2AgentSpecInitProviderAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

/// <summary>
/// Gen App Builder-related agent-level settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderGenAppBuilderSettings
{
    /// <summary>
    /// The full name of the Gen App Builder engine related to this agent if there is one.
    /// Format: projects/{Project ID}/locations/{Location ID}/collections/{Collection ID}/engines/{Engine ID}
    /// </summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }
}

/// <summary>
/// The access token used to authenticate the access to the GitHub repository.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef
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

/// <summary>
/// Settings of integration with GitHub.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderGitIntegrationSettingsGithubSettings
{
    /// <summary>
    /// The access token used to authenticate the access to the GitHub repository.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("accessTokenSecretRef")]
    public V1beta2AgentSpecInitProviderGitIntegrationSettingsGithubSettingsAccessTokenSecretRef? AccessTokenSecretRef { get; set; }

    /// <summary>A list of branches configured to be used from Dialogflow.</summary>
    [JsonPropertyName("branches")]
    public IList<string>? Branches { get; set; }

    /// <summary>The unique repository display name for the GitHub repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The GitHub repository URI related to the agent.</summary>
    [JsonPropertyName("repositoryUri")]
    public string? RepositoryUri { get; set; }

    /// <summary>The branch of the GitHub repository tracked for this agent.</summary>
    [JsonPropertyName("trackingBranch")]
    public string? TrackingBranch { get; set; }
}

/// <summary>
/// Git integration settings for this agent.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderGitIntegrationSettings
{
    /// <summary>
    /// Settings of integration with GitHub.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubSettings")]
    public V1beta2AgentSpecInitProviderGitIntegrationSettingsGithubSettings? GithubSettings { get; set; }
}

/// <summary>
/// Settings related to speech recognition.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

/// <summary>
/// Settings related to speech synthesizing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecInitProviderTextToSpeechSettings
{
    /// <summary>
    /// Configuration of how speech should be synthesized, mapping from language to SynthesizeSpeechConfig.
    /// These settings affect:
    /// </summary>
    [JsonPropertyName("synthesizeSpeechConfigs")]
    public string? SynthesizeSpeechConfigs { get; set; }
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
public partial class V1beta2AgentSpecInitProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2AgentSpecInitProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The URI of the agent&apos;s avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>
    /// The default language of the agent as a language tag. See Language Support
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>Otherwise, the chat engine will persist.</summary>
    [JsonPropertyName("deleteChatEngineOnDestroy")]
    public bool? DeleteChatEngineOnDestroy { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Gen App Builder-related agent-level settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genAppBuilderSettings")]
    public V1beta2AgentSpecInitProviderGenAppBuilderSettings? GenAppBuilderSettings { get; set; }

    /// <summary>
    /// Git integration settings for this agent.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitIntegrationSettings")]
    public V1beta2AgentSpecInitProviderGitIntegrationSettings? GitIntegrationSettings { get; set; }

    /// <summary>
    /// The name of the location this agent is located in.
    /// ~&gt; Note: The first time you are deploying an Agent in your project you must configure location settings.
    /// This is a one time step but at the moment you can only configure location settings via the Dialogflow CX console.
    /// Another options is to use global location so you don&apos;t need to manually configure location settings.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>
    /// Settings related to speech recognition.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("speechToTextSettings")]
    public V1beta2AgentSpecInitProviderSpeechToTextSettings? SpeechToTextSettings { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>
    /// Settings related to speech synthesizing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textToSpeechSettings")]
    public V1beta2AgentSpecInitProviderTextToSpeechSettings? TextToSpeechSettings { get; set; }

    /// <summary>
    /// The time zone of this agent from the time zone database, e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AgentSpecManagementPoliciesEnum>))]
public enum V1beta2AgentSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AgentSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AgentSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AgentSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AgentSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AgentSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AgentSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AgentSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AgentSpec defines the desired state of Agent</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentSpec
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
    public V1beta2AgentSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AgentSpecForProvider ForProvider { get; set; }

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
    public V1beta2AgentSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2AgentSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AgentSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AgentSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderAdvancedSettingsAudioExportGcsDestination
{
    /// <summary>
    /// The Google Cloud Storage URI for the exported objects. Whether a full object name, or just a prefix, its usage depends on the Dialogflow operation.
    /// Format: gs://bucket/object-name-or-prefix
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderAdvancedSettingsDtmfSettings
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

/// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderAdvancedSettingsLoggingSettings
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
public partial class V1beta2AgentStatusAtProviderAdvancedSettingsSpeechSettings
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
/// Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level.
/// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderAdvancedSettings
{
    /// <summary>If present, incoming audio is exported by Dialogflow to the configured Google Cloud Storage destination. Exposed at the following levels:</summary>
    [JsonPropertyName("audioExportGcsDestination")]
    public V1beta2AgentStatusAtProviderAdvancedSettingsAudioExportGcsDestination? AudioExportGcsDestination { get; set; }

    /// <summary>Define behaviors for DTMF (dual tone multi frequency). DTMF settings does not override each other. DTMF settings set at different levels define DTMF detections running in parallel. Exposed at the following levels:</summary>
    [JsonPropertyName("dtmfSettings")]
    public V1beta2AgentStatusAtProviderAdvancedSettingsDtmfSettings? DtmfSettings { get; set; }

    /// <summary>Settings for logging. Settings for Dialogflow History, Contact Center messages, StackDriver logs, and speech logging. Exposed at the following levels:</summary>
    [JsonPropertyName("loggingSettings")]
    public V1beta2AgentStatusAtProviderAdvancedSettingsLoggingSettings? LoggingSettings { get; set; }

    /// <summary>Settings for speech to text detection. Exposed at the following levels:</summary>
    [JsonPropertyName("speechSettings")]
    public V1beta2AgentStatusAtProviderAdvancedSettingsSpeechSettings? SpeechSettings { get; set; }
}

/// <summary>
/// Gen App Builder-related agent-level settings.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderGenAppBuilderSettings
{
    /// <summary>
    /// The full name of the Gen App Builder engine related to this agent if there is one.
    /// Format: projects/{Project ID}/locations/{Location ID}/collections/{Collection ID}/engines/{Engine ID}
    /// </summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }
}

/// <summary>
/// Settings of integration with GitHub.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderGitIntegrationSettingsGithubSettings
{
    /// <summary>A list of branches configured to be used from Dialogflow.</summary>
    [JsonPropertyName("branches")]
    public IList<string>? Branches { get; set; }

    /// <summary>The unique repository display name for the GitHub repository.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The GitHub repository URI related to the agent.</summary>
    [JsonPropertyName("repositoryUri")]
    public string? RepositoryUri { get; set; }

    /// <summary>The branch of the GitHub repository tracked for this agent.</summary>
    [JsonPropertyName("trackingBranch")]
    public string? TrackingBranch { get; set; }
}

/// <summary>
/// Git integration settings for this agent.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderGitIntegrationSettings
{
    /// <summary>
    /// Settings of integration with GitHub.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("githubSettings")]
    public V1beta2AgentStatusAtProviderGitIntegrationSettingsGithubSettings? GithubSettings { get; set; }
}

/// <summary>
/// Settings related to speech recognition.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderSpeechToTextSettings
{
    /// <summary>Whether to use speech adaptation for speech recognition.</summary>
    [JsonPropertyName("enableSpeechAdaptation")]
    public bool? EnableSpeechAdaptation { get; set; }
}

/// <summary>
/// Settings related to speech synthesizing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProviderTextToSpeechSettings
{
    /// <summary>
    /// Configuration of how speech should be synthesized, mapping from language to SynthesizeSpeechConfig.
    /// These settings affect:
    /// </summary>
    [JsonPropertyName("synthesizeSpeechConfigs")]
    public string? SynthesizeSpeechConfigs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusAtProvider
{
    /// <summary>
    /// Hierarchical advanced settings for this agent. The settings exposed at the lower level overrides the settings exposed at the higher level.
    /// Hierarchy: Agent-&gt;Flow-&gt;Page-&gt;Fulfillment/Parameter.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("advancedSettings")]
    public V1beta2AgentStatusAtProviderAdvancedSettings? AdvancedSettings { get; set; }

    /// <summary>The URI of the agent&apos;s avatar. Avatars are used throughout the Dialogflow console and in the self-hosted Web Demo integration.</summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>
    /// The default language of the agent as a language tag. See Language Support
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [JsonPropertyName("defaultLanguageCode")]
    public string? DefaultLanguageCode { get; set; }

    /// <summary>Otherwise, the chat engine will persist.</summary>
    [JsonPropertyName("deleteChatEngineOnDestroy")]
    public bool? DeleteChatEngineOnDestroy { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The human-readable name of the agent, unique within the location.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
    [JsonPropertyName("enableSpellCorrection")]
    public bool? EnableSpellCorrection { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableStackdriverLogging")]
    public bool? EnableStackdriverLogging { get; set; }

    /// <summary>
    /// Gen App Builder-related agent-level settings.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("genAppBuilderSettings")]
    public V1beta2AgentStatusAtProviderGenAppBuilderSettings? GenAppBuilderSettings { get; set; }

    /// <summary>
    /// Git integration settings for this agent.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("gitIntegrationSettings")]
    public V1beta2AgentStatusAtProviderGitIntegrationSettings? GitIntegrationSettings { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/agents/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The name of the location this agent is located in.
    /// ~&gt; Note: The first time you are deploying an Agent in your project you must configure location settings.
    /// This is a one time step but at the moment you can only configure location settings via the Dialogflow CX console.
    /// Another options is to use global location so you don&apos;t need to manually configure location settings.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The unique identifier of the agent.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>Name of the SecuritySettings reference for the agent. Format: projects//locations//securitySettings/.</summary>
    [JsonPropertyName("securitySettings")]
    public string? SecuritySettings { get; set; }

    /// <summary>
    /// Settings related to speech recognition.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("speechToTextSettings")]
    public V1beta2AgentStatusAtProviderSpeechToTextSettings? SpeechToTextSettings { get; set; }

    /// <summary>Name of the start flow in this agent. A start flow will be automatically created when the agent is created, and can only be deleted by deleting the agent. Format: projects//locations//agents//flows/.</summary>
    [JsonPropertyName("startFlow")]
    public string? StartFlow { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the default_language_code).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    /// <summary>
    /// Settings related to speech synthesizing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("textToSpeechSettings")]
    public V1beta2AgentStatusAtProviderTextToSpeechSettings? TextToSpeechSettings { get; set; }

    /// <summary>
    /// The time zone of this agent from the time zone database, e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatusConditions
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

/// <summary>AgentStatus defines the observed state of Agent.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AgentStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AgentStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AgentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Agent is the Schema for the Agents API. Agents are best described as Natural Language Understanding (NLU) modules that transform user requests into actionable data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Agent : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AgentSpec>, IStatus<V1beta2AgentStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Agent";
    public const string KubeGroup = "dialogflowcx.gcp.upbound.io";
    public const string KubePluralName = "agents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflowcx.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Agent";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AgentSpec defines the desired state of Agent</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AgentSpec Spec { get; set; }

    /// <summary>AgentStatus defines the observed state of Agent.</summary>
    [JsonPropertyName("status")]
    public V1beta2AgentStatus? Status { get; set; }
}