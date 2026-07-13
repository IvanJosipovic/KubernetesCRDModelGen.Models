#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.speech.cnrm.cloud.google.com;
/// <summary>SpeechRecognizer is the Schema for the SpeechRecognizer API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpeechRecognizerList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SpeechRecognizer>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpeechRecognizerList";
    public const string KubeGroup = "speech.cnrm.cloud.google.com";
    public const string KubePluralName = "speechrecognizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "speech.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpeechRecognizerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SpeechRecognizer objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SpeechRecognizer> Items { get; set; }
}

/// <summary>Default configuration to use for requests with this Recognizer. This can be overwritten by inline configuration in the [RecognizeRequest.config][google.cloud.speech.v2.RecognizeRequest.config] field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerSpecDefaultRecognitionConfig
{
    /// <summary>
    /// Optional. The language of the supplied audio as a
    ///  [BCP-47](https://www.rfc-editor.org/rfc/bcp/bcp47.txt) language tag.
    ///  Language tags are normalized to BCP-47 before they are used eg &quot;en-us&quot;
    ///  becomes &quot;en-US&quot;.
    /// 
    ///  Supported languages for each model are listed in the [Table of Supported
    ///  Models](https://cloud.google.com/speech-to-text/v2/docs/speech-to-text-supported-languages).
    /// 
    ///  If additional languages are provided, recognition result will contain
    ///  recognition in the most likely language detected. The recognition result
    ///  will include the language tag of the language detected in the audio.
    /// </summary>
    [JsonPropertyName("languageCodes")]
    public IList<string>? LanguageCodes { get; set; }

    /// <summary>
    /// Optional. Which model to use for recognition requests. Select the model
    ///  best suited to your domain to get best results.
    /// 
    ///  Guidance for choosing which model to use can be found in the [Transcription
    ///  Models
    ///  Documentation](https://cloud.google.com/speech-to-text/v2/docs/transcription-model)
    ///  and the models supported in each region can be found in the [Table Of
    ///  Supported
    ///  Models](https://cloud.google.com/speech-to-text/v2/docs/speech-to-text-supported-languages).
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>SpeechRecognizerSpec defines the desired state of SpeechRecognizer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerSpec
{
    /// <summary>Allows users to store small amounts of arbitrary data. Both the key and the value must be 63 characters or less each. At most 100 annotations.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Default configuration to use for requests with this Recognizer. This can be overwritten by inline configuration in the [RecognizeRequest.config][google.cloud.speech.v2.RecognizeRequest.config] field.</summary>
    [JsonPropertyName("defaultRecognitionConfig")]
    public V1alpha1SpeechRecognizerSpecDefaultRecognitionConfig? DefaultRecognitionConfig { get; set; }

    /// <summary>User-settable, human-readable name for the Recognizer. Must be 63 characters or less.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1SpeechRecognizerSpecProjectRef ProjectRef { get; set; }

    /// <summary>The SpeechRecognizer name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatusConditions
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
public partial class V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptationCustomClasses
{
    /// <summary>Output only. Creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which this resource was requested for deletion.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields. This may be sent on update, undelete, and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The time at which this resource will be purged.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The [KMS key name](https://cloud.google.com/kms/docs/resource-hierarchy#keys) with which the CustomClass is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Output only. The [KMS key version name](https://cloud.google.com/kms/docs/resource-hierarchy#key_versions) with which the CustomClass is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }

    /// <summary>Output only. Identifier. The resource name of the CustomClass. Format: `projects/{project}/locations/{location}/customClasses/{custom_class}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Whether or not this CustomClass is in the process of being updated.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The CustomClass lifecycle state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-assigned unique identifier for the CustomClass.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The most recent time this resource was modified.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>An inline defined PhraseSet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptationPhraseSetsInlinePhraseSet
{
    /// <summary>Output only. Creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which this resource was requested for deletion.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields. This may be sent on update, undelete, and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The time at which this resource will be purged.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The [KMS key name](https://cloud.google.com/kms/docs/resource-hierarchy#keys) with which the PhraseSet is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Output only. The [KMS key version name](https://cloud.google.com/kms/docs/resource-hierarchy#key_versions) with which the PhraseSet is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }

    /// <summary>Output only. Identifier. The resource name of the PhraseSet. Format: `projects/{project}/locations/{location}/phraseSets/{phrase_set}`.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. Whether or not this PhraseSet is in the process of being updated.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The PhraseSet lifecycle state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-assigned unique identifier for the PhraseSet.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The most recent time this resource was modified.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptationPhraseSets
{
    /// <summary>An inline defined PhraseSet.</summary>
    [JsonPropertyName("inlinePhraseSet")]
    public V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptationPhraseSetsInlinePhraseSet? InlinePhraseSet { get; set; }
}

/// <summary>Speech adaptation context that weights recognizer predictions for specific words and phrases.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptation
{
    /// <summary>A list of inline CustomClasses. Existing CustomClass resources can be referenced directly in a PhraseSet.</summary>
    [JsonPropertyName("customClasses")]
    public IList<V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptationCustomClasses>? CustomClasses { get; set; }

    /// <summary>A list of inline or referenced PhraseSets.</summary>
    [JsonPropertyName("phraseSets")]
    public IList<V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptationPhraseSets>? PhraseSets { get; set; }
}

/// <summary>Default configuration to use for requests with this Recognizer. This can be overwritten by inline configuration in the [RecognizeRequest.config][google.cloud.speech.v2.RecognizeRequest.config] field.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfig
{
    /// <summary>Speech adaptation context that weights recognizer predictions for specific words and phrases.</summary>
    [JsonPropertyName("adaptation")]
    public V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfigAdaptation? Adaptation { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatusObservedState
{
    /// <summary>Output only. Creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Default configuration to use for requests with this Recognizer. This can be overwritten by inline configuration in the [RecognizeRequest.config][google.cloud.speech.v2.RecognizeRequest.config] field.</summary>
    [JsonPropertyName("defaultRecognitionConfig")]
    public V1alpha1SpeechRecognizerStatusObservedStateDefaultRecognitionConfig? DefaultRecognitionConfig { get; set; }

    /// <summary>Output only. The time at which this Recognizer was requested for deletion.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. This checksum is computed by the server based on the value of other fields. This may be sent on update, undelete, and delete requests to ensure the client has an up-to-date value before proceeding.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. The time at which this Recognizer will be purged.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>Output only. The [KMS key name](https://cloud.google.com/kms/docs/resource-hierarchy#keys) with which the Recognizer is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}`.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>Output only. The [KMS key version name](https://cloud.google.com/kms/docs/resource-hierarchy#key_versions) with which the Recognizer is encrypted. The expected format is `projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}`.</summary>
    [JsonPropertyName("kmsKeyVersionName")]
    public string? KmsKeyVersionName { get; set; }

    /// <summary>Output only. Whether or not this Recognizer is in the process of being updated.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The Recognizer lifecycle state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. System-assigned unique identifier for the Recognizer.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The most recent time this Recognizer was modified.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>SpeechRecognizerStatus defines the config connector machine state of SpeechRecognizer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SpeechRecognizerStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SpeechRecognizerStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the SpeechRecognizer resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1SpeechRecognizerStatusObservedState? ObservedState { get; set; }
}

/// <summary>SpeechRecognizer is the Schema for the SpeechRecognizer API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SpeechRecognizer : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SpeechRecognizerSpec>, IStatus<V1alpha1SpeechRecognizerStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SpeechRecognizer";
    public const string KubeGroup = "speech.cnrm.cloud.google.com";
    public const string KubePluralName = "speechrecognizers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "speech.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpeechRecognizer";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpeechRecognizerSpec defines the desired state of SpeechRecognizer</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SpeechRecognizerSpec Spec { get; set; }

    /// <summary>SpeechRecognizerStatus defines the config connector machine state of SpeechRecognizer</summary>
    [JsonPropertyName("status")]
    public V1alpha1SpeechRecognizerStatus? Status { get; set; }
}