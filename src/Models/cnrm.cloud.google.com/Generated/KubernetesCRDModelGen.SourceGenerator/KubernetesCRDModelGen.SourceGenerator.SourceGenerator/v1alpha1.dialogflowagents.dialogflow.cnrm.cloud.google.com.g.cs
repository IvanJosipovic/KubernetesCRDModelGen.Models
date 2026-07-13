#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflow.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowAgentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DialogflowAgent>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowAgentList";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowagents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowAgentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DialogflowAgent objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DialogflowAgent> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowAgentSpec
{
    /// <summary>
    /// API version displayed in Dialogflow console. If not specified, V2 API is assumed. Clients are free to query
    /// different service endpoints for different API versions. However, bots connectors and webhook calls will follow
    /// the specified API version.
    /// * API_VERSION_V1: Legacy V1 API.
    /// * API_VERSION_V2: V2 API.
    /// * API_VERSION_V2_BETA_1: V2beta1 API. Possible values: [&quot;API_VERSION_V1&quot;, &quot;API_VERSION_V2&quot;, &quot;API_VERSION_V2_BETA_1&quot;].
    /// </summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>
    /// The URI of the agent&apos;s avatar, which are used throughout the Dialogflow console. When an image URL is entered
    /// into this field, the Dialogflow will save the image in the backend. The address of the backend image returned
    /// from the API will be shown in the [avatarUriBackend] field.
    /// </summary>
    [JsonPropertyName("avatarUri")]
    public string? AvatarUri { get; set; }

    /// <summary>
    /// To filter out false positive results and still get variety in matched natural language inputs for your agent,
    /// you can tune the machine learning classification threshold. If the returned score value is less than the threshold
    /// value, then a fallback intent will be triggered or, if there are no fallback intents defined, no intent will be
    /// triggered. The score values range from 0.0 (completely uncertain) to 1.0 (completely certain). If set to 0.0, the
    /// default of 0.3 is used.
    /// </summary>
    [JsonPropertyName("classificationThreshold")]
    public double? ClassificationThreshold { get; set; }

    /// <summary>
    /// Immutable. The default language of the agent as a language tag. [See Language Support](https://cloud.google.com/dialogflow/docs/reference/language)
    /// for a list of the currently supported language codes. This field cannot be updated after creation.
    /// </summary>
    [JsonPropertyName("defaultLanguageCode")]
    public required string DefaultLanguageCode { get; set; }

    /// <summary>The description of this agent. The maximum length is 500 characters. If exceeded, the request is rejected.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The name of this agent.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Determines whether this agent should log conversation queries.</summary>
    [JsonPropertyName("enableLogging")]
    public bool? EnableLogging { get; set; }

    /// <summary>
    /// Determines how intents are detected from user queries.
    /// * MATCH_MODE_HYBRID: Best for agents with a small number of examples in intents and/or wide use of templates
    /// syntax and composite entities.
    /// * MATCH_MODE_ML_ONLY: Can be used for agents with a large number of examples in intents, especially the ones
    /// using @sys.any or very large developer entities. Possible values: [&quot;MATCH_MODE_HYBRID&quot;, &quot;MATCH_MODE_ML_ONLY&quot;].
    /// </summary>
    [JsonPropertyName("matchMode")]
    public string? MatchMode { get; set; }

    /// <summary>Immutable. Optional. The project of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The list of all languages supported by this agent (except for the defaultLanguageCode).</summary>
    [JsonPropertyName("supportedLanguageCodes")]
    public IList<string>? SupportedLanguageCodes { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>
    /// The time zone of this agent from the [time zone database](https://www.iana.org/time-zones), e.g., America/New_York,
    /// Europe/Paris.
    /// </summary>
    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowAgentStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowAgentStatus
{
    /// <summary>
    /// The URI of the agent&apos;s avatar as returned from the API. Output only. To provide an image URL for the agent avatar,
    /// the [avatarUri] field can be used.
    /// </summary>
    [JsonPropertyName("avatarUriBackend")]
    public string? AvatarUriBackend { get; set; }

    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowAgentStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowAgent : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowAgentSpec>, IStatus<V1alpha1DialogflowAgentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowAgent";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowagents";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowAgent";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1DialogflowAgentSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1DialogflowAgentStatus? Status { get; set; }
}