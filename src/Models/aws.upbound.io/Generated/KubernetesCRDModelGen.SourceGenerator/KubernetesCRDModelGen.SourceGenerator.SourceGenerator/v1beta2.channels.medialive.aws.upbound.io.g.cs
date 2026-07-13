#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.medialive.aws.upbound.io;
/// <summary>Channel is the Schema for the Channels API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ChannelList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Channel>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ChannelList";
    public const string KubeGroup = "medialive.aws.upbound.io";
    public const string KubePluralName = "channels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "medialive.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ChannelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Channel objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Channel> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecDeletionPolicyEnum>))]
public enum V1beta2ChannelSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderCdiInputSpecification
{
    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderDestinationsMediaPackageSettings
{
    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }
}

/// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderDestinationsMultiplexSettings
{
    /// <summary>The ID of the Multiplex that the encoder is providing output to.</summary>
    [JsonPropertyName("multiplexId")]
    public string? MultiplexId { get; set; }

    /// <summary>The program name of the Multiplex program that the encoder is providing output to.</summary>
    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderDestinationsSettings
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }

    /// <summary>A URL specifying a destination.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderDestinations
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Destination settings for a MediaPackage output; one destination for both encoders. See Media Package Settings for more details.</summary>
    [JsonPropertyName("mediaPackageSettings")]
    public IList<V1beta2ChannelSpecForProviderDestinationsMediaPackageSettings>? MediaPackageSettings { get; set; }

    /// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
    [JsonPropertyName("multiplexSettings")]
    public V1beta2ChannelSpecForProviderDestinationsMultiplexSettings? MultiplexSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta2ChannelSpecForProviderDestinationsSettings>? Settings { get; set; }
}

/// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings
{
    /// <summary>Audio normalization algorithm to use. itu17701 conforms to the CALM Act specification, itu17702 to the EBU R-128 specification.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Algorithm control for the audio description.</summary>
    [JsonPropertyName("algorithmControl")]
    public string? AlgorithmControl { get; set; }

    /// <summary>Target LKFS (loudness) to adjust volume to.</summary>
    [JsonPropertyName("targetLkfs")]
    public double? TargetLkfs { get; set; }
}

/// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
{
    [JsonPropertyName("cbetCheckDigitString")]
    public string? CbetCheckDigitString { get; set; }

    /// <summary>Determines the method of CBET insertion mode when prior encoding is detected on the same layer.</summary>
    [JsonPropertyName("cbetStepaside")]
    public string? CbetStepaside { get; set; }

    /// <summary>CBET source ID to use in the watermark.</summary>
    [JsonPropertyName("csid")]
    public string? Csid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings
{
    [JsonPropertyName("checkDigitString")]
    public string? CheckDigitString { get; set; }

    /// <summary>The Nielsen Source ID to include in the watermark.</summary>
    [JsonPropertyName("sid")]
    public double? Sid { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings
{
    /// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
    [JsonPropertyName("nielsenCbetSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings? NielsenCbetSettings { get; set; }

    /// <summary>Distribution types to assign to the watermarks. Options are PROGRAM_CONTENT and FINAL_DISTRIBUTOR.</summary>
    [JsonPropertyName("nielsenDistributionType")]
    public string? NielsenDistributionType { get; set; }

    /// <summary>Used to insert watermarks of type Nielsen NAES, II (N2) and Nielsen NAES VI (NW). See Nielsen NAES II NW Settings for more details.</summary>
    [JsonPropertyName("nielsenNaesIiNwSettings")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings>? NielsenNaesIiNwSettings { get; set; }
}

/// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("nielsenWatermarksSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings? NielsenWatermarksSettings { get; set; }
}

/// <summary>Aac Settings. See AAC Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Set to &quot;broadcasterMixedAd&quot; when input contains pre-mixed main audio + AD (narration) as a stereo pair.</summary>
    [JsonPropertyName("inputType")]
    public string? InputType { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets LATM/LOAS AAC output for raw containers.</summary>
    [JsonPropertyName("rawFormat")]
    public string? RawFormat { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }

    /// <summary>Use MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.</summary>
    [JsonPropertyName("spec")]
    public string? Spec { get; set; }

    /// <summary>VBR Quality Level - Only used if rateControlMode is VBR.</summary>
    [JsonPropertyName("vbrQuality")]
    public string? VbrQuality { get; set; }
}

/// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined in the Dolby Digital specification.</summary>
    [JsonPropertyName("drcProfile")]
    public string? DrcProfile { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }
}

/// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary>Height dimensional trim.</summary>
    [JsonPropertyName("heightTrim")]
    public double? HeightTrim { get; set; }

    /// <summary>Surround dimensional trim.</summary>
    [JsonPropertyName("surroundTrim")]
    public double? SurroundTrim { get; set; }
}

/// <summary>- Eac3 Settings. See EAC3 Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
{
    /// <summary>Sets the attenuation control.</summary>
    [JsonPropertyName("attenuationControl")]
    public string? AttenuationControl { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    [JsonPropertyName("dcFilter")]
    public string? DcFilter { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    [JsonPropertyName("lfeControl")]
    public string? LfeControl { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoCenterMixLevel")]
    public double? LoRoCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoSurroundMixLevel")]
    public double? LoRoSurroundMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtCenterMixLevel")]
    public double? LtRtCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtSurroundMixLevel")]
    public double? LtRtSurroundMixLevel { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }

    [JsonPropertyName("passthroughControl")]
    public string? PassthroughControl { get; set; }

    [JsonPropertyName("phaseControl")]
    public string? PhaseControl { get; set; }

    [JsonPropertyName("stereoDownmix")]
    public string? StereoDownmix { get; set; }

    [JsonPropertyName("surroundExMode")]
    public string? SurroundExMode { get; set; }

    [JsonPropertyName("surroundMode")]
    public string? SurroundMode { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings
{
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings
{
    [JsonPropertyName("bitDepth")]
    public double? BitDepth { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettings
{
    /// <summary>Aac Settings. See AAC Settings for more details.</summary>
    [JsonPropertyName("aacSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings? AacSettings { get; set; }

    /// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
    [JsonPropertyName("ac3Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings? Ac3Settings { get; set; }

    /// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
    [JsonPropertyName("eac3AtmosSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings? Eac3AtmosSettings { get; set; }

    /// <summary>- Eac3 Settings. See EAC3 Settings</summary>
    [JsonPropertyName("eac3Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings? Eac3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("mp2Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings? Mp2Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("passThroughSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings? PassThroughSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("wavSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings? WavSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
{
    [JsonPropertyName("gain")]
    public double? Gain { get; set; }

    [JsonPropertyName("inputChannel")]
    public double? InputChannel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
{
    [JsonPropertyName("inputChannelLevels")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels>? InputChannelLevels { get; set; }

    [JsonPropertyName("outputChannel")]
    public double? OutputChannel { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettings
{
    [JsonPropertyName("channelMappings")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings>? ChannelMappings { get; set; }

    [JsonPropertyName("channelsIn")]
    public double? ChannelsIn { get; set; }

    [JsonPropertyName("channelsOut")]
    public double? ChannelsOut { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptions
{
    /// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
    [JsonPropertyName("audioNormalizationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings? AudioNormalizationSettings { get; set; }

    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn&apos;t create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC 13818-1.</summary>
    [JsonPropertyName("audioType")]
    public string? AudioType { get; set; }

    /// <summary>Determined how audio type is determined.</summary>
    [JsonPropertyName("audioTypeControl")]
    public string? AudioTypeControl { get; set; }

    /// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
    [JsonPropertyName("audioWatermarkSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings? AudioWatermarkSettings { get; set; }

    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsCodecSettings? CodecSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("languageCodeControl")]
    public string? LanguageCodeControl { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("remixSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptionsRemixSettings? RemixSettings { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAvailBlankingAvailBlankingImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsAvailBlanking
{
    /// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
    [JsonPropertyName("availBlankingImage")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAvailBlankingAvailBlankingImage? AvailBlankingImage { get; set; }

    /// <summary>When set to enabled, causes video, audio and captions to be blanked when insertion metadata is added.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ARIB Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings
{
}

/// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
{
    /// <summary>If no explicit xPosition or yPosition is provided, setting alignment to centered will place the captions at the bottom center of the output. Similarly, setting a left alignment will align captions to the bottom left of the output. If x and y positions are given in conjunction with the alignment parameter, the font will be justified (either left or centered) relative to those coordinates. Selecting “smart” justification will left-justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont? Font { get; set; }

    /// <summary>Specifies the color of the burned-in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>Font resolution in DPI (dots per inch); default is 96 dpi. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>When set to ‘auto’ fontSize will scale depending on the size of the output. Giving a positive integer will specify the exact font size in points. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>Specifies font outline color. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>Specifies font outline size in pixels. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>Specifies the horizontal offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>Specifies the vertical offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Controls whether a fixed grid size will be used to generate the output subtitles bitmap. Only applicable for Teletext inputs and DVB-Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>Specifies the horizontal position of the caption relative to the left side of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the left of the output. If no explicit xPosition is provided, the horizontal caption position will be determined by the alignment parameter. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>Specifies the vertical position of the caption relative to the top of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit yPosition is provided, the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings
{
    /// <summary>If no explicit xPosition or yPosition is provided, setting alignment to centered will place the captions at the bottom center of the output. Similarly, setting a left alignment will align captions to the bottom left of the output. If x and y positions are given in conjunction with the alignment parameter, the font will be justified (either left or centered) relative to those coordinates. Selecting “smart” justification will left-justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont? Font { get; set; }

    /// <summary>Specifies the color of the burned-in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>Font resolution in DPI (dots per inch); default is 96 dpi. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>When set to ‘auto’ fontSize will scale depending on the size of the output. Giving a positive integer will specify the exact font size in points. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>Specifies font outline color. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>Specifies font outline size in pixels. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>Specifies the horizontal offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>Specifies the vertical offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Controls whether a fixed grid size will be used to generate the output subtitles bitmap. Only applicable for Teletext inputs and DVB-Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>Specifies the horizontal position of the caption relative to the left side of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the left of the output. If no explicit xPosition is provided, the horizontal caption position will be determined by the alignment parameter. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>Specifies the vertical position of the caption relative to the top of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit yPosition is provided, the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
{
    /// <summary>Complete this field if you want to include the name of the copyright holder in the copyright tag in the captions metadata.</summary>
    [JsonPropertyName("copyrightHolder")]
    public string? CopyrightHolder { get; set; }

    /// <summary>Specifies how to handle the gap between the lines (in multi-line captions). - enabled: Fill with the captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.</summary>
    [JsonPropertyName("fillLineGap")]
    public string? FillLineGap { get; set; }

    /// <summary>Specifies the font family to include in the font data attached to the EBU-TT captions. Valid only if styleControl is set to include. If you leave this field empty, the font family is set to “monospaced”. (If styleControl is set to exclude, the font family is always set to “monospaced”.) You specify only the font family. All other style information (color, bold, position and so on) is copied from the input captions. The size is always set to 100% to allow the downstream player to choose the size. - Enter a list of font families, as a comma-separated list of font names, in order of preference. The name can be a font family (such as “Arial”), or a generic font family (such as “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the family to “monospace”.</summary>
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>Embedded Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings
{
}

/// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings
{
}

/// <summary>RTMP Caption Info Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings
{
}

/// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings
{
}

/// <summary>SCTE27 Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings
{
}

/// <summary>SMPTE TT Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings
{
}

/// <summary>Teletext Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings
{
}

/// <summary>TTML Destination Settings. See TTML Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
{
    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
{
    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettings
{
    /// <summary>ARIB Destination Settings.</summary>
    [JsonPropertyName("aribDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings? AribDestinationSettings { get; set; }

    /// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
    [JsonPropertyName("burnInDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings? BurnInDestinationSettings { get; set; }

    /// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
    [JsonPropertyName("dvbSubDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings? DvbSubDestinationSettings { get; set; }

    /// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
    [JsonPropertyName("ebuTtDDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings? EbuTtDDestinationSettings { get; set; }

    /// <summary>Embedded Destination Settings.</summary>
    [JsonPropertyName("embeddedDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings? EmbeddedDestinationSettings { get; set; }

    /// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
    [JsonPropertyName("embeddedPlusScte20DestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings? EmbeddedPlusScte20DestinationSettings { get; set; }

    /// <summary>RTMP Caption Info Destination Settings.</summary>
    [JsonPropertyName("rtmpCaptionInfoDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings? RtmpCaptionInfoDestinationSettings { get; set; }

    /// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
    [JsonPropertyName("scte20PlusEmbeddedDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings? Scte20PlusEmbeddedDestinationSettings { get; set; }

    /// <summary>SCTE27 Destination Settings.</summary>
    [JsonPropertyName("scte27DestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings? Scte27DestinationSettings { get; set; }

    /// <summary>SMPTE TT Destination Settings.</summary>
    [JsonPropertyName("smpteTtDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings? SmpteTtDestinationSettings { get; set; }

    /// <summary>Teletext Destination Settings.</summary>
    [JsonPropertyName("teletextDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings? TeletextDestinationSettings { get; set; }

    /// <summary>TTML Destination Settings. See TTML Destination Settings for more details.</summary>
    [JsonPropertyName("ttmlDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings? TtmlDestinationSettings { get; set; }

    /// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
    [JsonPropertyName("webvttDestinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings? WebvttDestinationSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptions
{
    /// <summary>Indicates whether the caption track implements accessibility features such as written descriptions of spoken dialog, music, and sounds.</summary>
    [JsonPropertyName("accessibility")]
    public string? Accessibility { get; set; }

    /// <summary>Specifies which input caption selector to use as a caption source when generating output captions. This field should match a captionSelector name.</summary>
    [JsonPropertyName("captionSelectorName")]
    public string? CaptionSelectorName { get; set; }

    /// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
    [JsonPropertyName("destinationSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptionsDestinationSettings? DestinationSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehavior
{
    [JsonPropertyName("blackFrameMsec")]
    public double? BlackFrameMsec { get; set; }

    [JsonPropertyName("inputLossImageColor")]
    public string? InputLossImageColor { get; set; }

    [JsonPropertyName("inputLossImageSlate")]
    public V1beta2ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlate { get; set; }

    [JsonPropertyName("inputLossImageType")]
    public string? InputLossImageType { get; set; }

    [JsonPropertyName("repeatFrameMsec")]
    public double? RepeatFrameMsec { get; set; }
}

/// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsGlobalConfiguration
{
    /// <summary>Value to set the initial audio gain for the Live Event.</summary>
    [JsonPropertyName("initialAudioGain")]
    public double? InitialAudioGain { get; set; }

    /// <summary>Indicates the action to take when the current input completes (e.g. end-of-file). When switchAndLoopInputs is configured the encoder will restart at the beginning of the first input. When “none” is configured the encoder will transcode either black, a solid color, or a user specified slate images per the “Input Loss Behavior” configuration until the next input switch occurs (which is controlled through the Channel Schedule API).</summary>
    [JsonPropertyName("inputEndAction")]
    public string? InputEndAction { get; set; }

    /// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
    [JsonPropertyName("inputLossBehavior")]
    public V1beta2ChannelSpecForProviderEncoderSettingsGlobalConfigurationInputLossBehavior? InputLossBehavior { get; set; }

    /// <summary>Indicates how MediaLive pipelines are synchronized. PIPELINE_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the Unix epoch.</summary>
    [JsonPropertyName("outputLockingMode")]
    public string? OutputLockingMode { get; set; }

    /// <summary>Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock (which optionally may be locked to another source via NTP) or should be locked to the clock of the source that is providing the input stream.</summary>
    [JsonPropertyName("outputTimingSource")]
    public string? OutputTimingSource { get; set; }

    /// <summary>Adjusts video input buffer for streams with very low video framerates. This is commonly set to enabled for music channels with less than one video frame per second.</summary>
    [JsonPropertyName("supportLowFramerateInputs")]
    public string? SupportLowFramerateInputs { get; set; }
}

/// <summary>Html Motion Graphics Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings
{
}

/// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
{
    /// <summary>Html Motion Graphics Settings.</summary>
    [JsonPropertyName("htmlMotionGraphicsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings? HtmlMotionGraphicsSettings { get; set; }
}

/// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsMotionGraphicsConfiguration
{
    /// <summary>Motion Graphics Insertion.</summary>
    [JsonPropertyName("motionGraphicsInsertion")]
    public string? MotionGraphicsInsertion { get; set; }

    /// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
    [JsonPropertyName("motionGraphicsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings? MotionGraphicsSettings { get; set; }
}

/// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsNielsenConfiguration
{
    /// <summary>Enter the Distributor ID assigned to your organization by Nielsen.</summary>
    [JsonPropertyName("distributorId")]
    public string? DistributorId { get; set; }

    /// <summary>Enables Nielsen PCM to ID3 tagging.</summary>
    [JsonPropertyName("nielsenPcmToId3Tagging")]
    public string? NielsenPcmToId3Tagging { get; set; }
}

/// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings
{
    /// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
    [JsonPropertyName("archiveS3Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings? ArchiveS3Settings { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings
{
    /// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
    [JsonPropertyName("archiveCdnSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings? ArchiveCdnSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination? Destination { get; set; }

    /// <summary>Number of seconds to write to archive file before closing and starting a new one.</summary>
    [JsonPropertyName("rolloverInterval")]
    public double? RolloverInterval { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureS3Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings? FrameCaptureS3Settings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination? Destination { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureCdnSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings? FrameCaptureCdnSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings
{
    [JsonPropertyName("captionChannel")]
    public double? CaptionChannel { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    [JsonPropertyName("salt")]
    public string? Salt { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("mediaStoreStorageClass")]
    public string? MediaStoreStorageClass { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsAkamaiSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings? HlsAkamaiSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsBasicPutSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings? HlsBasicPutSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsMediaStoreSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings? HlsMediaStoreSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsS3Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings? HlsS3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsWebdavSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings? HlsWebdavSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings
{
    [JsonPropertyName("keyProviderServer")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer? KeyProviderServer { get; set; }

    [JsonPropertyName("staticKeyValue")]
    public string? StaticKeyValue { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("staticKeySettings")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings>? StaticKeySettings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    [JsonPropertyName("baseUrlContent")]
    public string? BaseUrlContent { get; set; }

    [JsonPropertyName("baseUrlContent1")]
    public string? BaseUrlContent1 { get; set; }

    [JsonPropertyName("baseUrlManifest")]
    public string? BaseUrlManifest { get; set; }

    [JsonPropertyName("baseUrlManifest1")]
    public string? BaseUrlManifest1 { get; set; }

    [JsonPropertyName("captionLanguageMappings")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings>? CaptionLanguageMappings { get; set; }

    [JsonPropertyName("captionLanguageSetting")]
    public string? CaptionLanguageSetting { get; set; }

    [JsonPropertyName("clientCache")]
    public string? ClientCache { get; set; }

    [JsonPropertyName("codecSpecification")]
    public string? CodecSpecification { get; set; }

    [JsonPropertyName("constantIv")]
    public string? ConstantIv { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination? Destination { get; set; }

    [JsonPropertyName("directoryStructure")]
    public string? DirectoryStructure { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("discontinuityTags")]
    public string? DiscontinuityTags { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsCdnSettings")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings>? HlsCdnSettings { get; set; }

    [JsonPropertyName("hlsId3SegmentTagging")]
    public string? HlsId3SegmentTagging { get; set; }

    [JsonPropertyName("iframeOnlyPlaylists")]
    public string? IframeOnlyPlaylists { get; set; }

    [JsonPropertyName("incompleteSegmentBehavior")]
    public string? IncompleteSegmentBehavior { get; set; }

    [JsonPropertyName("indexNSegments")]
    public double? IndexNSegments { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    [JsonPropertyName("ivInManifest")]
    public string? IvInManifest { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("ivSource")]
    public string? IvSource { get; set; }

    [JsonPropertyName("keepSegments")]
    public double? KeepSegments { get; set; }

    [JsonPropertyName("keyFormat")]
    public string? KeyFormat { get; set; }

    [JsonPropertyName("keyFormatVersions")]
    public string? KeyFormatVersions { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("keyProviderSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings? KeyProviderSettings { get; set; }

    [JsonPropertyName("manifestCompression")]
    public string? ManifestCompression { get; set; }

    [JsonPropertyName("manifestDurationFormat")]
    public string? ManifestDurationFormat { get; set; }

    [JsonPropertyName("minSegmentLength")]
    public double? MinSegmentLength { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("outputSelection")]
    public string? OutputSelection { get; set; }

    [JsonPropertyName("programDateTime")]
    public string? ProgramDateTime { get; set; }

    [JsonPropertyName("programDateTimeClock")]
    public string? ProgramDateTimeClock { get; set; }

    [JsonPropertyName("programDateTimePeriod")]
    public double? ProgramDateTimePeriod { get; set; }

    [JsonPropertyName("redundantManifest")]
    public string? RedundantManifest { get; set; }

    [JsonPropertyName("segmentLength")]
    public double? SegmentLength { get; set; }

    [JsonPropertyName("segmentsPerSubdirectory")]
    public double? SegmentsPerSubdirectory { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("streamInfResolution")]
    public string? StreamInfResolution { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }

    [JsonPropertyName("timestampDeltaMilliseconds")]
    public double? TimestampDeltaMilliseconds { get; set; }

    [JsonPropertyName("tsFileMode")]
    public string? TsFileMode { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination? Destination { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("acquisitionPointId")]
    public string? AcquisitionPointId { get; set; }

    [JsonPropertyName("audioOnlyTimecodeControl")]
    public string? AudioOnlyTimecodeControl { get; set; }

    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination? Destination { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    [JsonPropertyName("eventIdMode")]
    public string? EventIdMode { get; set; }

    [JsonPropertyName("eventStopBehavior")]
    public string? EventStopBehavior { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("fragmentLength")]
    public double? FragmentLength { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    [JsonPropertyName("segmentationMode")]
    public string? SegmentationMode { get; set; }

    [JsonPropertyName("sendDelayMs")]
    public double? SendDelayMs { get; set; }

    [JsonPropertyName("sparseTrackType")]
    public string? SparseTrackType { get; set; }

    [JsonPropertyName("streamManifestBehavior")]
    public string? StreamManifestBehavior { get; set; }

    [JsonPropertyName("timestampOffset")]
    public string? TimestampOffset { get; set; }

    [JsonPropertyName("timestampOffsetMode")]
    public string? TimestampOffsetMode { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings
{
}

/// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary>Authentication scheme to use when connecting with CDN.</summary>
    [JsonPropertyName("authenticationScheme")]
    public string? AuthenticationScheme { get; set; }

    /// <summary>Controls behavior when content cache fills up.</summary>
    [JsonPropertyName("cacheFullBehavior")]
    public string? CacheFullBehavior { get; set; }

    /// <summary>Cache length in seconds, is used to calculate buffer size.</summary>
    [JsonPropertyName("cacheLength")]
    public double? CacheLength { get; set; }

    /// <summary>Controls the types of data that passes to onCaptionInfo outputs.</summary>
    [JsonPropertyName("captionData")]
    public string? CaptionData { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings
{
    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }
}

/// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettings
{
    /// <summary>Archive group settings. See Archive Group Settings for more details.</summary>
    [JsonPropertyName("archiveGroupSettings")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings>? ArchiveGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings? FrameCaptureGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings? HlsGroupSettings { get; set; }

    /// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
    [JsonPropertyName("mediaPackageGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? MediaPackageGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("msSmoothGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? MsSmoothGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("multiplexGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings? MultiplexGroupSettings { get; set; }

    /// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
    [JsonPropertyName("rtmpGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings? RtmpGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("udpGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings? UdpGroupSettings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings
{
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings? DvbSdtSettings { get; set; }

    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Raw Settings. This can be set as an empty block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings
{
}

/// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings? M2tsSettings { get; set; }

    /// <summary>Raw Settings. This can be set as an empty block.</summary>
    [JsonPropertyName("rawSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings? RawSettings { get; set; }
}

/// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings
{
    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings? ContainerSettings { get; set; }

    /// <summary>Output file extension.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings
{
    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("audioGroupId")]
    public string? AudioGroupId { get; set; }

    [JsonPropertyName("audioOnlyImage")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage? AudioOnlyImage { get; set; }

    [JsonPropertyName("audioTrackType")]
    public string? AudioTrackType { get; set; }

    [JsonPropertyName("segmentType")]
    public string? SegmentType { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
{
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings
{
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings
{
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("scte35Behavior")]
    public string? Scte35Behavior { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings
{
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("m3u8Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings? M3u8Settings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("audioOnlyHlsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings? AudioOnlyHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("fmp4HlsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings? Fmp4HlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureHlsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings? FrameCaptureHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("standardHlsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings? StandardHlsSettings { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings
{
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings? HlsSettings { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }

    [JsonPropertyName("segmentModifier")]
    public string? SegmentModifier { get; set; }
}

/// <summary>Media package output settings. This can be set as an empty block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings
{
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
{
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination? Destination { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings
{
    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination? Destination { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings
{
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings? DvbSdtSettings { get; set; }

    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings? M2tsSettings { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
{
    /// <summary>The height of the FEC protection matrix.</summary>
    [JsonPropertyName("columnDepth")]
    public double? ColumnDepth { get; set; }

    /// <summary>Enables column only or column and row based FEC.</summary>
    [JsonPropertyName("includeFec")]
    public string? IncludeFec { get; set; }

    /// <summary>The width of the FEC protection matrix.</summary>
    [JsonPropertyName("rowLength")]
    public double? RowLength { get; set; }
}

/// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings
{
    /// <summary>UDP output buffering in milliseconds.</summary>
    [JsonPropertyName("bufferMsec")]
    public double? BufferMsec { get; set; }

    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings? ContainerSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination? Destination { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("fecOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings? FecOutputSettings { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettings
{
    /// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
    [JsonPropertyName("archiveOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings? ArchiveOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("frameCaptureOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings? FrameCaptureOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("hlsOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings? HlsOutputSettings { get; set; }

    /// <summary>Media package output settings. This can be set as an empty block.</summary>
    [JsonPropertyName("mediaPackageOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings? MediaPackageOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("msSmoothOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings? MsSmoothOutputSettings { get; set; }

    /// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
    [JsonPropertyName("multiplexOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings? MultiplexOutputSettings { get; set; }

    /// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
    [JsonPropertyName("rtmpOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings? RtmpOutputSettings { get; set; }

    /// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
    [JsonPropertyName("udpOutputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings? UdpOutputSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputs
{
    /// <summary>The names of the audio descriptions used as audio sources for the output.</summary>
    [JsonPropertyName("audioDescriptionNames")]
    public IList<string>? AudioDescriptionNames { get; set; }

    /// <summary>The names of the caption descriptions used as caption sources for the output.</summary>
    [JsonPropertyName("captionDescriptionNames")]
    public IList<string>? CaptionDescriptionNames { get; set; }

    /// <summary>The name used to identify an output.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("outputSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputsOutputSettings? OutputSettings { get; set; }

    /// <summary>The name of the video description used as video source for the output.</summary>
    [JsonPropertyName("videoDescriptionName")]
    public string? VideoDescriptionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsOutputGroups
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
    [JsonPropertyName("outputGroupSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputGroupSettings? OutputGroupSettings { get; set; }

    /// <summary>List of outputs. See Outputs for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsOutputGroupsOutputs>? Outputs { get; set; }
}

/// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsTimecodeConfig
{
    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Threshold in frames beyond which output timecode is resynchronized to the input timecode.</summary>
    [JsonPropertyName("syncThreshold")]
    public double? SyncThreshold { get; set; }
}

/// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
{
    /// <summary>The frequency at which to capture frames for inclusion in the output.</summary>
    [JsonPropertyName("captureInterval")]
    public double? CaptureInterval { get; set; }

    /// <summary>Unit for the frame capture interval.</summary>
    [JsonPropertyName("captureIntervalUnits")]
    public string? CaptureIntervalUnits { get; set; }
}

/// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings? TemporalFilterSettings { get; set; }
}

/// <summary>H264 settings. See H264 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufFillPct")]
    public double? BufFillPct { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Entropy encoding mode.</summary>
    [JsonPropertyName("entropyEncoding")]
    public string? EntropyEncoding { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Controls whether coding is performed on a field basis or on a frame basis.</summary>
    [JsonPropertyName("forceFieldPictures")]
    public string? ForceFieldPictures { get; set; }

    /// <summary>Indicates how the output video frame rate is specified.</summary>
    [JsonPropertyName("framerateControl")]
    public string? FramerateControl { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>GOP-B reference.</summary>
    [JsonPropertyName("gopBReference")]
    public string? GopBReference { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>Number of B-frames between reference frames.</summary>
    [JsonPropertyName("gopNumBFrames")]
    public double? GopNumBFrames { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>Min interval.</summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Number of reference frames to use.</summary>
    [JsonPropertyName("numRefFrames")]
    public double? NumRefFrames { get; set; }

    /// <summary>Indicates how the output pixel aspect ratio is specified.</summary>
    [JsonPropertyName("parControl")]
    public string? ParControl { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Quality level.</summary>
    [JsonPropertyName("qualityLevel")]
    public string? QualityLevel { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Softness.</summary>
    [JsonPropertyName("softness")]
    public double? Softness { get; set; }

    /// <summary>Makes adjustments within each frame based on spatial variation of content complexity.</summary>
    [JsonPropertyName("spatialAq")]
    public string? SpatialAq { get; set; }

    /// <summary>Subgop length.</summary>
    [JsonPropertyName("subgopLength")]
    public string? SubgopLength { get; set; }

    /// <summary>Produces a bitstream compliant with SMPTE RP-2027.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }

    /// <summary>Makes adjustments within each frame based on temporal variation of content complexity.</summary>
    [JsonPropertyName("temporalAq")]
    public string? TemporalAq { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary>Sets the colorspace metadata to be passed through.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings
{
}

/// <summary>Set the colorspace to Dolby Vision81.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings
{
}

/// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
{
    /// <summary>Sets the MaxCLL value for HDR10.</summary>
    [JsonPropertyName("maxCll")]
    public double? MaxCll { get; set; }

    /// <summary>Sets the MaxFALL value for HDR10.</summary>
    [JsonPropertyName("maxFall")]
    public double? MaxFall { get; set; }
}

/// <summary>Set the colorspace to Rec. 601.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings
{
}

/// <summary>Set the colorspace to Rec. 709.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings
{
}

/// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings
{
    /// <summary>Sets the colorspace metadata to be passed through.</summary>
    [JsonPropertyName("colorSpacePassthroughSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings? ColorSpacePassthroughSettings { get; set; }

    /// <summary>Set the colorspace to Dolby Vision81.</summary>
    [JsonPropertyName("dolbyVision81Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings? DolbyVision81Settings { get; set; }

    /// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
    [JsonPropertyName("hdr10Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings? Hdr10Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 601.</summary>
    [JsonPropertyName("rec601Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings? Rec601Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 709.</summary>
    [JsonPropertyName("rec709Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings? Rec709Settings { get; set; }
}

/// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings? TemporalFilterSettings { get; set; }
}

/// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings
{
    /// <summary>Set a prefix on the burned in timecode.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Sets the size of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninFontSize")]
    public string? TimecodeBurninFontSize { get; set; }

    /// <summary>Sets the position of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninPosition")]
    public string? TimecodeBurninPosition { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Whether or not EML should insert an Alternative Transfer Function SEI message.</summary>
    [JsonPropertyName("alternativeTransferFunction")]
    public string? AlternativeTransferFunction { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
    [JsonPropertyName("colorSpaceSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings? ColorSpaceSettings { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>Min interval.</summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Set the minimum QP.</summary>
    [JsonPropertyName("minQp")]
    public double? MinQp { get; set; }

    /// <summary>Enables or disables motion vector over picture boundaries.</summary>
    [JsonPropertyName("mvOverPictureBoundaries")]
    public string? MvOverPictureBoundaries { get; set; }

    /// <summary>Enables or disables the motion vector temporal predictor.</summary>
    [JsonPropertyName("mvTemporalPredictor")]
    public string? MvTemporalPredictor { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Set the H265 tier in the output.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Sets the height of tiles.</summary>
    [JsonPropertyName("tileHeight")]
    public double? TileHeight { get; set; }

    /// <summary>Enables or disables padding of tiles.</summary>
    [JsonPropertyName("tilePadding")]
    public string? TilePadding { get; set; }

    /// <summary>Sets the width of tiles.</summary>
    [JsonPropertyName("tileWidth")]
    public double? TileWidth { get; set; }

    /// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
    [JsonPropertyName("timecodeBurninSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings? TimecodeBurninSettings { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }

    /// <summary>Sets the size of the treeblock.</summary>
    [JsonPropertyName("treeblockSize")]
    public string? TreeblockSize { get; set; }
}

/// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettings
{
    /// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
    [JsonPropertyName("frameCaptureSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings? FrameCaptureSettings { get; set; }

    /// <summary>H264 settings. See H264 Settings for more details.</summary>
    [JsonPropertyName("h264Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings? H264Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("h265Settings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings? H265Settings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptions
{
    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptionsCodecSettings? CodecSettings { get; set; }

    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, &quot;80&quot; means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicate how to respond to the AFD values that might be in the input video.</summary>
    [JsonPropertyName("respondToAfd")]
    public string? RespondToAfd { get; set; }

    /// <summary>Behavior on how to scale.</summary>
    [JsonPropertyName("scalingBehavior")]
    public string? ScalingBehavior { get; set; }

    /// <summary>Changes the strength of the anti-alias filter used for scaling.</summary>
    [JsonPropertyName("sharpness")]
    public double? Sharpness { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, &quot;80&quot; means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Encoder settings. See Encoder Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderEncoderSettings
{
    /// <summary>Audio descriptions for the channel. See Audio Descriptions for more details.</summary>
    [JsonPropertyName("audioDescriptions")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsAudioDescriptions>? AudioDescriptions { get; set; }

    /// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
    [JsonPropertyName("availBlanking")]
    public V1beta2ChannelSpecForProviderEncoderSettingsAvailBlanking? AvailBlanking { get; set; }

    /// <summary>Caption Descriptions. See Caption Descriptions for more details.</summary>
    [JsonPropertyName("captionDescriptions")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsCaptionDescriptions>? CaptionDescriptions { get; set; }

    /// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1beta2ChannelSpecForProviderEncoderSettingsGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
    [JsonPropertyName("motionGraphicsConfiguration")]
    public V1beta2ChannelSpecForProviderEncoderSettingsMotionGraphicsConfiguration? MotionGraphicsConfiguration { get; set; }

    /// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
    [JsonPropertyName("nielsenConfiguration")]
    public V1beta2ChannelSpecForProviderEncoderSettingsNielsenConfiguration? NielsenConfiguration { get; set; }

    /// <summary>Output groups for the channel. See Output Groups for more details.</summary>
    [JsonPropertyName("outputGroups")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsOutputGroups>? OutputGroups { get; set; }

    /// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
    [JsonPropertyName("timecodeConfig")]
    public V1beta2ChannelSpecForProviderEncoderSettingsTimecodeConfig? TimecodeConfig { get; set; }

    /// <summary>Video Descriptions. See Video Descriptions for more details.</summary>
    [JsonPropertyName("videoDescriptions")]
    public IList<V1beta2ChannelSpecForProviderEncoderSettingsVideoDescriptions>? VideoDescriptions { get; set; }
}

/// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
{
    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn&apos;t create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be silent before automatic input failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.</summary>
    [JsonPropertyName("audioSilenceThresholdMsec")]
    public double? AudioSilenceThresholdMsec { get; set; }
}

/// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
{
    /// <summary>The amount of time (in milliseconds) that no input is detected. After that time, an input failover will occur.</summary>
    [JsonPropertyName("inputLossThresholdMsec")]
    public double? InputLossThresholdMsec { get; set; }
}

/// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
{
    /// <summary>A value used in calculating the threshold below which MediaLive considers a pixel to be &apos;black&apos;. For the input to be considered black, every pixel in a frame must be below this threshold. The threshold is calculated as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.1 in 10-bit color depth: (10230.1=102.3), which means a pixel value of 102 or less is &apos;black&apos;. If you set this field to .1 in an 8-bit color depth: (2550.1=25.5), which means a pixel value of 25 or less is &apos;black&apos;. The range is 0.0 to 1.0, with any number of decimal places.</summary>
    [JsonPropertyName("blackDetectThreshold")]
    public double? BlackDetectThreshold { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be black before automatic input failover occurs.</summary>
    [JsonPropertyName("videoBlackThresholdMsec")]
    public double? VideoBlackThresholdMsec { get; set; }
}

/// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
{
    /// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
    [JsonPropertyName("audioSilenceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings? AudioSilenceSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
    [JsonPropertyName("inputLossSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings? InputLossSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
    [JsonPropertyName("videoBlackSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings? VideoBlackSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
{
    /// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
    [JsonPropertyName("failoverConditionSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings? FailoverConditionSettings { get; set; }
}

/// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettings
{
    /// <summary>This clear time defines the requirement a recovered input must meet to be considered healthy. The input must have no failover conditions for this length of time. Enter a time in milliseconds. This value is particularly important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.</summary>
    [JsonPropertyName("errorClearTimeMsec")]
    public double? ErrorClearTimeMsec { get; set; }

    /// <summary>A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover to the other input. See Failover Condition Block for more details.</summary>
    [JsonPropertyName("failoverCondition")]
    public IList<V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition>? FailoverCondition { get; set; }

    /// <summary>Input preference when deciding which input to make active when a previously failed input has recovered.</summary>
    [JsonPropertyName("inputPreference")]
    public string? InputPreference { get; set; }

    /// <summary>The input ID of the secondary input in the automatic input failover pair.</summary>
    [JsonPropertyName("secondaryInputId")]
    public string? SecondaryInputId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicyResolveEnum>))]
public enum V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicyResolveEnum>))]
public enum V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelector
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
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>When set to “strict”, the transport stream demux strictly identifies audio streams by their language descriptor. If a PMT update occurs such that an audio stream matching the initially selected language is no longer present then mute will be encoded until the language returns. If “loose”, then on a PMT update the demux will choose another audio stream in the program with the same stream type if it can’t find one with the same language.</summary>
    [JsonPropertyName("languageSelectionPolicy")]
    public string? LanguageSelectionPolicy { get; set; }
}

/// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
{
    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode
{
    /// <summary>Applies only to Dolby E. Enter the program ID (according to the metadata in the audio) of the Dolby E program to extract from the specified track. One program extracted per audio selector. To select multiple programs, create multiple selectors with the same Track and different Program numbers. “All channels” means to ignore the program IDs and include all the channels in this selector; useful if metadata is known to be incorrect.</summary>
    [JsonPropertyName("programSelection")]
    public string? ProgramSelection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks
{
    /// <summary>1-based integer value that maps to a specific audio track.</summary>
    [JsonPropertyName("track")]
    public double? Track { get; set; }
}

/// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection
{
    /// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
    [JsonPropertyName("dolbyEDecode")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode? DolbyEDecode { get; set; }

    /// <summary>Selects one or more unique audio tracks from within a source. See Audio Tracks for more details.</summary>
    [JsonPropertyName("tracks")]
    public IList<V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks>? Tracks { get; set; }
}

/// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings
{
    /// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
    [JsonPropertyName("audioHlsRenditionSelection")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection? AudioHlsRenditionSelection { get; set; }

    /// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
    [JsonPropertyName("audioLanguageSelection")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection? AudioLanguageSelection { get; set; }

    /// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
    [JsonPropertyName("audioPidSelection")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection? AudioPidSelection { get; set; }

    /// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
    [JsonPropertyName("audioTrackSelection")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection? AudioTrackSelection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelector
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings? SelectorSettings { get; set; }
}

/// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
{
    /// <summary>Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary captions. If you plan to convert the ancillary captions to another format, complete this field. If you plan to choose Embedded as the captions destination in the output (to pass through all the channels in the ancillary captions), leave this field blank because MediaLive ignores the field.</summary>
    [JsonPropertyName("sourceAncillaryChannelNumber")]
    public double? SourceAncillaryChannelNumber { get; set; }
}

/// <summary>ARIB Source Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings
{
}

/// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Set to “auto” to handle streams with intermittent and/or non-aligned SCTE-20 and Embedded captions.</summary>
    [JsonPropertyName("scte20Detection")]
    public string? Scte20Detection { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
{
    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, &quot;80&quot; means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you don’t have either of these formats in the output.) You can define a display rectangle for the captions that is smaller than the underlying video frame. You define the rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the rectangle, all within the underlying video frame. The units for the measurements are percentages. If you specify a value for one of these fields, you must specify a value for all of them. For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the underlying frame width, and relative to the left edge of the frame. For example, &quot;10&quot; means the measurement is 10% of the underlying frame width. The rectangle left edge starts at that position from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.</summary>
    [JsonPropertyName("leftOffset")]
    public double? LeftOffset { get; set; }

    /// <summary>See the description in left_offset. For top_offset, specify the position of the top edge of the rectangle, as a percentage of the underlying frame height, and relative to the top edge of the frame. For example, &quot;10&quot; means the measurement is 10% of the underlying frame height. The rectangle top edge starts at that position from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.</summary>
    [JsonPropertyName("topOffset")]
    public double? TopOffset { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, &quot;80&quot; means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
{
    /// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
    [JsonPropertyName("outputRectangle")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle? OutputRectangle { get; set; }

    /// <summary>Specifies the teletext page number within the data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303). Unused for passthrough. Should be specified as a hexadecimal string with no “0x” prefix.</summary>
    [JsonPropertyName("pageNumber")]
    public string? PageNumber { get; set; }
}

/// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings
{
    /// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
    [JsonPropertyName("ancillarySourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings? AncillarySourceSettings { get; set; }

    /// <summary>ARIB Source Settings.</summary>
    [JsonPropertyName("aribSourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings? AribSourceSettings { get; set; }

    /// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
    [JsonPropertyName("dvbSubSourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings? DvbSubSourceSettings { get; set; }

    /// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
    [JsonPropertyName("embeddedSourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings? EmbeddedSourceSettings { get; set; }

    /// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
    [JsonPropertyName("scte20SourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings? Scte20SourceSettings { get; set; }

    /// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
    [JsonPropertyName("scte27SourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings? Scte27SourceSettings { get; set; }

    /// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
    [JsonPropertyName("teletextSourceSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings? TeletextSourceSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelector
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings? SelectorSettings { get; set; }
}

/// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
{
    /// <summary>The bitrate is specified in bits per second, as in an HLS manifest.</summary>
    [JsonPropertyName("bandwidth")]
    public double? Bandwidth { get; set; }

    /// <summary>Buffer segments.</summary>
    [JsonPropertyName("bufferSegments")]
    public double? BufferSegments { get; set; }

    /// <summary>The number of consecutive times that attempts to read a manifest or segment must fail before the input is considered unavailable.</summary>
    [JsonPropertyName("retries")]
    public double? Retries { get; set; }

    /// <summary>The number of seconds between retries when an attempt to read a manifest or segment fails.</summary>
    [JsonPropertyName("retryInterval")]
    public double? RetryInterval { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("scte35Source")]
    public string? Scte35Source { get; set; }
}

/// <summary>Input settings. See Network Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettings
{
    /// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
    [JsonPropertyName("hlsInputSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings? HlsInputSettings { get; set; }

    /// <summary>Check HTTPS server certificates.</summary>
    [JsonPropertyName("serverValidation")]
    public string? ServerValidation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsVideoSelector
{
    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("colorSpaceUsage")]
    public string? ColorSpaceUsage { get; set; }
}

/// <summary>Settings of an input. See Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachmentsInputSettings
{
    /// <summary>Used to select the audio stream to decode for inputs that have multiple. See Audio Selectors for more details.</summary>
    [JsonPropertyName("audioSelector")]
    public IList<V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsAudioSelector>? AudioSelector { get; set; }

    /// <summary>Used to select the caption input to use for inputs that have multiple available. See Caption Selectors for more details.</summary>
    [JsonPropertyName("captionSelector")]
    public IList<V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsCaptionSelector>? CaptionSelector { get; set; }

    /// <summary>Enable or disable the deblock filter when filtering.</summary>
    [JsonPropertyName("deblockFilter")]
    public string? DeblockFilter { get; set; }

    /// <summary>Enable or disable the denoise filter when filtering.</summary>
    [JsonPropertyName("denoiseFilter")]
    public string? DenoiseFilter { get; set; }

    /// <summary>Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).</summary>
    [JsonPropertyName("filterStrength")]
    public double? FilterStrength { get; set; }

    /// <summary>Turns on the filter for the input.</summary>
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    /// <summary>Input settings. See Network Input Settings for more details.</summary>
    [JsonPropertyName("networkInputSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsNetworkInputSettings? NetworkInputSettings { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public double? Scte35Pid { get; set; }

    /// <summary>Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in the input.</summary>
    [JsonPropertyName("smpte2038DataPreference")]
    public string? Smpte2038DataPreference { get; set; }

    /// <summary>Loop input if it is a file.</summary>
    [JsonPropertyName("sourceEndBehavior")]
    public string? SourceEndBehavior { get; set; }

    [JsonPropertyName("videoSelector")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettingsVideoSelector? VideoSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputAttachments
{
    /// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
    [JsonPropertyName("automaticInputFailoverSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettings { get; set; }

    /// <summary>User-specified name for the attachment.</summary>
    [JsonPropertyName("inputAttachmentName")]
    public string? InputAttachmentName { get; set; }

    /// <summary>The ID of the input.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Reference to a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdRef")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdRef? InputIdRef { get; set; }

    /// <summary>Selector for a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdSelector")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputIdSelector? InputIdSelector { get; set; }

    /// <summary>Settings of an input. See Input Settings for more details.</summary>
    [JsonPropertyName("inputSettings")]
    public V1beta2ChannelSpecForProviderInputAttachmentsInputSettings? InputSettings { get; set; }
}

/// <summary>Specification of network and file inputs for the channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderInputSpecification
{
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("inputResolution")]
    public string? InputResolution { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("maximumBitrate")]
    public string? MaximumBitrate { get; set; }
}

/// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderMaintenance
{
    /// <summary>The day of the week to use for maintenance.</summary>
    [JsonPropertyName("maintenanceDay")]
    public string? MaintenanceDay { get; set; }

    /// <summary>The hour maintenance will start.</summary>
    [JsonPropertyName("maintenanceStartTime")]
    public string? MaintenanceStartTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecForProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ChannelSpecForProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecForProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecForProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ChannelSpecForProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecForProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecForProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ChannelSpecForProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecForProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecForProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderRoleArnSelector
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
    public V1beta2ChannelSpecForProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProviderVpc
{
    /// <summary>List of public address allocation ids to associate with ENIs that will be created in Output VPC. Must specify one for SINGLE_PIPELINE, two for STANDARD channels.</summary>
    [JsonPropertyName("publicAddressAllocationIds")]
    public IList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none are specified then the VPC default security group will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two unique availability zones (AZ).</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecForProvider
{
    /// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
    [JsonPropertyName("cdiInputSpecification")]
    public V1beta2ChannelSpecForProviderCdiInputSpecification? CdiInputSpecification { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("channelClass")]
    public string? ChannelClass { get; set; }

    /// <summary>Destinations for channel. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta2ChannelSpecForProviderDestinations>? Destinations { get; set; }

    /// <summary>Encoder settings. See Encoder Settings for more details.</summary>
    [JsonPropertyName("encoderSettings")]
    public V1beta2ChannelSpecForProviderEncoderSettings? EncoderSettings { get; set; }

    /// <summary>Input attachments for the channel. See Input Attachments for more details.</summary>
    [JsonPropertyName("inputAttachments")]
    public IList<V1beta2ChannelSpecForProviderInputAttachments>? InputAttachments { get; set; }

    /// <summary>Specification of network and file inputs for the channel.</summary>
    [JsonPropertyName("inputSpecification")]
    public V1beta2ChannelSpecForProviderInputSpecification? InputSpecification { get; set; }

    /// <summary>The log level to write to Cloudwatch logs.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
    [JsonPropertyName("maintenance")]
    public V1beta2ChannelSpecForProviderMaintenance? Maintenance { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ChannelSpecForProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ChannelSpecForProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Whether to start/stop channel. Default: false</summary>
    [JsonPropertyName("startChannel")]
    public bool? StartChannel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public V1beta2ChannelSpecForProviderVpc? Vpc { get; set; }
}

/// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderCdiInputSpecification
{
    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderDestinationsMediaPackageSettings
{
    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }
}

/// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderDestinationsMultiplexSettings
{
    /// <summary>The ID of the Multiplex that the encoder is providing output to.</summary>
    [JsonPropertyName("multiplexId")]
    public string? MultiplexId { get; set; }

    /// <summary>The program name of the Multiplex program that the encoder is providing output to.</summary>
    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderDestinationsSettings
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }

    /// <summary>A URL specifying a destination.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderDestinations
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Destination settings for a MediaPackage output; one destination for both encoders. See Media Package Settings for more details.</summary>
    [JsonPropertyName("mediaPackageSettings")]
    public IList<V1beta2ChannelSpecInitProviderDestinationsMediaPackageSettings>? MediaPackageSettings { get; set; }

    /// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
    [JsonPropertyName("multiplexSettings")]
    public V1beta2ChannelSpecInitProviderDestinationsMultiplexSettings? MultiplexSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta2ChannelSpecInitProviderDestinationsSettings>? Settings { get; set; }
}

/// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings
{
    /// <summary>Audio normalization algorithm to use. itu17701 conforms to the CALM Act specification, itu17702 to the EBU R-128 specification.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Algorithm control for the audio description.</summary>
    [JsonPropertyName("algorithmControl")]
    public string? AlgorithmControl { get; set; }

    /// <summary>Target LKFS (loudness) to adjust volume to.</summary>
    [JsonPropertyName("targetLkfs")]
    public double? TargetLkfs { get; set; }
}

/// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
{
    [JsonPropertyName("cbetCheckDigitString")]
    public string? CbetCheckDigitString { get; set; }

    /// <summary>Determines the method of CBET insertion mode when prior encoding is detected on the same layer.</summary>
    [JsonPropertyName("cbetStepaside")]
    public string? CbetStepaside { get; set; }

    /// <summary>CBET source ID to use in the watermark.</summary>
    [JsonPropertyName("csid")]
    public string? Csid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings
{
    [JsonPropertyName("checkDigitString")]
    public string? CheckDigitString { get; set; }

    /// <summary>The Nielsen Source ID to include in the watermark.</summary>
    [JsonPropertyName("sid")]
    public double? Sid { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings
{
    /// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
    [JsonPropertyName("nielsenCbetSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings? NielsenCbetSettings { get; set; }

    /// <summary>Distribution types to assign to the watermarks. Options are PROGRAM_CONTENT and FINAL_DISTRIBUTOR.</summary>
    [JsonPropertyName("nielsenDistributionType")]
    public string? NielsenDistributionType { get; set; }

    /// <summary>Used to insert watermarks of type Nielsen NAES, II (N2) and Nielsen NAES VI (NW). See Nielsen NAES II NW Settings for more details.</summary>
    [JsonPropertyName("nielsenNaesIiNwSettings")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings>? NielsenNaesIiNwSettings { get; set; }
}

/// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("nielsenWatermarksSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings? NielsenWatermarksSettings { get; set; }
}

/// <summary>Aac Settings. See AAC Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Set to &quot;broadcasterMixedAd&quot; when input contains pre-mixed main audio + AD (narration) as a stereo pair.</summary>
    [JsonPropertyName("inputType")]
    public string? InputType { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets LATM/LOAS AAC output for raw containers.</summary>
    [JsonPropertyName("rawFormat")]
    public string? RawFormat { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }

    /// <summary>Use MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.</summary>
    [JsonPropertyName("spec")]
    public string? Spec { get; set; }

    /// <summary>VBR Quality Level - Only used if rateControlMode is VBR.</summary>
    [JsonPropertyName("vbrQuality")]
    public string? VbrQuality { get; set; }
}

/// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined in the Dolby Digital specification.</summary>
    [JsonPropertyName("drcProfile")]
    public string? DrcProfile { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }
}

/// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary>Height dimensional trim.</summary>
    [JsonPropertyName("heightTrim")]
    public double? HeightTrim { get; set; }

    /// <summary>Surround dimensional trim.</summary>
    [JsonPropertyName("surroundTrim")]
    public double? SurroundTrim { get; set; }
}

/// <summary>- Eac3 Settings. See EAC3 Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
{
    /// <summary>Sets the attenuation control.</summary>
    [JsonPropertyName("attenuationControl")]
    public string? AttenuationControl { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    [JsonPropertyName("dcFilter")]
    public string? DcFilter { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    [JsonPropertyName("lfeControl")]
    public string? LfeControl { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoCenterMixLevel")]
    public double? LoRoCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoSurroundMixLevel")]
    public double? LoRoSurroundMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtCenterMixLevel")]
    public double? LtRtCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtSurroundMixLevel")]
    public double? LtRtSurroundMixLevel { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }

    [JsonPropertyName("passthroughControl")]
    public string? PassthroughControl { get; set; }

    [JsonPropertyName("phaseControl")]
    public string? PhaseControl { get; set; }

    [JsonPropertyName("stereoDownmix")]
    public string? StereoDownmix { get; set; }

    [JsonPropertyName("surroundExMode")]
    public string? SurroundExMode { get; set; }

    [JsonPropertyName("surroundMode")]
    public string? SurroundMode { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings
{
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings
{
    [JsonPropertyName("bitDepth")]
    public double? BitDepth { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettings
{
    /// <summary>Aac Settings. See AAC Settings for more details.</summary>
    [JsonPropertyName("aacSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings? AacSettings { get; set; }

    /// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
    [JsonPropertyName("ac3Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings? Ac3Settings { get; set; }

    /// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
    [JsonPropertyName("eac3AtmosSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings? Eac3AtmosSettings { get; set; }

    /// <summary>- Eac3 Settings. See EAC3 Settings</summary>
    [JsonPropertyName("eac3Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings? Eac3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("mp2Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings? Mp2Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("passThroughSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings? PassThroughSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("wavSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings? WavSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
{
    [JsonPropertyName("gain")]
    public double? Gain { get; set; }

    [JsonPropertyName("inputChannel")]
    public double? InputChannel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
{
    [JsonPropertyName("inputChannelLevels")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels>? InputChannelLevels { get; set; }

    [JsonPropertyName("outputChannel")]
    public double? OutputChannel { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettings
{
    [JsonPropertyName("channelMappings")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings>? ChannelMappings { get; set; }

    [JsonPropertyName("channelsIn")]
    public double? ChannelsIn { get; set; }

    [JsonPropertyName("channelsOut")]
    public double? ChannelsOut { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptions
{
    /// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
    [JsonPropertyName("audioNormalizationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings? AudioNormalizationSettings { get; set; }

    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn&apos;t create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC 13818-1.</summary>
    [JsonPropertyName("audioType")]
    public string? AudioType { get; set; }

    /// <summary>Determined how audio type is determined.</summary>
    [JsonPropertyName("audioTypeControl")]
    public string? AudioTypeControl { get; set; }

    /// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
    [JsonPropertyName("audioWatermarkSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings? AudioWatermarkSettings { get; set; }

    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsCodecSettings? CodecSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("languageCodeControl")]
    public string? LanguageCodeControl { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("remixSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptionsRemixSettings? RemixSettings { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAvailBlankingAvailBlankingImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsAvailBlanking
{
    /// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
    [JsonPropertyName("availBlankingImage")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAvailBlankingAvailBlankingImage? AvailBlankingImage { get; set; }

    /// <summary>When set to enabled, causes video, audio and captions to be blanked when insertion metadata is added.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ARIB Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings
{
}

/// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
{
    /// <summary>If no explicit xPosition or yPosition is provided, setting alignment to centered will place the captions at the bottom center of the output. Similarly, setting a left alignment will align captions to the bottom left of the output. If x and y positions are given in conjunction with the alignment parameter, the font will be justified (either left or centered) relative to those coordinates. Selecting “smart” justification will left-justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont? Font { get; set; }

    /// <summary>Specifies the color of the burned-in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>Font resolution in DPI (dots per inch); default is 96 dpi. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>When set to ‘auto’ fontSize will scale depending on the size of the output. Giving a positive integer will specify the exact font size in points. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>Specifies font outline color. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>Specifies font outline size in pixels. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>Specifies the horizontal offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>Specifies the vertical offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Controls whether a fixed grid size will be used to generate the output subtitles bitmap. Only applicable for Teletext inputs and DVB-Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>Specifies the horizontal position of the caption relative to the left side of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the left of the output. If no explicit xPosition is provided, the horizontal caption position will be determined by the alignment parameter. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>Specifies the vertical position of the caption relative to the top of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit yPosition is provided, the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings
{
    /// <summary>If no explicit xPosition or yPosition is provided, setting alignment to centered will place the captions at the bottom center of the output. Similarly, setting a left alignment will align captions to the bottom left of the output. If x and y positions are given in conjunction with the alignment parameter, the font will be justified (either left or centered) relative to those coordinates. Selecting “smart” justification will left-justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont? Font { get; set; }

    /// <summary>Specifies the color of the burned-in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>Font resolution in DPI (dots per inch); default is 96 dpi. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>When set to ‘auto’ fontSize will scale depending on the size of the output. Giving a positive integer will specify the exact font size in points. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>Specifies font outline color. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>Specifies font outline size in pixels. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>Specifies the horizontal offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>Specifies the vertical offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Controls whether a fixed grid size will be used to generate the output subtitles bitmap. Only applicable for Teletext inputs and DVB-Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>Specifies the horizontal position of the caption relative to the left side of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the left of the output. If no explicit xPosition is provided, the horizontal caption position will be determined by the alignment parameter. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>Specifies the vertical position of the caption relative to the top of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit yPosition is provided, the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
{
    /// <summary>Complete this field if you want to include the name of the copyright holder in the copyright tag in the captions metadata.</summary>
    [JsonPropertyName("copyrightHolder")]
    public string? CopyrightHolder { get; set; }

    /// <summary>Specifies how to handle the gap between the lines (in multi-line captions). - enabled: Fill with the captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.</summary>
    [JsonPropertyName("fillLineGap")]
    public string? FillLineGap { get; set; }

    /// <summary>Specifies the font family to include in the font data attached to the EBU-TT captions. Valid only if styleControl is set to include. If you leave this field empty, the font family is set to “monospaced”. (If styleControl is set to exclude, the font family is always set to “monospaced”.) You specify only the font family. All other style information (color, bold, position and so on) is copied from the input captions. The size is always set to 100% to allow the downstream player to choose the size. - Enter a list of font families, as a comma-separated list of font names, in order of preference. The name can be a font family (such as “Arial”), or a generic font family (such as “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the family to “monospace”.</summary>
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>Embedded Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings
{
}

/// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings
{
}

/// <summary>RTMP Caption Info Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings
{
}

/// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings
{
}

/// <summary>SCTE27 Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings
{
}

/// <summary>SMPTE TT Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings
{
}

/// <summary>Teletext Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings
{
}

/// <summary>TTML Destination Settings. See TTML Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
{
    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
{
    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettings
{
    /// <summary>ARIB Destination Settings.</summary>
    [JsonPropertyName("aribDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings? AribDestinationSettings { get; set; }

    /// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
    [JsonPropertyName("burnInDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings? BurnInDestinationSettings { get; set; }

    /// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
    [JsonPropertyName("dvbSubDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings? DvbSubDestinationSettings { get; set; }

    /// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
    [JsonPropertyName("ebuTtDDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings? EbuTtDDestinationSettings { get; set; }

    /// <summary>Embedded Destination Settings.</summary>
    [JsonPropertyName("embeddedDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings? EmbeddedDestinationSettings { get; set; }

    /// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
    [JsonPropertyName("embeddedPlusScte20DestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings? EmbeddedPlusScte20DestinationSettings { get; set; }

    /// <summary>RTMP Caption Info Destination Settings.</summary>
    [JsonPropertyName("rtmpCaptionInfoDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings? RtmpCaptionInfoDestinationSettings { get; set; }

    /// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
    [JsonPropertyName("scte20PlusEmbeddedDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings? Scte20PlusEmbeddedDestinationSettings { get; set; }

    /// <summary>SCTE27 Destination Settings.</summary>
    [JsonPropertyName("scte27DestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings? Scte27DestinationSettings { get; set; }

    /// <summary>SMPTE TT Destination Settings.</summary>
    [JsonPropertyName("smpteTtDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings? SmpteTtDestinationSettings { get; set; }

    /// <summary>Teletext Destination Settings.</summary>
    [JsonPropertyName("teletextDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings? TeletextDestinationSettings { get; set; }

    /// <summary>TTML Destination Settings. See TTML Destination Settings for more details.</summary>
    [JsonPropertyName("ttmlDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings? TtmlDestinationSettings { get; set; }

    /// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
    [JsonPropertyName("webvttDestinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings? WebvttDestinationSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptions
{
    /// <summary>Indicates whether the caption track implements accessibility features such as written descriptions of spoken dialog, music, and sounds.</summary>
    [JsonPropertyName("accessibility")]
    public string? Accessibility { get; set; }

    /// <summary>Specifies which input caption selector to use as a caption source when generating output captions. This field should match a captionSelector name.</summary>
    [JsonPropertyName("captionSelectorName")]
    public string? CaptionSelectorName { get; set; }

    /// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
    [JsonPropertyName("destinationSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptionsDestinationSettings? DestinationSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehavior
{
    [JsonPropertyName("blackFrameMsec")]
    public double? BlackFrameMsec { get; set; }

    [JsonPropertyName("inputLossImageColor")]
    public string? InputLossImageColor { get; set; }

    [JsonPropertyName("inputLossImageSlate")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlate { get; set; }

    [JsonPropertyName("inputLossImageType")]
    public string? InputLossImageType { get; set; }

    [JsonPropertyName("repeatFrameMsec")]
    public double? RepeatFrameMsec { get; set; }
}

/// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsGlobalConfiguration
{
    /// <summary>Value to set the initial audio gain for the Live Event.</summary>
    [JsonPropertyName("initialAudioGain")]
    public double? InitialAudioGain { get; set; }

    /// <summary>Indicates the action to take when the current input completes (e.g. end-of-file). When switchAndLoopInputs is configured the encoder will restart at the beginning of the first input. When “none” is configured the encoder will transcode either black, a solid color, or a user specified slate images per the “Input Loss Behavior” configuration until the next input switch occurs (which is controlled through the Channel Schedule API).</summary>
    [JsonPropertyName("inputEndAction")]
    public string? InputEndAction { get; set; }

    /// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
    [JsonPropertyName("inputLossBehavior")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsGlobalConfigurationInputLossBehavior? InputLossBehavior { get; set; }

    /// <summary>Indicates how MediaLive pipelines are synchronized. PIPELINE_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the Unix epoch.</summary>
    [JsonPropertyName("outputLockingMode")]
    public string? OutputLockingMode { get; set; }

    /// <summary>Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock (which optionally may be locked to another source via NTP) or should be locked to the clock of the source that is providing the input stream.</summary>
    [JsonPropertyName("outputTimingSource")]
    public string? OutputTimingSource { get; set; }

    /// <summary>Adjusts video input buffer for streams with very low video framerates. This is commonly set to enabled for music channels with less than one video frame per second.</summary>
    [JsonPropertyName("supportLowFramerateInputs")]
    public string? SupportLowFramerateInputs { get; set; }
}

/// <summary>Html Motion Graphics Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings
{
}

/// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
{
    /// <summary>Html Motion Graphics Settings.</summary>
    [JsonPropertyName("htmlMotionGraphicsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings? HtmlMotionGraphicsSettings { get; set; }
}

/// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfiguration
{
    /// <summary>Motion Graphics Insertion.</summary>
    [JsonPropertyName("motionGraphicsInsertion")]
    public string? MotionGraphicsInsertion { get; set; }

    /// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
    [JsonPropertyName("motionGraphicsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings? MotionGraphicsSettings { get; set; }
}

/// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsNielsenConfiguration
{
    /// <summary>Enter the Distributor ID assigned to your organization by Nielsen.</summary>
    [JsonPropertyName("distributorId")]
    public string? DistributorId { get; set; }

    /// <summary>Enables Nielsen PCM to ID3 tagging.</summary>
    [JsonPropertyName("nielsenPcmToId3Tagging")]
    public string? NielsenPcmToId3Tagging { get; set; }
}

/// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings
{
    /// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
    [JsonPropertyName("archiveS3Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings? ArchiveS3Settings { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings
{
    /// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
    [JsonPropertyName("archiveCdnSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings? ArchiveCdnSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination? Destination { get; set; }

    /// <summary>Number of seconds to write to archive file before closing and starting a new one.</summary>
    [JsonPropertyName("rolloverInterval")]
    public double? RolloverInterval { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureS3Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings? FrameCaptureS3Settings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination? Destination { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureCdnSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings? FrameCaptureCdnSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings
{
    [JsonPropertyName("captionChannel")]
    public double? CaptionChannel { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    [JsonPropertyName("salt")]
    public string? Salt { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("mediaStoreStorageClass")]
    public string? MediaStoreStorageClass { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsAkamaiSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings? HlsAkamaiSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsBasicPutSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings? HlsBasicPutSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsMediaStoreSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings? HlsMediaStoreSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsS3Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings? HlsS3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsWebdavSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings? HlsWebdavSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings
{
    [JsonPropertyName("keyProviderServer")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer? KeyProviderServer { get; set; }

    [JsonPropertyName("staticKeyValue")]
    public string? StaticKeyValue { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("staticKeySettings")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings>? StaticKeySettings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    [JsonPropertyName("baseUrlContent")]
    public string? BaseUrlContent { get; set; }

    [JsonPropertyName("baseUrlContent1")]
    public string? BaseUrlContent1 { get; set; }

    [JsonPropertyName("baseUrlManifest")]
    public string? BaseUrlManifest { get; set; }

    [JsonPropertyName("baseUrlManifest1")]
    public string? BaseUrlManifest1 { get; set; }

    [JsonPropertyName("captionLanguageMappings")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings>? CaptionLanguageMappings { get; set; }

    [JsonPropertyName("captionLanguageSetting")]
    public string? CaptionLanguageSetting { get; set; }

    [JsonPropertyName("clientCache")]
    public string? ClientCache { get; set; }

    [JsonPropertyName("codecSpecification")]
    public string? CodecSpecification { get; set; }

    [JsonPropertyName("constantIv")]
    public string? ConstantIv { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination? Destination { get; set; }

    [JsonPropertyName("directoryStructure")]
    public string? DirectoryStructure { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("discontinuityTags")]
    public string? DiscontinuityTags { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsCdnSettings")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings>? HlsCdnSettings { get; set; }

    [JsonPropertyName("hlsId3SegmentTagging")]
    public string? HlsId3SegmentTagging { get; set; }

    [JsonPropertyName("iframeOnlyPlaylists")]
    public string? IframeOnlyPlaylists { get; set; }

    [JsonPropertyName("incompleteSegmentBehavior")]
    public string? IncompleteSegmentBehavior { get; set; }

    [JsonPropertyName("indexNSegments")]
    public double? IndexNSegments { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    [JsonPropertyName("ivInManifest")]
    public string? IvInManifest { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("ivSource")]
    public string? IvSource { get; set; }

    [JsonPropertyName("keepSegments")]
    public double? KeepSegments { get; set; }

    [JsonPropertyName("keyFormat")]
    public string? KeyFormat { get; set; }

    [JsonPropertyName("keyFormatVersions")]
    public string? KeyFormatVersions { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("keyProviderSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings? KeyProviderSettings { get; set; }

    [JsonPropertyName("manifestCompression")]
    public string? ManifestCompression { get; set; }

    [JsonPropertyName("manifestDurationFormat")]
    public string? ManifestDurationFormat { get; set; }

    [JsonPropertyName("minSegmentLength")]
    public double? MinSegmentLength { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("outputSelection")]
    public string? OutputSelection { get; set; }

    [JsonPropertyName("programDateTime")]
    public string? ProgramDateTime { get; set; }

    [JsonPropertyName("programDateTimeClock")]
    public string? ProgramDateTimeClock { get; set; }

    [JsonPropertyName("programDateTimePeriod")]
    public double? ProgramDateTimePeriod { get; set; }

    [JsonPropertyName("redundantManifest")]
    public string? RedundantManifest { get; set; }

    [JsonPropertyName("segmentLength")]
    public double? SegmentLength { get; set; }

    [JsonPropertyName("segmentsPerSubdirectory")]
    public double? SegmentsPerSubdirectory { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("streamInfResolution")]
    public string? StreamInfResolution { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }

    [JsonPropertyName("timestampDeltaMilliseconds")]
    public double? TimestampDeltaMilliseconds { get; set; }

    [JsonPropertyName("tsFileMode")]
    public string? TsFileMode { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination? Destination { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("acquisitionPointId")]
    public string? AcquisitionPointId { get; set; }

    [JsonPropertyName("audioOnlyTimecodeControl")]
    public string? AudioOnlyTimecodeControl { get; set; }

    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination? Destination { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    [JsonPropertyName("eventIdMode")]
    public string? EventIdMode { get; set; }

    [JsonPropertyName("eventStopBehavior")]
    public string? EventStopBehavior { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("fragmentLength")]
    public double? FragmentLength { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    [JsonPropertyName("segmentationMode")]
    public string? SegmentationMode { get; set; }

    [JsonPropertyName("sendDelayMs")]
    public double? SendDelayMs { get; set; }

    [JsonPropertyName("sparseTrackType")]
    public string? SparseTrackType { get; set; }

    [JsonPropertyName("streamManifestBehavior")]
    public string? StreamManifestBehavior { get; set; }

    [JsonPropertyName("timestampOffset")]
    public string? TimestampOffset { get; set; }

    [JsonPropertyName("timestampOffsetMode")]
    public string? TimestampOffsetMode { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings
{
}

/// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary>Authentication scheme to use when connecting with CDN.</summary>
    [JsonPropertyName("authenticationScheme")]
    public string? AuthenticationScheme { get; set; }

    /// <summary>Controls behavior when content cache fills up.</summary>
    [JsonPropertyName("cacheFullBehavior")]
    public string? CacheFullBehavior { get; set; }

    /// <summary>Cache length in seconds, is used to calculate buffer size.</summary>
    [JsonPropertyName("cacheLength")]
    public double? CacheLength { get; set; }

    /// <summary>Controls the types of data that passes to onCaptionInfo outputs.</summary>
    [JsonPropertyName("captionData")]
    public string? CaptionData { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings
{
    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }
}

/// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettings
{
    /// <summary>Archive group settings. See Archive Group Settings for more details.</summary>
    [JsonPropertyName("archiveGroupSettings")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings>? ArchiveGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings? FrameCaptureGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings? HlsGroupSettings { get; set; }

    /// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
    [JsonPropertyName("mediaPackageGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? MediaPackageGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("msSmoothGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? MsSmoothGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("multiplexGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings? MultiplexGroupSettings { get; set; }

    /// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
    [JsonPropertyName("rtmpGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings? RtmpGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("udpGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings? UdpGroupSettings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings
{
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings? DvbSdtSettings { get; set; }

    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Raw Settings. This can be set as an empty block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings
{
}

/// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings? M2tsSettings { get; set; }

    /// <summary>Raw Settings. This can be set as an empty block.</summary>
    [JsonPropertyName("rawSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings? RawSettings { get; set; }
}

/// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings
{
    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings? ContainerSettings { get; set; }

    /// <summary>Output file extension.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings
{
    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("audioGroupId")]
    public string? AudioGroupId { get; set; }

    [JsonPropertyName("audioOnlyImage")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage? AudioOnlyImage { get; set; }

    [JsonPropertyName("audioTrackType")]
    public string? AudioTrackType { get; set; }

    [JsonPropertyName("segmentType")]
    public string? SegmentType { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
{
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings
{
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings
{
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("scte35Behavior")]
    public string? Scte35Behavior { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings
{
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("m3u8Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings? M3u8Settings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("audioOnlyHlsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings? AudioOnlyHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("fmp4HlsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings? Fmp4HlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureHlsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings? FrameCaptureHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("standardHlsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings? StandardHlsSettings { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings
{
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings? HlsSettings { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }

    [JsonPropertyName("segmentModifier")]
    public string? SegmentModifier { get; set; }
}

/// <summary>Media package output settings. This can be set as an empty block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings
{
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
{
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination? Destination { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings
{
    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination? Destination { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings
{
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings? DvbSdtSettings { get; set; }

    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings? M2tsSettings { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
{
    /// <summary>The height of the FEC protection matrix.</summary>
    [JsonPropertyName("columnDepth")]
    public double? ColumnDepth { get; set; }

    /// <summary>Enables column only or column and row based FEC.</summary>
    [JsonPropertyName("includeFec")]
    public string? IncludeFec { get; set; }

    /// <summary>The width of the FEC protection matrix.</summary>
    [JsonPropertyName("rowLength")]
    public double? RowLength { get; set; }
}

/// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings
{
    /// <summary>UDP output buffering in milliseconds.</summary>
    [JsonPropertyName("bufferMsec")]
    public double? BufferMsec { get; set; }

    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings? ContainerSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination? Destination { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("fecOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings? FecOutputSettings { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettings
{
    /// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
    [JsonPropertyName("archiveOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings? ArchiveOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("frameCaptureOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings? FrameCaptureOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("hlsOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings? HlsOutputSettings { get; set; }

    /// <summary>Media package output settings. This can be set as an empty block.</summary>
    [JsonPropertyName("mediaPackageOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings? MediaPackageOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("msSmoothOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings? MsSmoothOutputSettings { get; set; }

    /// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
    [JsonPropertyName("multiplexOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings? MultiplexOutputSettings { get; set; }

    /// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
    [JsonPropertyName("rtmpOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings? RtmpOutputSettings { get; set; }

    /// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
    [JsonPropertyName("udpOutputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings? UdpOutputSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputs
{
    /// <summary>The names of the audio descriptions used as audio sources for the output.</summary>
    [JsonPropertyName("audioDescriptionNames")]
    public IList<string>? AudioDescriptionNames { get; set; }

    /// <summary>The names of the caption descriptions used as caption sources for the output.</summary>
    [JsonPropertyName("captionDescriptionNames")]
    public IList<string>? CaptionDescriptionNames { get; set; }

    /// <summary>The name used to identify an output.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("outputSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputsOutputSettings? OutputSettings { get; set; }

    /// <summary>The name of the video description used as video source for the output.</summary>
    [JsonPropertyName("videoDescriptionName")]
    public string? VideoDescriptionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroups
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
    [JsonPropertyName("outputGroupSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputGroupSettings? OutputGroupSettings { get; set; }

    /// <summary>List of outputs. See Outputs for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroupsOutputs>? Outputs { get; set; }
}

/// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsTimecodeConfig
{
    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Threshold in frames beyond which output timecode is resynchronized to the input timecode.</summary>
    [JsonPropertyName("syncThreshold")]
    public double? SyncThreshold { get; set; }
}

/// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
{
    /// <summary>The frequency at which to capture frames for inclusion in the output.</summary>
    [JsonPropertyName("captureInterval")]
    public double? CaptureInterval { get; set; }

    /// <summary>Unit for the frame capture interval.</summary>
    [JsonPropertyName("captureIntervalUnits")]
    public string? CaptureIntervalUnits { get; set; }
}

/// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings? TemporalFilterSettings { get; set; }
}

/// <summary>H264 settings. See H264 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufFillPct")]
    public double? BufFillPct { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Entropy encoding mode.</summary>
    [JsonPropertyName("entropyEncoding")]
    public string? EntropyEncoding { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Controls whether coding is performed on a field basis or on a frame basis.</summary>
    [JsonPropertyName("forceFieldPictures")]
    public string? ForceFieldPictures { get; set; }

    /// <summary>Indicates how the output video frame rate is specified.</summary>
    [JsonPropertyName("framerateControl")]
    public string? FramerateControl { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>GOP-B reference.</summary>
    [JsonPropertyName("gopBReference")]
    public string? GopBReference { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>Number of B-frames between reference frames.</summary>
    [JsonPropertyName("gopNumBFrames")]
    public double? GopNumBFrames { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>Min interval.</summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Number of reference frames to use.</summary>
    [JsonPropertyName("numRefFrames")]
    public double? NumRefFrames { get; set; }

    /// <summary>Indicates how the output pixel aspect ratio is specified.</summary>
    [JsonPropertyName("parControl")]
    public string? ParControl { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Quality level.</summary>
    [JsonPropertyName("qualityLevel")]
    public string? QualityLevel { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Softness.</summary>
    [JsonPropertyName("softness")]
    public double? Softness { get; set; }

    /// <summary>Makes adjustments within each frame based on spatial variation of content complexity.</summary>
    [JsonPropertyName("spatialAq")]
    public string? SpatialAq { get; set; }

    /// <summary>Subgop length.</summary>
    [JsonPropertyName("subgopLength")]
    public string? SubgopLength { get; set; }

    /// <summary>Produces a bitstream compliant with SMPTE RP-2027.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }

    /// <summary>Makes adjustments within each frame based on temporal variation of content complexity.</summary>
    [JsonPropertyName("temporalAq")]
    public string? TemporalAq { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary>Sets the colorspace metadata to be passed through.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings
{
}

/// <summary>Set the colorspace to Dolby Vision81.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings
{
}

/// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
{
    /// <summary>Sets the MaxCLL value for HDR10.</summary>
    [JsonPropertyName("maxCll")]
    public double? MaxCll { get; set; }

    /// <summary>Sets the MaxFALL value for HDR10.</summary>
    [JsonPropertyName("maxFall")]
    public double? MaxFall { get; set; }
}

/// <summary>Set the colorspace to Rec. 601.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings
{
}

/// <summary>Set the colorspace to Rec. 709.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings
{
}

/// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings
{
    /// <summary>Sets the colorspace metadata to be passed through.</summary>
    [JsonPropertyName("colorSpacePassthroughSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings? ColorSpacePassthroughSettings { get; set; }

    /// <summary>Set the colorspace to Dolby Vision81.</summary>
    [JsonPropertyName("dolbyVision81Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings? DolbyVision81Settings { get; set; }

    /// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
    [JsonPropertyName("hdr10Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings? Hdr10Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 601.</summary>
    [JsonPropertyName("rec601Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings? Rec601Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 709.</summary>
    [JsonPropertyName("rec709Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings? Rec709Settings { get; set; }
}

/// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings? TemporalFilterSettings { get; set; }
}

/// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings
{
    /// <summary>Set a prefix on the burned in timecode.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Sets the size of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninFontSize")]
    public string? TimecodeBurninFontSize { get; set; }

    /// <summary>Sets the position of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninPosition")]
    public string? TimecodeBurninPosition { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Whether or not EML should insert an Alternative Transfer Function SEI message.</summary>
    [JsonPropertyName("alternativeTransferFunction")]
    public string? AlternativeTransferFunction { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
    [JsonPropertyName("colorSpaceSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings? ColorSpaceSettings { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>Min interval.</summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Set the minimum QP.</summary>
    [JsonPropertyName("minQp")]
    public double? MinQp { get; set; }

    /// <summary>Enables or disables motion vector over picture boundaries.</summary>
    [JsonPropertyName("mvOverPictureBoundaries")]
    public string? MvOverPictureBoundaries { get; set; }

    /// <summary>Enables or disables the motion vector temporal predictor.</summary>
    [JsonPropertyName("mvTemporalPredictor")]
    public string? MvTemporalPredictor { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Set the H265 tier in the output.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Sets the height of tiles.</summary>
    [JsonPropertyName("tileHeight")]
    public double? TileHeight { get; set; }

    /// <summary>Enables or disables padding of tiles.</summary>
    [JsonPropertyName("tilePadding")]
    public string? TilePadding { get; set; }

    /// <summary>Sets the width of tiles.</summary>
    [JsonPropertyName("tileWidth")]
    public double? TileWidth { get; set; }

    /// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
    [JsonPropertyName("timecodeBurninSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings? TimecodeBurninSettings { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }

    /// <summary>Sets the size of the treeblock.</summary>
    [JsonPropertyName("treeblockSize")]
    public string? TreeblockSize { get; set; }
}

/// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettings
{
    /// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
    [JsonPropertyName("frameCaptureSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings? FrameCaptureSettings { get; set; }

    /// <summary>H264 settings. See H264 Settings for more details.</summary>
    [JsonPropertyName("h264Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings? H264Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("h265Settings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings? H265Settings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptions
{
    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptionsCodecSettings? CodecSettings { get; set; }

    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, &quot;80&quot; means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicate how to respond to the AFD values that might be in the input video.</summary>
    [JsonPropertyName("respondToAfd")]
    public string? RespondToAfd { get; set; }

    /// <summary>Behavior on how to scale.</summary>
    [JsonPropertyName("scalingBehavior")]
    public string? ScalingBehavior { get; set; }

    /// <summary>Changes the strength of the anti-alias filter used for scaling.</summary>
    [JsonPropertyName("sharpness")]
    public double? Sharpness { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, &quot;80&quot; means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Encoder settings. See Encoder Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderEncoderSettings
{
    /// <summary>Audio descriptions for the channel. See Audio Descriptions for more details.</summary>
    [JsonPropertyName("audioDescriptions")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsAudioDescriptions>? AudioDescriptions { get; set; }

    /// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
    [JsonPropertyName("availBlanking")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsAvailBlanking? AvailBlanking { get; set; }

    /// <summary>Caption Descriptions. See Caption Descriptions for more details.</summary>
    [JsonPropertyName("captionDescriptions")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsCaptionDescriptions>? CaptionDescriptions { get; set; }

    /// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
    [JsonPropertyName("motionGraphicsConfiguration")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsMotionGraphicsConfiguration? MotionGraphicsConfiguration { get; set; }

    /// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
    [JsonPropertyName("nielsenConfiguration")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsNielsenConfiguration? NielsenConfiguration { get; set; }

    /// <summary>Output groups for the channel. See Output Groups for more details.</summary>
    [JsonPropertyName("outputGroups")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsOutputGroups>? OutputGroups { get; set; }

    /// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
    [JsonPropertyName("timecodeConfig")]
    public V1beta2ChannelSpecInitProviderEncoderSettingsTimecodeConfig? TimecodeConfig { get; set; }

    /// <summary>Video Descriptions. See Video Descriptions for more details.</summary>
    [JsonPropertyName("videoDescriptions")]
    public IList<V1beta2ChannelSpecInitProviderEncoderSettingsVideoDescriptions>? VideoDescriptions { get; set; }
}

/// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
{
    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn&apos;t create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be silent before automatic input failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.</summary>
    [JsonPropertyName("audioSilenceThresholdMsec")]
    public double? AudioSilenceThresholdMsec { get; set; }
}

/// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
{
    /// <summary>The amount of time (in milliseconds) that no input is detected. After that time, an input failover will occur.</summary>
    [JsonPropertyName("inputLossThresholdMsec")]
    public double? InputLossThresholdMsec { get; set; }
}

/// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
{
    /// <summary>A value used in calculating the threshold below which MediaLive considers a pixel to be &apos;black&apos;. For the input to be considered black, every pixel in a frame must be below this threshold. The threshold is calculated as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.1 in 10-bit color depth: (10230.1=102.3), which means a pixel value of 102 or less is &apos;black&apos;. If you set this field to .1 in an 8-bit color depth: (2550.1=25.5), which means a pixel value of 25 or less is &apos;black&apos;. The range is 0.0 to 1.0, with any number of decimal places.</summary>
    [JsonPropertyName("blackDetectThreshold")]
    public double? BlackDetectThreshold { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be black before automatic input failover occurs.</summary>
    [JsonPropertyName("videoBlackThresholdMsec")]
    public double? VideoBlackThresholdMsec { get; set; }
}

/// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
{
    /// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
    [JsonPropertyName("audioSilenceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings? AudioSilenceSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
    [JsonPropertyName("inputLossSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings? InputLossSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
    [JsonPropertyName("videoBlackSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings? VideoBlackSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
{
    /// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
    [JsonPropertyName("failoverConditionSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings? FailoverConditionSettings { get; set; }
}

/// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettings
{
    /// <summary>This clear time defines the requirement a recovered input must meet to be considered healthy. The input must have no failover conditions for this length of time. Enter a time in milliseconds. This value is particularly important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.</summary>
    [JsonPropertyName("errorClearTimeMsec")]
    public double? ErrorClearTimeMsec { get; set; }

    /// <summary>A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover to the other input. See Failover Condition Block for more details.</summary>
    [JsonPropertyName("failoverCondition")]
    public IList<V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition>? FailoverCondition { get; set; }

    /// <summary>Input preference when deciding which input to make active when a previously failed input has recovered.</summary>
    [JsonPropertyName("inputPreference")]
    public string? InputPreference { get; set; }

    /// <summary>The input ID of the secondary input in the automatic input failover pair.</summary>
    [JsonPropertyName("secondaryInputId")]
    public string? SecondaryInputId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicyResolveEnum>))]
public enum V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicyResolveEnum>))]
public enum V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Input in medialive to populate inputId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelector
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
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>When set to “strict”, the transport stream demux strictly identifies audio streams by their language descriptor. If a PMT update occurs such that an audio stream matching the initially selected language is no longer present then mute will be encoded until the language returns. If “loose”, then on a PMT update the demux will choose another audio stream in the program with the same stream type if it can’t find one with the same language.</summary>
    [JsonPropertyName("languageSelectionPolicy")]
    public string? LanguageSelectionPolicy { get; set; }
}

/// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
{
    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode
{
    /// <summary>Applies only to Dolby E. Enter the program ID (according to the metadata in the audio) of the Dolby E program to extract from the specified track. One program extracted per audio selector. To select multiple programs, create multiple selectors with the same Track and different Program numbers. “All channels” means to ignore the program IDs and include all the channels in this selector; useful if metadata is known to be incorrect.</summary>
    [JsonPropertyName("programSelection")]
    public string? ProgramSelection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks
{
    /// <summary>1-based integer value that maps to a specific audio track.</summary>
    [JsonPropertyName("track")]
    public double? Track { get; set; }
}

/// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection
{
    /// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
    [JsonPropertyName("dolbyEDecode")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode? DolbyEDecode { get; set; }

    /// <summary>Selects one or more unique audio tracks from within a source. See Audio Tracks for more details.</summary>
    [JsonPropertyName("tracks")]
    public IList<V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks>? Tracks { get; set; }
}

/// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings
{
    /// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
    [JsonPropertyName("audioHlsRenditionSelection")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection? AudioHlsRenditionSelection { get; set; }

    /// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
    [JsonPropertyName("audioLanguageSelection")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection? AudioLanguageSelection { get; set; }

    /// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
    [JsonPropertyName("audioPidSelection")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection? AudioPidSelection { get; set; }

    /// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
    [JsonPropertyName("audioTrackSelection")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection? AudioTrackSelection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelector
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings? SelectorSettings { get; set; }
}

/// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
{
    /// <summary>Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary captions. If you plan to convert the ancillary captions to another format, complete this field. If you plan to choose Embedded as the captions destination in the output (to pass through all the channels in the ancillary captions), leave this field blank because MediaLive ignores the field.</summary>
    [JsonPropertyName("sourceAncillaryChannelNumber")]
    public double? SourceAncillaryChannelNumber { get; set; }
}

/// <summary>ARIB Source Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings
{
}

/// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Set to “auto” to handle streams with intermittent and/or non-aligned SCTE-20 and Embedded captions.</summary>
    [JsonPropertyName("scte20Detection")]
    public string? Scte20Detection { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
{
    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, &quot;80&quot; means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you don’t have either of these formats in the output.) You can define a display rectangle for the captions that is smaller than the underlying video frame. You define the rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the rectangle, all within the underlying video frame. The units for the measurements are percentages. If you specify a value for one of these fields, you must specify a value for all of them. For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the underlying frame width, and relative to the left edge of the frame. For example, &quot;10&quot; means the measurement is 10% of the underlying frame width. The rectangle left edge starts at that position from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.</summary>
    [JsonPropertyName("leftOffset")]
    public double? LeftOffset { get; set; }

    /// <summary>See the description in left_offset. For top_offset, specify the position of the top edge of the rectangle, as a percentage of the underlying frame height, and relative to the top edge of the frame. For example, &quot;10&quot; means the measurement is 10% of the underlying frame height. The rectangle top edge starts at that position from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.</summary>
    [JsonPropertyName("topOffset")]
    public double? TopOffset { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, &quot;80&quot; means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
{
    /// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
    [JsonPropertyName("outputRectangle")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle? OutputRectangle { get; set; }

    /// <summary>Specifies the teletext page number within the data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303). Unused for passthrough. Should be specified as a hexadecimal string with no “0x” prefix.</summary>
    [JsonPropertyName("pageNumber")]
    public string? PageNumber { get; set; }
}

/// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings
{
    /// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
    [JsonPropertyName("ancillarySourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings? AncillarySourceSettings { get; set; }

    /// <summary>ARIB Source Settings.</summary>
    [JsonPropertyName("aribSourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings? AribSourceSettings { get; set; }

    /// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
    [JsonPropertyName("dvbSubSourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings? DvbSubSourceSettings { get; set; }

    /// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
    [JsonPropertyName("embeddedSourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings? EmbeddedSourceSettings { get; set; }

    /// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
    [JsonPropertyName("scte20SourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings? Scte20SourceSettings { get; set; }

    /// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
    [JsonPropertyName("scte27SourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings? Scte27SourceSettings { get; set; }

    /// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
    [JsonPropertyName("teletextSourceSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings? TeletextSourceSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelector
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings? SelectorSettings { get; set; }
}

/// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
{
    /// <summary>The bitrate is specified in bits per second, as in an HLS manifest.</summary>
    [JsonPropertyName("bandwidth")]
    public double? Bandwidth { get; set; }

    /// <summary>Buffer segments.</summary>
    [JsonPropertyName("bufferSegments")]
    public double? BufferSegments { get; set; }

    /// <summary>The number of consecutive times that attempts to read a manifest or segment must fail before the input is considered unavailable.</summary>
    [JsonPropertyName("retries")]
    public double? Retries { get; set; }

    /// <summary>The number of seconds between retries when an attempt to read a manifest or segment fails.</summary>
    [JsonPropertyName("retryInterval")]
    public double? RetryInterval { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("scte35Source")]
    public string? Scte35Source { get; set; }
}

/// <summary>Input settings. See Network Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettings
{
    /// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
    [JsonPropertyName("hlsInputSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings? HlsInputSettings { get; set; }

    /// <summary>Check HTTPS server certificates.</summary>
    [JsonPropertyName("serverValidation")]
    public string? ServerValidation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsVideoSelector
{
    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("colorSpaceUsage")]
    public string? ColorSpaceUsage { get; set; }
}

/// <summary>Settings of an input. See Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachmentsInputSettings
{
    /// <summary>Used to select the audio stream to decode for inputs that have multiple. See Audio Selectors for more details.</summary>
    [JsonPropertyName("audioSelector")]
    public IList<V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsAudioSelector>? AudioSelector { get; set; }

    /// <summary>Used to select the caption input to use for inputs that have multiple available. See Caption Selectors for more details.</summary>
    [JsonPropertyName("captionSelector")]
    public IList<V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsCaptionSelector>? CaptionSelector { get; set; }

    /// <summary>Enable or disable the deblock filter when filtering.</summary>
    [JsonPropertyName("deblockFilter")]
    public string? DeblockFilter { get; set; }

    /// <summary>Enable or disable the denoise filter when filtering.</summary>
    [JsonPropertyName("denoiseFilter")]
    public string? DenoiseFilter { get; set; }

    /// <summary>Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).</summary>
    [JsonPropertyName("filterStrength")]
    public double? FilterStrength { get; set; }

    /// <summary>Turns on the filter for the input.</summary>
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    /// <summary>Input settings. See Network Input Settings for more details.</summary>
    [JsonPropertyName("networkInputSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsNetworkInputSettings? NetworkInputSettings { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public double? Scte35Pid { get; set; }

    /// <summary>Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in the input.</summary>
    [JsonPropertyName("smpte2038DataPreference")]
    public string? Smpte2038DataPreference { get; set; }

    /// <summary>Loop input if it is a file.</summary>
    [JsonPropertyName("sourceEndBehavior")]
    public string? SourceEndBehavior { get; set; }

    [JsonPropertyName("videoSelector")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettingsVideoSelector? VideoSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputAttachments
{
    /// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
    [JsonPropertyName("automaticInputFailoverSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettings { get; set; }

    /// <summary>User-specified name for the attachment.</summary>
    [JsonPropertyName("inputAttachmentName")]
    public string? InputAttachmentName { get; set; }

    /// <summary>The ID of the input.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Reference to a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdRef")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdRef? InputIdRef { get; set; }

    /// <summary>Selector for a Input in medialive to populate inputId.</summary>
    [JsonPropertyName("inputIdSelector")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputIdSelector? InputIdSelector { get; set; }

    /// <summary>Settings of an input. See Input Settings for more details.</summary>
    [JsonPropertyName("inputSettings")]
    public V1beta2ChannelSpecInitProviderInputAttachmentsInputSettings? InputSettings { get; set; }
}

/// <summary>Specification of network and file inputs for the channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderInputSpecification
{
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("inputResolution")]
    public string? InputResolution { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("maximumBitrate")]
    public string? MaximumBitrate { get; set; }
}

/// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderMaintenance
{
    /// <summary>The day of the week to use for maintenance.</summary>
    [JsonPropertyName("maintenanceDay")]
    public string? MaintenanceDay { get; set; }

    /// <summary>The hour maintenance will start.</summary>
    [JsonPropertyName("maintenanceStartTime")]
    public string? MaintenanceStartTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecInitProviderRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ChannelSpecInitProviderRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecInitProviderRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecInitProviderRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ChannelSpecInitProviderRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecInitProviderRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecInitProviderRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ChannelSpecInitProviderRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecInitProviderRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecInitProviderRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderRoleArnSelector
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
    public V1beta2ChannelSpecInitProviderRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecInitProviderVpc
{
    /// <summary>List of public address allocation ids to associate with ENIs that will be created in Output VPC. Must specify one for SINGLE_PIPELINE, two for STANDARD channels.</summary>
    [JsonPropertyName("publicAddressAllocationIds")]
    public IList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none are specified then the VPC default security group will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two unique availability zones (AZ).</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
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
public partial class V1beta2ChannelSpecInitProvider
{
    /// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
    [JsonPropertyName("cdiInputSpecification")]
    public V1beta2ChannelSpecInitProviderCdiInputSpecification? CdiInputSpecification { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("channelClass")]
    public string? ChannelClass { get; set; }

    /// <summary>Destinations for channel. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta2ChannelSpecInitProviderDestinations>? Destinations { get; set; }

    /// <summary>Encoder settings. See Encoder Settings for more details.</summary>
    [JsonPropertyName("encoderSettings")]
    public V1beta2ChannelSpecInitProviderEncoderSettings? EncoderSettings { get; set; }

    /// <summary>Input attachments for the channel. See Input Attachments for more details.</summary>
    [JsonPropertyName("inputAttachments")]
    public IList<V1beta2ChannelSpecInitProviderInputAttachments>? InputAttachments { get; set; }

    /// <summary>Specification of network and file inputs for the channel.</summary>
    [JsonPropertyName("inputSpecification")]
    public V1beta2ChannelSpecInitProviderInputSpecification? InputSpecification { get; set; }

    /// <summary>The log level to write to Cloudwatch logs.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
    [JsonPropertyName("maintenance")]
    public V1beta2ChannelSpecInitProviderMaintenance? Maintenance { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ChannelSpecInitProviderRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ChannelSpecInitProviderRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Whether to start/stop channel. Default: false</summary>
    [JsonPropertyName("startChannel")]
    public bool? StartChannel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public V1beta2ChannelSpecInitProviderVpc? Vpc { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecManagementPoliciesEnum>))]
public enum V1beta2ChannelSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ChannelSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ChannelSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ChannelSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ChannelSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ChannelSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ChannelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ChannelSpec defines the desired state of Channel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelSpec
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
    public V1beta2ChannelSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ChannelSpecForProvider ForProvider { get; set; }

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
    public V1beta2ChannelSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ChannelSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ChannelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ChannelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderCdiInputSpecification
{
    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("resolution")]
    public string? Resolution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderDestinationsMediaPackageSettings
{
    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }
}

/// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderDestinationsMultiplexSettings
{
    /// <summary>The ID of the Multiplex that the encoder is providing output to.</summary>
    [JsonPropertyName("multiplexId")]
    public string? MultiplexId { get; set; }

    /// <summary>The program name of the Multiplex program that the encoder is providing output to.</summary>
    [JsonPropertyName("programName")]
    public string? ProgramName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderDestinationsSettings
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }

    /// <summary>A URL specifying a destination.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderDestinations
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Destination settings for a MediaPackage output; one destination for both encoders. See Media Package Settings for more details.</summary>
    [JsonPropertyName("mediaPackageSettings")]
    public IList<V1beta2ChannelStatusAtProviderDestinationsMediaPackageSettings>? MediaPackageSettings { get; set; }

    /// <summary>Destination settings for a Multiplex output; one destination for both encoders. See Multiplex Settings for more details.</summary>
    [JsonPropertyName("multiplexSettings")]
    public V1beta2ChannelStatusAtProviderDestinationsMultiplexSettings? MultiplexSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("settings")]
    public IList<V1beta2ChannelStatusAtProviderDestinationsSettings>? Settings { get; set; }
}

/// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings
{
    /// <summary>Audio normalization algorithm to use. itu17701 conforms to the CALM Act specification, itu17702 to the EBU R-128 specification.</summary>
    [JsonPropertyName("algorithm")]
    public string? Algorithm { get; set; }

    /// <summary>Algorithm control for the audio description.</summary>
    [JsonPropertyName("algorithmControl")]
    public string? AlgorithmControl { get; set; }

    /// <summary>Target LKFS (loudness) to adjust volume to.</summary>
    [JsonPropertyName("targetLkfs")]
    public double? TargetLkfs { get; set; }
}

/// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings
{
    [JsonPropertyName("cbetCheckDigitString")]
    public string? CbetCheckDigitString { get; set; }

    /// <summary>Determines the method of CBET insertion mode when prior encoding is detected on the same layer.</summary>
    [JsonPropertyName("cbetStepaside")]
    public string? CbetStepaside { get; set; }

    /// <summary>CBET source ID to use in the watermark.</summary>
    [JsonPropertyName("csid")]
    public string? Csid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings
{
    [JsonPropertyName("checkDigitString")]
    public string? CheckDigitString { get; set; }

    /// <summary>The Nielsen Source ID to include in the watermark.</summary>
    [JsonPropertyName("sid")]
    public double? Sid { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings
{
    /// <summary>Used to insert watermarks of type Nielsen CBET. See Nielsen CBET Settings for more details.</summary>
    [JsonPropertyName("nielsenCbetSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenCbetSettings? NielsenCbetSettings { get; set; }

    /// <summary>Distribution types to assign to the watermarks. Options are PROGRAM_CONTENT and FINAL_DISTRIBUTOR.</summary>
    [JsonPropertyName("nielsenDistributionType")]
    public string? NielsenDistributionType { get; set; }

    /// <summary>Used to insert watermarks of type Nielsen NAES, II (N2) and Nielsen NAES VI (NW). See Nielsen NAES II NW Settings for more details.</summary>
    [JsonPropertyName("nielsenNaesIiNwSettings")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettingsNielsenNaesIiNwSettings>? NielsenNaesIiNwSettings { get; set; }
}

/// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("nielsenWatermarksSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettingsNielsenWatermarksSettings? NielsenWatermarksSettings { get; set; }
}

/// <summary>Aac Settings. See AAC Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Set to &quot;broadcasterMixedAd&quot; when input contains pre-mixed main audio + AD (narration) as a stereo pair.</summary>
    [JsonPropertyName("inputType")]
    public string? InputType { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets LATM/LOAS AAC output for raw containers.</summary>
    [JsonPropertyName("rawFormat")]
    public string? RawFormat { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }

    /// <summary>Use MPEG-2 AAC audio instead of MPEG-4 AAC audio for raw or MPEG-2 Transport Stream containers.</summary>
    [JsonPropertyName("spec")]
    public string? Spec { get; set; }

    /// <summary>VBR Quality Level - Only used if rateControlMode is VBR.</summary>
    [JsonPropertyName("vbrQuality")]
    public string? VbrQuality { get; set; }
}

/// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>If set to filmStandard, adds dynamic range compression signaling to the output bitstream as defined in the Dolby Digital specification.</summary>
    [JsonPropertyName("drcProfile")]
    public string? DrcProfile { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }
}

/// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    /// <summary>Height dimensional trim.</summary>
    [JsonPropertyName("heightTrim")]
    public double? HeightTrim { get; set; }

    /// <summary>Surround dimensional trim.</summary>
    [JsonPropertyName("surroundTrim")]
    public double? SurroundTrim { get; set; }
}

/// <summary>- Eac3 Settings. See EAC3 Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings
{
    /// <summary>Sets the attenuation control.</summary>
    [JsonPropertyName("attenuationControl")]
    public string? AttenuationControl { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Specifies the bitstream mode (bsmod) for the emitted AC-3 stream.</summary>
    [JsonPropertyName("bitstreamMode")]
    public string? BitstreamMode { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    [JsonPropertyName("dcFilter")]
    public string? DcFilter { get; set; }

    /// <summary>Sets the dialnorm of the output.</summary>
    [JsonPropertyName("dialnorm")]
    public double? Dialnorm { get; set; }

    /// <summary>Sets the Dolby dynamic range compression profile.</summary>
    [JsonPropertyName("drcLine")]
    public string? DrcLine { get; set; }

    /// <summary>Sets the profile for heavy Dolby dynamic range compression.</summary>
    [JsonPropertyName("drcRf")]
    public string? DrcRf { get; set; }

    [JsonPropertyName("lfeControl")]
    public string? LfeControl { get; set; }

    /// <summary>When set to enabled, applies a 120Hz lowpass filter to the LFE channel prior to encoding.</summary>
    [JsonPropertyName("lfeFilter")]
    public string? LfeFilter { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoCenterMixLevel")]
    public double? LoRoCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("loRoSurroundMixLevel")]
    public double? LoRoSurroundMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtCenterMixLevel")]
    public double? LtRtCenterMixLevel { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("ltRtSurroundMixLevel")]
    public double? LtRtSurroundMixLevel { get; set; }

    /// <summary>Metadata control.</summary>
    [JsonPropertyName("metadataControl")]
    public string? MetadataControl { get; set; }

    [JsonPropertyName("passthroughControl")]
    public string? PassthroughControl { get; set; }

    [JsonPropertyName("phaseControl")]
    public string? PhaseControl { get; set; }

    [JsonPropertyName("stereoDownmix")]
    public string? StereoDownmix { get; set; }

    [JsonPropertyName("surroundExMode")]
    public string? SurroundExMode { get; set; }

    [JsonPropertyName("surroundMode")]
    public string? SurroundMode { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings
{
    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings
{
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings
{
    [JsonPropertyName("bitDepth")]
    public double? BitDepth { get; set; }

    /// <summary>Mono, Stereo, or 5.1 channel layout.</summary>
    [JsonPropertyName("codingMode")]
    public string? CodingMode { get; set; }

    /// <summary>Sample rate in Hz.</summary>
    [JsonPropertyName("sampleRate")]
    public double? SampleRate { get; set; }
}

/// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettings
{
    /// <summary>Aac Settings. See AAC Settings for more details.</summary>
    [JsonPropertyName("aacSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAacSettings? AacSettings { get; set; }

    /// <summary>Ac3 Settings. See AC3 Settings for more details.</summary>
    [JsonPropertyName("ac3Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsAc3Settings? Ac3Settings { get; set; }

    /// <summary>- Eac3 Atmos Settings. See EAC3 Atmos Settings</summary>
    [JsonPropertyName("eac3AtmosSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3AtmosSettings? Eac3AtmosSettings { get; set; }

    /// <summary>- Eac3 Settings. See EAC3 Settings</summary>
    [JsonPropertyName("eac3Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsEac3Settings? Eac3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("mp2Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsMp2Settings? Mp2Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("passThroughSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsPassThroughSettings? PassThroughSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("wavSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettingsWavSettings? WavSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels
{
    [JsonPropertyName("gain")]
    public double? Gain { get; set; }

    [JsonPropertyName("inputChannel")]
    public double? InputChannel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings
{
    [JsonPropertyName("inputChannelLevels")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappingsInputChannelLevels>? InputChannelLevels { get; set; }

    [JsonPropertyName("outputChannel")]
    public double? OutputChannel { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettings
{
    [JsonPropertyName("channelMappings")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettingsChannelMappings>? ChannelMappings { get; set; }

    [JsonPropertyName("channelsIn")]
    public double? ChannelsIn { get; set; }

    [JsonPropertyName("channelsOut")]
    public double? ChannelsOut { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptions
{
    /// <summary>Advanced audio normalization settings. See Audio Normalization Settings for more details.</summary>
    [JsonPropertyName("audioNormalizationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioNormalizationSettings? AudioNormalizationSettings { get; set; }

    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn&apos;t create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>Applies only if audioTypeControl is useConfigured. The values for audioType are defined in ISO-IEC 13818-1.</summary>
    [JsonPropertyName("audioType")]
    public string? AudioType { get; set; }

    /// <summary>Determined how audio type is determined.</summary>
    [JsonPropertyName("audioTypeControl")]
    public string? AudioTypeControl { get; set; }

    /// <summary>Settings to configure one or more solutions that insert audio watermarks in the audio encode. See Audio Watermark Settings for more details.</summary>
    [JsonPropertyName("audioWatermarkSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsAudioWatermarkSettings? AudioWatermarkSettings { get; set; }

    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsCodecSettings? CodecSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("languageCodeControl")]
    public string? LanguageCodeControl { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("remixSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptionsRemixSettings? RemixSettings { get; set; }

    /// <summary>Stream name RTMP destinations (URLs of type rtmp://)</summary>
    [JsonPropertyName("streamName")]
    public string? StreamName { get; set; }
}

/// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAvailBlankingAvailBlankingImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsAvailBlanking
{
    /// <summary>Blanking image to be used. See Avail Blanking Image for more details.</summary>
    [JsonPropertyName("availBlankingImage")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAvailBlankingAvailBlankingImage? AvailBlankingImage { get; set; }

    /// <summary>When set to enabled, causes video, audio and captions to be blanked when insertion metadata is added.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>ARIB Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings
{
}

/// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings
{
    /// <summary>If no explicit xPosition or yPosition is provided, setting alignment to centered will place the captions at the bottom center of the output. Similarly, setting a left alignment will align captions to the bottom left of the output. If x and y positions are given in conjunction with the alignment parameter, the font will be justified (either left or centered) relative to those coordinates. Selecting “smart” justification will left-justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettingsFont? Font { get; set; }

    /// <summary>Specifies the color of the burned-in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>Font resolution in DPI (dots per inch); default is 96 dpi. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>When set to ‘auto’ fontSize will scale depending on the size of the output. Giving a positive integer will specify the exact font size in points. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>Specifies font outline color. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>Specifies font outline size in pixels. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>Specifies the horizontal offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>Specifies the vertical offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Controls whether a fixed grid size will be used to generate the output subtitles bitmap. Only applicable for Teletext inputs and DVB-Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>Specifies the horizontal position of the caption relative to the left side of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the left of the output. If no explicit xPosition is provided, the horizontal caption position will be determined by the alignment parameter. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>Specifies the vertical position of the caption relative to the top of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit yPosition is provided, the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings
{
    /// <summary>If no explicit xPosition or yPosition is provided, setting alignment to centered will place the captions at the bottom center of the output. Similarly, setting a left alignment will align captions to the bottom left of the output. If x and y positions are given in conjunction with the alignment parameter, the font will be justified (either left or centered) relative to those coordinates. Selecting “smart” justification will left-justify live subtitles and center-justify pre-recorded subtitles. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("alignment")]
    public string? Alignment { get; set; }

    /// <summary>Specifies the color of the rectangle behind the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundColor")]
    public string? BackgroundColor { get; set; }

    /// <summary>Specifies the opacity of the background rectangle. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("backgroundOpacity")]
    public double? BackgroundOpacity { get; set; }

    /// <summary>External font file used for caption burn-in. File extension must be ‘ttf’ or ‘tte’. Although the user can select output fonts for many different types of input captions, embedded, STL and teletext sources use a strict grid system. Using external fonts with these caption sources could cause unexpected display of proportional fonts. All burn-in and DVB-Sub font settings must match. See Font for more details.</summary>
    [JsonPropertyName("font")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettingsFont? Font { get; set; }

    /// <summary>Specifies the color of the burned-in captions. This option is not valid for source captions that are STL, 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontColor")]
    public string? FontColor { get; set; }

    /// <summary>Specifies the opacity of the burned-in captions. 255 is opaque; 0 is transparent. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontOpacity")]
    public double? FontOpacity { get; set; }

    /// <summary>Font resolution in DPI (dots per inch); default is 96 dpi. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontResolution")]
    public double? FontResolution { get; set; }

    /// <summary>When set to ‘auto’ fontSize will scale depending on the size of the output. Giving a positive integer will specify the exact font size in points. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("fontSize")]
    public string? FontSize { get; set; }

    /// <summary>Specifies font outline color. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineColor")]
    public string? OutlineColor { get; set; }

    /// <summary>Specifies font outline size in pixels. This option is not valid for source captions that are either 608/embedded or teletext. These source settings are already pre-defined by the caption stream. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("outlineSize")]
    public double? OutlineSize { get; set; }

    /// <summary>Specifies the color of the shadow cast by the captions. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowColor")]
    public string? ShadowColor { get; set; }

    /// <summary>Specifies the opacity of the shadow. 255 is opaque; 0 is transparent. Leaving this parameter out is equivalent to setting it to 0 (transparent). All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowOpacity")]
    public double? ShadowOpacity { get; set; }

    /// <summary>Specifies the horizontal offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels to the left. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowXOffset")]
    public double? ShadowXOffset { get; set; }

    /// <summary>Specifies the vertical offset of the shadow relative to the captions in pixels. A value of -2 would result in a shadow offset 2 pixels above the text. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("shadowYOffset")]
    public double? ShadowYOffset { get; set; }

    /// <summary>Controls whether a fixed grid size will be used to generate the output subtitles bitmap. Only applicable for Teletext inputs and DVB-Sub/Burn-in outputs.</summary>
    [JsonPropertyName("teletextGridControl")]
    public string? TeletextGridControl { get; set; }

    /// <summary>Specifies the horizontal position of the caption relative to the left side of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the left of the output. If no explicit xPosition is provided, the horizontal caption position will be determined by the alignment parameter. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("xPosition")]
    public double? XPosition { get; set; }

    /// <summary>Specifies the vertical position of the caption relative to the top of the output in pixels. A value of 10 would result in the captions starting 10 pixels from the top of the output. If no explicit yPosition is provided, the caption will be positioned towards the bottom of the output. All burn-in and DVB-Sub font settings must match.</summary>
    [JsonPropertyName("yPosition")]
    public double? YPosition { get; set; }
}

/// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings
{
    /// <summary>Complete this field if you want to include the name of the copyright holder in the copyright tag in the captions metadata.</summary>
    [JsonPropertyName("copyrightHolder")]
    public string? CopyrightHolder { get; set; }

    /// <summary>Specifies how to handle the gap between the lines (in multi-line captions). - enabled: Fill with the captions background color (as specified in the input captions). - disabled: Leave the gap unfilled.</summary>
    [JsonPropertyName("fillLineGap")]
    public string? FillLineGap { get; set; }

    /// <summary>Specifies the font family to include in the font data attached to the EBU-TT captions. Valid only if styleControl is set to include. If you leave this field empty, the font family is set to “monospaced”. (If styleControl is set to exclude, the font family is always set to “monospaced”.) You specify only the font family. All other style information (color, bold, position and so on) is copied from the input captions. The size is always set to 100% to allow the downstream player to choose the size. - Enter a list of font families, as a comma-separated list of font names, in order of preference. The name can be a font family (such as “Arial”), or a generic font family (such as “serif”), or “default” (to let the downstream player choose the font). - Leave blank to set the family to “monospace”.</summary>
    [JsonPropertyName("fontFamily")]
    public string? FontFamily { get; set; }

    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>Embedded Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings
{
}

/// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings
{
}

/// <summary>RTMP Caption Info Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings
{
}

/// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings
{
}

/// <summary>SCTE27 Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings
{
}

/// <summary>SMPTE TT Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings
{
}

/// <summary>Teletext Destination Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings
{
}

/// <summary>TTML Destination Settings. See TTML Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings
{
    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings
{
    /// <summary>Specifies the style information (font color, font position, and so on) to include in the font data that is attached to the EBU-TT captions. - include: Take the style information (font color, font position, and so on) from the source captions and include that information in the font data attached to the EBU-TT captions. This option is valid only if the source captions are Embedded or Teletext. - exclude: In the font data attached to the EBU-TT captions, set the font family to “monospaced”. Do not include any other style information.</summary>
    [JsonPropertyName("styleControl")]
    public string? StyleControl { get; set; }
}

/// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettings
{
    /// <summary>ARIB Destination Settings.</summary>
    [JsonPropertyName("aribDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsAribDestinationSettings? AribDestinationSettings { get; set; }

    /// <summary>Burn In Destination Settings. See Burn In Destination Settings for more details.</summary>
    [JsonPropertyName("burnInDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsBurnInDestinationSettings? BurnInDestinationSettings { get; set; }

    /// <summary>DVB Sub Destination Settings. See DVB Sub Destination Settings for more details.</summary>
    [JsonPropertyName("dvbSubDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsDvbSubDestinationSettings? DvbSubDestinationSettings { get; set; }

    /// <summary>EBU TT D Destination Settings. See EBU TT D Destination Settings for more details.</summary>
    [JsonPropertyName("ebuTtDDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEbuTtDDestinationSettings? EbuTtDDestinationSettings { get; set; }

    /// <summary>Embedded Destination Settings.</summary>
    [JsonPropertyName("embeddedDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedDestinationSettings? EmbeddedDestinationSettings { get; set; }

    /// <summary>Embedded Plus SCTE20 Destination Settings.</summary>
    [JsonPropertyName("embeddedPlusScte20DestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsEmbeddedPlusScte20DestinationSettings? EmbeddedPlusScte20DestinationSettings { get; set; }

    /// <summary>RTMP Caption Info Destination Settings.</summary>
    [JsonPropertyName("rtmpCaptionInfoDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsRtmpCaptionInfoDestinationSettings? RtmpCaptionInfoDestinationSettings { get; set; }

    /// <summary>SCTE20 Plus Embedded Destination Settings.</summary>
    [JsonPropertyName("scte20PlusEmbeddedDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte20PlusEmbeddedDestinationSettings? Scte20PlusEmbeddedDestinationSettings { get; set; }

    /// <summary>SCTE27 Destination Settings.</summary>
    [JsonPropertyName("scte27DestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsScte27DestinationSettings? Scte27DestinationSettings { get; set; }

    /// <summary>SMPTE TT Destination Settings.</summary>
    [JsonPropertyName("smpteTtDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsSmpteTtDestinationSettings? SmpteTtDestinationSettings { get; set; }

    /// <summary>Teletext Destination Settings.</summary>
    [JsonPropertyName("teletextDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTeletextDestinationSettings? TeletextDestinationSettings { get; set; }

    /// <summary>TTML Destination Settings. See TTML Destination Settings for more details.</summary>
    [JsonPropertyName("ttmlDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsTtmlDestinationSettings? TtmlDestinationSettings { get; set; }

    /// <summary>WebVTT Destination Settings. See WebVTT Destination Settings for more details.</summary>
    [JsonPropertyName("webvttDestinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettingsWebvttDestinationSettings? WebvttDestinationSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptions
{
    /// <summary>Indicates whether the caption track implements accessibility features such as written descriptions of spoken dialog, music, and sounds.</summary>
    [JsonPropertyName("accessibility")]
    public string? Accessibility { get; set; }

    /// <summary>Specifies which input caption selector to use as a caption source when generating output captions. This field should match a captionSelector name.</summary>
    [JsonPropertyName("captionSelectorName")]
    public string? CaptionSelectorName { get; set; }

    /// <summary>Additional settings for captions destination that depend on the destination type. See Destination Settings for more details.</summary>
    [JsonPropertyName("destinationSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptionsDestinationSettings? DestinationSettings { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehavior
{
    [JsonPropertyName("blackFrameMsec")]
    public double? BlackFrameMsec { get; set; }

    [JsonPropertyName("inputLossImageColor")]
    public string? InputLossImageColor { get; set; }

    [JsonPropertyName("inputLossImageSlate")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehaviorInputLossImageSlate? InputLossImageSlate { get; set; }

    [JsonPropertyName("inputLossImageType")]
    public string? InputLossImageType { get; set; }

    [JsonPropertyName("repeatFrameMsec")]
    public double? RepeatFrameMsec { get; set; }
}

/// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsGlobalConfiguration
{
    /// <summary>Value to set the initial audio gain for the Live Event.</summary>
    [JsonPropertyName("initialAudioGain")]
    public double? InitialAudioGain { get; set; }

    /// <summary>Indicates the action to take when the current input completes (e.g. end-of-file). When switchAndLoopInputs is configured the encoder will restart at the beginning of the first input. When “none” is configured the encoder will transcode either black, a solid color, or a user specified slate images per the “Input Loss Behavior” configuration until the next input switch occurs (which is controlled through the Channel Schedule API).</summary>
    [JsonPropertyName("inputEndAction")]
    public string? InputEndAction { get; set; }

    /// <summary>Settings for system actions when input is lost. See Input Loss Behavior for more details.</summary>
    [JsonPropertyName("inputLossBehavior")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsGlobalConfigurationInputLossBehavior? InputLossBehavior { get; set; }

    /// <summary>Indicates how MediaLive pipelines are synchronized. PIPELINE_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the other. EPOCH_LOCKING - MediaLive will attempt to synchronize the output of each pipeline to the Unix epoch.</summary>
    [JsonPropertyName("outputLockingMode")]
    public string? OutputLockingMode { get; set; }

    /// <summary>Indicates whether the rate of frames emitted by the Live encoder should be paced by its system clock (which optionally may be locked to another source via NTP) or should be locked to the clock of the source that is providing the input stream.</summary>
    [JsonPropertyName("outputTimingSource")]
    public string? OutputTimingSource { get; set; }

    /// <summary>Adjusts video input buffer for streams with very low video framerates. This is commonly set to enabled for music channels with less than one video frame per second.</summary>
    [JsonPropertyName("supportLowFramerateInputs")]
    public string? SupportLowFramerateInputs { get; set; }
}

/// <summary>Html Motion Graphics Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings
{
}

/// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings
{
    /// <summary>Html Motion Graphics Settings.</summary>
    [JsonPropertyName("htmlMotionGraphicsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettingsHtmlMotionGraphicsSettings? HtmlMotionGraphicsSettings { get; set; }
}

/// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfiguration
{
    /// <summary>Motion Graphics Insertion.</summary>
    [JsonPropertyName("motionGraphicsInsertion")]
    public string? MotionGraphicsInsertion { get; set; }

    /// <summary>–  Motion Graphics Settings. See Motion Graphics Settings for more details.</summary>
    [JsonPropertyName("motionGraphicsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfigurationMotionGraphicsSettings? MotionGraphicsSettings { get; set; }
}

/// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsNielsenConfiguration
{
    /// <summary>Enter the Distributor ID assigned to your organization by Nielsen.</summary>
    [JsonPropertyName("distributorId")]
    public string? DistributorId { get; set; }

    /// <summary>Enables Nielsen PCM to ID3 tagging.</summary>
    [JsonPropertyName("nielsenPcmToId3Tagging")]
    public string? NielsenPcmToId3Tagging { get; set; }
}

/// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings
{
    /// <summary>Archive S3 Settings. See Archive S3 Settings for more details.</summary>
    [JsonPropertyName("archiveS3Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettingsArchiveS3Settings? ArchiveS3Settings { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings
{
    /// <summary>Parameters that control the interactions with the CDN. See Archive CDN Settings for more details.</summary>
    [JsonPropertyName("archiveCdnSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsArchiveCdnSettings? ArchiveCdnSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettingsDestination? Destination { get; set; }

    /// <summary>Number of seconds to write to archive file before closing and starting a new one.</summary>
    [JsonPropertyName("rolloverInterval")]
    public double? RolloverInterval { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureS3Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettingsFrameCaptureS3Settings? FrameCaptureS3Settings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsDestination? Destination { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureCdnSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettingsFrameCaptureCdnSettings? FrameCaptureCdnSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings
{
    [JsonPropertyName("captionChannel")]
    public double? CaptionChannel { get; set; }

    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Human readable information to indicate captions available for players (eg. English, or Spanish).</summary>
    [JsonPropertyName("languageDescription")]
    public string? LanguageDescription { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    [JsonPropertyName("salt")]
    public string? Salt { get; set; }

    [JsonPropertyName("token")]
    public string? Token { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("mediaStoreStorageClass")]
    public string? MediaStoreStorageClass { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings
{
    /// <summary>Specify the canned ACL to apply to each S3 request.</summary>
    [JsonPropertyName("cannedAcl")]
    public string? CannedAcl { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings
{
    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("httpTransferMode")]
    public string? HttpTransferMode { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsAkamaiSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsAkamaiSettings? HlsAkamaiSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsBasicPutSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsBasicPutSettings? HlsBasicPutSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsMediaStoreSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsMediaStoreSettings? HlsMediaStoreSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsS3Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsS3Settings? HlsS3Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsWebdavSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettingsHlsWebdavSettings? HlsWebdavSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings
{
    [JsonPropertyName("keyProviderServer")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettingsKeyProviderServer? KeyProviderServer { get; set; }

    [JsonPropertyName("staticKeyValue")]
    public string? StaticKeyValue { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("staticKeySettings")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettingsStaticKeySettings>? StaticKeySettings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    [JsonPropertyName("baseUrlContent")]
    public string? BaseUrlContent { get; set; }

    [JsonPropertyName("baseUrlContent1")]
    public string? BaseUrlContent1 { get; set; }

    [JsonPropertyName("baseUrlManifest")]
    public string? BaseUrlManifest { get; set; }

    [JsonPropertyName("baseUrlManifest1")]
    public string? BaseUrlManifest1 { get; set; }

    [JsonPropertyName("captionLanguageMappings")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsCaptionLanguageMappings>? CaptionLanguageMappings { get; set; }

    [JsonPropertyName("captionLanguageSetting")]
    public string? CaptionLanguageSetting { get; set; }

    [JsonPropertyName("clientCache")]
    public string? ClientCache { get; set; }

    [JsonPropertyName("codecSpecification")]
    public string? CodecSpecification { get; set; }

    [JsonPropertyName("constantIv")]
    public string? ConstantIv { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsDestination? Destination { get; set; }

    [JsonPropertyName("directoryStructure")]
    public string? DirectoryStructure { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("discontinuityTags")]
    public string? DiscontinuityTags { get; set; }

    [JsonPropertyName("encryptionType")]
    public string? EncryptionType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsCdnSettings")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsHlsCdnSettings>? HlsCdnSettings { get; set; }

    [JsonPropertyName("hlsId3SegmentTagging")]
    public string? HlsId3SegmentTagging { get; set; }

    [JsonPropertyName("iframeOnlyPlaylists")]
    public string? IframeOnlyPlaylists { get; set; }

    [JsonPropertyName("incompleteSegmentBehavior")]
    public string? IncompleteSegmentBehavior { get; set; }

    [JsonPropertyName("indexNSegments")]
    public double? IndexNSegments { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    [JsonPropertyName("ivInManifest")]
    public string? IvInManifest { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("ivSource")]
    public string? IvSource { get; set; }

    [JsonPropertyName("keepSegments")]
    public double? KeepSegments { get; set; }

    [JsonPropertyName("keyFormat")]
    public string? KeyFormat { get; set; }

    [JsonPropertyName("keyFormatVersions")]
    public string? KeyFormatVersions { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("keyProviderSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettingsKeyProviderSettings? KeyProviderSettings { get; set; }

    [JsonPropertyName("manifestCompression")]
    public string? ManifestCompression { get; set; }

    [JsonPropertyName("manifestDurationFormat")]
    public string? ManifestDurationFormat { get; set; }

    [JsonPropertyName("minSegmentLength")]
    public double? MinSegmentLength { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("outputSelection")]
    public string? OutputSelection { get; set; }

    [JsonPropertyName("programDateTime")]
    public string? ProgramDateTime { get; set; }

    [JsonPropertyName("programDateTimeClock")]
    public string? ProgramDateTimeClock { get; set; }

    [JsonPropertyName("programDateTimePeriod")]
    public double? ProgramDateTimePeriod { get; set; }

    [JsonPropertyName("redundantManifest")]
    public string? RedundantManifest { get; set; }

    [JsonPropertyName("segmentLength")]
    public double? SegmentLength { get; set; }

    [JsonPropertyName("segmentsPerSubdirectory")]
    public double? SegmentsPerSubdirectory { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("streamInfResolution")]
    public string? StreamInfResolution { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }

    [JsonPropertyName("timestampDeltaMilliseconds")]
    public double? TimestampDeltaMilliseconds { get; set; }

    [JsonPropertyName("tsFileMode")]
    public string? TsFileMode { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettingsDestination? Destination { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("acquisitionPointId")]
    public string? AcquisitionPointId { get; set; }

    [JsonPropertyName("audioOnlyTimecodeControl")]
    public string? AudioOnlyTimecodeControl { get; set; }

    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettingsDestination? Destination { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    [JsonPropertyName("eventIdMode")]
    public string? EventIdMode { get; set; }

    [JsonPropertyName("eventStopBehavior")]
    public string? EventStopBehavior { get; set; }

    [JsonPropertyName("filecacheDuration")]
    public double? FilecacheDuration { get; set; }

    [JsonPropertyName("fragmentLength")]
    public double? FragmentLength { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }

    [JsonPropertyName("segmentationMode")]
    public string? SegmentationMode { get; set; }

    [JsonPropertyName("sendDelayMs")]
    public double? SendDelayMs { get; set; }

    [JsonPropertyName("sparseTrackType")]
    public string? SparseTrackType { get; set; }

    [JsonPropertyName("streamManifestBehavior")]
    public string? StreamManifestBehavior { get; set; }

    [JsonPropertyName("timestampOffset")]
    public string? TimestampOffset { get; set; }

    [JsonPropertyName("timestampOffsetMode")]
    public string? TimestampOffsetMode { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings
{
}

/// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings
{
    /// <summary>The ad marker type for this output group.</summary>
    [JsonPropertyName("adMarkers")]
    public IList<string>? AdMarkers { get; set; }

    /// <summary>Authentication scheme to use when connecting with CDN.</summary>
    [JsonPropertyName("authenticationScheme")]
    public string? AuthenticationScheme { get; set; }

    /// <summary>Controls behavior when content cache fills up.</summary>
    [JsonPropertyName("cacheFullBehavior")]
    public string? CacheFullBehavior { get; set; }

    /// <summary>Cache length in seconds, is used to calculate buffer size.</summary>
    [JsonPropertyName("cacheLength")]
    public double? CacheLength { get; set; }

    /// <summary>Controls the types of data that passes to onCaptionInfo outputs.</summary>
    [JsonPropertyName("captionData")]
    public string? CaptionData { get; set; }

    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Number of seconds to wait until a restart is initiated.</summary>
    [JsonPropertyName("restartDelay")]
    public double? RestartDelay { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings
{
    /// <summary>Controls the behavior of the RTMP group if input becomes unavailable.</summary>
    [JsonPropertyName("inputLossAction")]
    public string? InputLossAction { get; set; }

    /// <summary>Indicates ID3 frame that has the timecode.</summary>
    [JsonPropertyName("timedMetadataId3Frame")]
    public string? TimedMetadataId3Frame { get; set; }

    [JsonPropertyName("timedMetadataId3Period")]
    public double? TimedMetadataId3Period { get; set; }
}

/// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettings
{
    /// <summary>Archive group settings. See Archive Group Settings for more details.</summary>
    [JsonPropertyName("archiveGroupSettings")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsArchiveGroupSettings>? ArchiveGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsFrameCaptureGroupSettings? FrameCaptureGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsHlsGroupSettings? HlsGroupSettings { get; set; }

    /// <summary>Media package group settings. See Media Package Group Settings for more details.</summary>
    [JsonPropertyName("mediaPackageGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMediaPackageGroupSettings? MediaPackageGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("msSmoothGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMsSmoothGroupSettings? MsSmoothGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("multiplexGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsMultiplexGroupSettings? MultiplexGroupSettings { get; set; }

    /// <summary>RTMP group settings. See RTMP Group Settings for more details.</summary>
    [JsonPropertyName("rtmpGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsRtmpGroupSettings? RtmpGroupSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("udpGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettingsUdpGroupSettings? UdpGroupSettings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings
{
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings? DvbSdtSettings { get; set; }

    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Raw Settings. This can be set as an empty block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings
{
}

/// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsM2tsSettings? M2tsSettings { get; set; }

    /// <summary>Raw Settings. This can be set as an empty block.</summary>
    [JsonPropertyName("rawSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettingsRawSettings? RawSettings { get; set; }
}

/// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings
{
    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettingsContainerSettings? ContainerSettings { get; set; }

    /// <summary>Output file extension.</summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings
{
    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage
{
    /// <summary>Key used to extract the password from EC2 Parameter store.</summary>
    [JsonPropertyName("passwordParam")]
    public string? PasswordParam { get; set; }

    /// <summary>Path to a file accessible to the live stream.</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Username for destination.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("audioGroupId")]
    public string? AudioGroupId { get; set; }

    [JsonPropertyName("audioOnlyImage")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettingsAudioOnlyImage? AudioOnlyImage { get; set; }

    [JsonPropertyName("audioTrackType")]
    public string? AudioTrackType { get; set; }

    [JsonPropertyName("segmentType")]
    public string? SegmentType { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings
{
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings
{
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings
{
    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("scte35Behavior")]
    public string? Scte35Behavior { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings
{
    [JsonPropertyName("audioRenditionSets")]
    public string? AudioRenditionSets { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("m3u8Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettingsM3u8Settings? M3u8Settings { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings
{
    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("audioOnlyHlsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsAudioOnlyHlsSettings? AudioOnlyHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("fmp4HlsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFmp4HlsSettings? Fmp4HlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("frameCaptureHlsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsFrameCaptureHlsSettings? FrameCaptureHlsSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("standardHlsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettingsStandardHlsSettings? StandardHlsSettings { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings
{
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("hlsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettingsHlsSettings? HlsSettings { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }

    [JsonPropertyName("segmentModifier")]
    public string? SegmentModifier { get; set; }
}

/// <summary>Media package output settings. This can be set as an empty block.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings
{
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings
{
    [JsonPropertyName("h265PackagingType")]
    public string? H265PackagingType { get; set; }

    /// <summary>String concatenated to the end of the destination filename. Required for multiple outputs of the same type.</summary>
    [JsonPropertyName("nameModifier")]
    public string? NameModifier { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings
{
    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettingsDestination? Destination { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings
{
    /// <summary>Setting to allow self signed or verified RTMP certificates.</summary>
    [JsonPropertyName("certificateMode")]
    public string? CertificateMode { get; set; }

    /// <summary>Number of seconds to wait before retrying connection to the flash media server if the connection is lost.</summary>
    [JsonPropertyName("connectionRetryInterval")]
    public double? ConnectionRetryInterval { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettingsDestination? Destination { get; set; }

    /// <summary>Number of retry attempts.</summary>
    [JsonPropertyName("numRetries")]
    public double? NumRetries { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings
{
    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("networkId")]
    public double? NetworkId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("networkName")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings
{
    [JsonPropertyName("outputSdt")]
    public string? OutputSdt { get; set; }

    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("serviceProviderName")]
    public string? ServiceProviderName { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings
{
    [JsonPropertyName("repInterval")]
    public double? RepInterval { get; set; }
}

/// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings
{
    [JsonPropertyName("absentInputAudioBehavior")]
    public string? AbsentInputAudioBehavior { get; set; }

    [JsonPropertyName("arib")]
    public string? Arib { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("aribCaptionsPid")]
    public string? AribCaptionsPid { get; set; }

    [JsonPropertyName("aribCaptionsPidControl")]
    public string? AribCaptionsPidControl { get; set; }

    [JsonPropertyName("audioBufferModel")]
    public string? AudioBufferModel { get; set; }

    [JsonPropertyName("audioFramesPerPes")]
    public double? AudioFramesPerPes { get; set; }

    [JsonPropertyName("audioPids")]
    public string? AudioPids { get; set; }

    [JsonPropertyName("audioStreamType")]
    public string? AudioStreamType { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufferModel")]
    public string? BufferModel { get; set; }

    [JsonPropertyName("ccDescriptor")]
    public string? CcDescriptor { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbNitSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbNitSettings? DvbNitSettings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbSdtSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbSdtSettings? DvbSdtSettings { get; set; }

    [JsonPropertyName("dvbSubPids")]
    public string? DvbSubPids { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("dvbTdtSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettingsDvbTdtSettings? DvbTdtSettings { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("dvbTeletextPid")]
    public string? DvbTeletextPid { get; set; }

    [JsonPropertyName("ebif")]
    public string? Ebif { get; set; }

    [JsonPropertyName("ebpAudioInterval")]
    public string? EbpAudioInterval { get; set; }

    [JsonPropertyName("ebpLookaheadMs")]
    public double? EbpLookaheadMs { get; set; }

    [JsonPropertyName("ebpPlacement")]
    public string? EbpPlacement { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("ecmPid")]
    public string? EcmPid { get; set; }

    [JsonPropertyName("esRateInPes")]
    public string? EsRateInPes { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvPlatformPid")]
    public string? EtvPlatformPid { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("etvSignalPid")]
    public string? EtvSignalPid { get; set; }

    [JsonPropertyName("fragmentTime")]
    public double? FragmentTime { get; set; }

    [JsonPropertyName("klv")]
    public string? Klv { get; set; }

    [JsonPropertyName("klvDataPids")]
    public string? KlvDataPids { get; set; }

    [JsonPropertyName("nielsenId3Behavior")]
    public string? NielsenId3Behavior { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("nullPacketBitrate")]
    public double? NullPacketBitrate { get; set; }

    [JsonPropertyName("patInterval")]
    public double? PatInterval { get; set; }

    [JsonPropertyName("pcrControl")]
    public string? PcrControl { get; set; }

    [JsonPropertyName("pcrPeriod")]
    public double? PcrPeriod { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pcrPid")]
    public string? PcrPid { get; set; }

    [JsonPropertyName("pmtInterval")]
    public double? PmtInterval { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pmtPid")]
    public string? PmtPid { get; set; }

    [JsonPropertyName("programNum")]
    public double? ProgramNum { get; set; }

    [JsonPropertyName("rateMode")]
    public string? RateMode { get; set; }

    [JsonPropertyName("scte27Pids")]
    public string? Scte27Pids { get; set; }

    [JsonPropertyName("scte35Control")]
    public string? Scte35Control { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public string? Scte35Pid { get; set; }

    [JsonPropertyName("segmentationMarkers")]
    public string? SegmentationMarkers { get; set; }

    [JsonPropertyName("segmentationStyle")]
    public string? SegmentationStyle { get; set; }

    [JsonPropertyName("segmentationTime")]
    public double? SegmentationTime { get; set; }

    [JsonPropertyName("timedMetadataBehavior")]
    public string? TimedMetadataBehavior { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("timedMetadataPid")]
    public string? TimedMetadataPid { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("transportStreamId")]
    public double? TransportStreamId { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("videoPid")]
    public string? VideoPid { get; set; }
}

/// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings
{
    /// <summary>M2TS Settings. See M2TS Settings for more details.</summary>
    [JsonPropertyName("m2tsSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettingsM2tsSettings? M2tsSettings { get; set; }
}

/// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination
{
    /// <summary>Reference ID for the destination.</summary>
    [JsonPropertyName("destinationRefId")]
    public string? DestinationRefId { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings
{
    /// <summary>The height of the FEC protection matrix.</summary>
    [JsonPropertyName("columnDepth")]
    public double? ColumnDepth { get; set; }

    /// <summary>Enables column only or column and row based FEC.</summary>
    [JsonPropertyName("includeFec")]
    public string? IncludeFec { get; set; }

    /// <summary>The width of the FEC protection matrix.</summary>
    [JsonPropertyName("rowLength")]
    public double? RowLength { get; set; }
}

/// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings
{
    /// <summary>UDP output buffering in milliseconds.</summary>
    [JsonPropertyName("bufferMsec")]
    public double? BufferMsec { get; set; }

    /// <summary>Settings specific to the container type of the file. See Container Settings for more details.</summary>
    [JsonPropertyName("containerSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsContainerSettings? ContainerSettings { get; set; }

    /// <summary>A director and base filename where archive files should be written. See Destination for more details.</summary>
    [JsonPropertyName("destination")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsDestination? Destination { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("fecOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettingsFecOutputSettings? FecOutputSettings { get; set; }
}

/// <summary>Settings for output. See Output Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettings
{
    /// <summary>Archive output settings. See Archive Output Settings for more details.</summary>
    [JsonPropertyName("archiveOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsArchiveOutputSettings? ArchiveOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("frameCaptureOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsFrameCaptureOutputSettings? FrameCaptureOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("hlsOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsHlsOutputSettings? HlsOutputSettings { get; set; }

    /// <summary>Media package output settings. This can be set as an empty block.</summary>
    [JsonPropertyName("mediaPackageOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMediaPackageOutputSettings? MediaPackageOutputSettings { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("msSmoothOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMsSmoothOutputSettings? MsSmoothOutputSettings { get; set; }

    /// <summary>Multiplex output settings. See Multiplex Output Settings for more details.</summary>
    [JsonPropertyName("multiplexOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsMultiplexOutputSettings? MultiplexOutputSettings { get; set; }

    /// <summary>RTMP output settings. See RTMP Output Settings for more details.</summary>
    [JsonPropertyName("rtmpOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsRtmpOutputSettings? RtmpOutputSettings { get; set; }

    /// <summary>UDP output settings. See UDP Output Settings for more details.</summary>
    [JsonPropertyName("udpOutputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettingsUdpOutputSettings? UdpOutputSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputs
{
    /// <summary>The names of the audio descriptions used as audio sources for the output.</summary>
    [JsonPropertyName("audioDescriptionNames")]
    public IList<string>? AudioDescriptionNames { get; set; }

    /// <summary>The names of the caption descriptions used as caption sources for the output.</summary>
    [JsonPropertyName("captionDescriptionNames")]
    public IList<string>? CaptionDescriptionNames { get; set; }

    /// <summary>The name used to identify an output.</summary>
    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>Settings for output. See Output Settings for more details.</summary>
    [JsonPropertyName("outputSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputsOutputSettings? OutputSettings { get; set; }

    /// <summary>The name of the video description used as video source for the output.</summary>
    [JsonPropertyName("videoDescriptionName")]
    public string? VideoDescriptionName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroups
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Settings associated with the output group. See Output Group Settings for more details.</summary>
    [JsonPropertyName("outputGroupSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputGroupSettings? OutputGroupSettings { get; set; }

    /// <summary>List of outputs. See Outputs for more details.</summary>
    [JsonPropertyName("outputs")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroupsOutputs>? Outputs { get; set; }
}

/// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsTimecodeConfig
{
    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Threshold in frames beyond which output timecode is resynchronized to the input timecode.</summary>
    [JsonPropertyName("syncThreshold")]
    public double? SyncThreshold { get; set; }
}

/// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings
{
    /// <summary>The frequency at which to capture frames for inclusion in the output.</summary>
    [JsonPropertyName("captureInterval")]
    public double? CaptureInterval { get; set; }

    /// <summary>Unit for the frame capture interval.</summary>
    [JsonPropertyName("captureIntervalUnits")]
    public string? CaptureIntervalUnits { get; set; }
}

/// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettingsTemporalFilterSettings? TemporalFilterSettings { get; set; }
}

/// <summary>H264 settings. See H264 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    [JsonPropertyName("bufFillPct")]
    public double? BufFillPct { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Entropy encoding mode.</summary>
    [JsonPropertyName("entropyEncoding")]
    public string? EntropyEncoding { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264SettingsFilterSettings? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Controls whether coding is performed on a field basis or on a frame basis.</summary>
    [JsonPropertyName("forceFieldPictures")]
    public string? ForceFieldPictures { get; set; }

    /// <summary>Indicates how the output video frame rate is specified.</summary>
    [JsonPropertyName("framerateControl")]
    public string? FramerateControl { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>GOP-B reference.</summary>
    [JsonPropertyName("gopBReference")]
    public string? GopBReference { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>Number of B-frames between reference frames.</summary>
    [JsonPropertyName("gopNumBFrames")]
    public double? GopNumBFrames { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>Min interval.</summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Number of reference frames to use.</summary>
    [JsonPropertyName("numRefFrames")]
    public double? NumRefFrames { get; set; }

    /// <summary>Indicates how the output pixel aspect ratio is specified.</summary>
    [JsonPropertyName("parControl")]
    public string? ParControl { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Quality level.</summary>
    [JsonPropertyName("qualityLevel")]
    public string? QualityLevel { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Softness.</summary>
    [JsonPropertyName("softness")]
    public double? Softness { get; set; }

    /// <summary>Makes adjustments within each frame based on spatial variation of content complexity.</summary>
    [JsonPropertyName("spatialAq")]
    public string? SpatialAq { get; set; }

    /// <summary>Subgop length.</summary>
    [JsonPropertyName("subgopLength")]
    public string? SubgopLength { get; set; }

    /// <summary>Produces a bitstream compliant with SMPTE RP-2027.</summary>
    [JsonPropertyName("syntax")]
    public string? Syntax { get; set; }

    /// <summary>Makes adjustments within each frame based on temporal variation of content complexity.</summary>
    [JsonPropertyName("temporalAq")]
    public string? TemporalAq { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }
}

/// <summary>Sets the colorspace metadata to be passed through.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings
{
}

/// <summary>Set the colorspace to Dolby Vision81.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings
{
}

/// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings
{
    /// <summary>Sets the MaxCLL value for HDR10.</summary>
    [JsonPropertyName("maxCll")]
    public double? MaxCll { get; set; }

    /// <summary>Sets the MaxFALL value for HDR10.</summary>
    [JsonPropertyName("maxFall")]
    public double? MaxFall { get; set; }
}

/// <summary>Set the colorspace to Rec. 601.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings
{
}

/// <summary>Set the colorspace to Rec. 709.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings
{
}

/// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings
{
    /// <summary>Sets the colorspace metadata to be passed through.</summary>
    [JsonPropertyName("colorSpacePassthroughSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsColorSpacePassthroughSettings? ColorSpacePassthroughSettings { get; set; }

    /// <summary>Set the colorspace to Dolby Vision81.</summary>
    [JsonPropertyName("dolbyVision81Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsDolbyVision81Settings? DolbyVision81Settings { get; set; }

    /// <summary>Set the colorspace to be HDR10. See H265 HDR10 Settings for more details.</summary>
    [JsonPropertyName("hdr10Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsHdr10Settings? Hdr10Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 601.</summary>
    [JsonPropertyName("rec601Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec601Settings? Rec601Settings { get; set; }

    /// <summary>Set the colorspace to Rec. 709.</summary>
    [JsonPropertyName("rec709Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettingsRec709Settings? Rec709Settings { get; set; }
}

/// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings
{
    /// <summary>Post filter sharpening.</summary>
    [JsonPropertyName("postFilterSharpening")]
    public string? PostFilterSharpening { get; set; }

    /// <summary>Filter strength.</summary>
    [JsonPropertyName("strength")]
    public string? Strength { get; set; }
}

/// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings
{
    /// <summary>Temporal filter settings. See Temporal Filter Settings</summary>
    [JsonPropertyName("temporalFilterSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettingsTemporalFilterSettings? TemporalFilterSettings { get; set; }
}

/// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings
{
    /// <summary>Set a prefix on the burned in timecode.</summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    /// <summary>Sets the size of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninFontSize")]
    public string? TimecodeBurninFontSize { get; set; }

    /// <summary>Sets the position of the burned in timecode.</summary>
    [JsonPropertyName("timecodeBurninPosition")]
    public string? TimecodeBurninPosition { get; set; }
}

/// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings
{
    /// <summary>Enables or disables adaptive quantization.</summary>
    [JsonPropertyName("adaptiveQuantization")]
    public string? AdaptiveQuantization { get; set; }

    /// <summary>Indicates that AFD values will be written into the output stream.</summary>
    [JsonPropertyName("afdSignaling")]
    public string? AfdSignaling { get; set; }

    /// <summary>Whether or not EML should insert an Alternative Transfer Function SEI message.</summary>
    [JsonPropertyName("alternativeTransferFunction")]
    public string? AlternativeTransferFunction { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("bitrate")]
    public double? Bitrate { get; set; }

    /// <summary>Size of buffer in bits.</summary>
    [JsonPropertyName("bufSize")]
    public double? BufSize { get; set; }

    /// <summary>Includes color space metadata in the output.</summary>
    [JsonPropertyName("colorMetadata")]
    public string? ColorMetadata { get; set; }

    /// <summary>Define the color metadata for the output. H265 Color Space Settings for more details.</summary>
    [JsonPropertyName("colorSpaceSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsColorSpaceSettings? ColorSpaceSettings { get; set; }

    /// <summary>Filters to apply to an encode. See H264 Filter Settings for more details.</summary>
    [JsonPropertyName("filterSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsFilterSettings? FilterSettings { get; set; }

    /// <summary>Four bit AFD value to write on all frames of video in the output stream.</summary>
    [JsonPropertyName("fixedAfd")]
    public string? FixedAfd { get; set; }

    [JsonPropertyName("flickerAq")]
    public string? FlickerAq { get; set; }

    /// <summary>Framerate denominator.</summary>
    [JsonPropertyName("framerateDenominator")]
    public double? FramerateDenominator { get; set; }

    /// <summary>Framerate numerator.</summary>
    [JsonPropertyName("framerateNumerator")]
    public double? FramerateNumerator { get; set; }

    /// <summary>Frequency of closed GOPs.</summary>
    [JsonPropertyName("gopClosedCadence")]
    public double? GopClosedCadence { get; set; }

    /// <summary>GOP size in units of either frames of seconds per gop_size_units.</summary>
    [JsonPropertyName("gopSize")]
    public double? GopSize { get; set; }

    /// <summary>Indicates if the gop_size is specified in frames or seconds.</summary>
    [JsonPropertyName("gopSizeUnits")]
    public string? GopSizeUnits { get; set; }

    /// <summary>H264 level.</summary>
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    /// <summary>Amount of lookahead.</summary>
    [JsonPropertyName("lookAheadRateControl")]
    public string? LookAheadRateControl { get; set; }

    /// <summary>Set the maximum bitrate in order to accommodate expected spikes in the complexity of the video.</summary>
    [JsonPropertyName("maxBitrate")]
    public double? MaxBitrate { get; set; }

    /// <summary>Min interval.</summary>
    [JsonPropertyName("minIInterval")]
    public double? MinIInterval { get; set; }

    /// <summary>Set the minimum QP.</summary>
    [JsonPropertyName("minQp")]
    public double? MinQp { get; set; }

    /// <summary>Enables or disables motion vector over picture boundaries.</summary>
    [JsonPropertyName("mvOverPictureBoundaries")]
    public string? MvOverPictureBoundaries { get; set; }

    /// <summary>Enables or disables the motion vector temporal predictor.</summary>
    [JsonPropertyName("mvTemporalPredictor")]
    public string? MvTemporalPredictor { get; set; }

    /// <summary>Pixel Aspect Ratio denominator.</summary>
    [JsonPropertyName("parDenominator")]
    public double? ParDenominator { get; set; }

    /// <summary>Pixel Aspect Ratio numerator.</summary>
    [JsonPropertyName("parNumerator")]
    public double? ParNumerator { get; set; }

    /// <summary>AAC profile.</summary>
    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    /// <summary>Controls the target quality for the video encode.</summary>
    [JsonPropertyName("qvbrQualityLevel")]
    public double? QvbrQualityLevel { get; set; }

    /// <summary>The rate control mode.</summary>
    [JsonPropertyName("rateControlMode")]
    public string? RateControlMode { get; set; }

    /// <summary>Sets the scan type of the output.</summary>
    [JsonPropertyName("scanType")]
    public string? ScanType { get; set; }

    /// <summary>Scene change detection.</summary>
    [JsonPropertyName("sceneChangeDetect")]
    public string? SceneChangeDetect { get; set; }

    /// <summary>Number of slices per picture.</summary>
    [JsonPropertyName("slices")]
    public double? Slices { get; set; }

    /// <summary>Set the H265 tier in the output.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Sets the height of tiles.</summary>
    [JsonPropertyName("tileHeight")]
    public double? TileHeight { get; set; }

    /// <summary>Enables or disables padding of tiles.</summary>
    [JsonPropertyName("tilePadding")]
    public string? TilePadding { get; set; }

    /// <summary>Sets the width of tiles.</summary>
    [JsonPropertyName("tileWidth")]
    public double? TileWidth { get; set; }

    /// <summary>Apply a burned in timecode. See H265 Timecode Burnin Settings for more details.</summary>
    [JsonPropertyName("timecodeBurninSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265SettingsTimecodeBurninSettings? TimecodeBurninSettings { get; set; }

    /// <summary>Determines how timecodes should be inserted into the video elementary stream.</summary>
    [JsonPropertyName("timecodeInsertion")]
    public string? TimecodeInsertion { get; set; }

    /// <summary>Sets the size of the treeblock.</summary>
    [JsonPropertyName("treeblockSize")]
    public string? TreeblockSize { get; set; }
}

/// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettings
{
    /// <summary>Frame capture settings. See Frame Capture Settings for more details.</summary>
    [JsonPropertyName("frameCaptureSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsFrameCaptureSettings? FrameCaptureSettings { get; set; }

    /// <summary>H264 settings. See H264 Settings for more details.</summary>
    [JsonPropertyName("h264Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH264Settings? H264Settings { get; set; }

    /// <summary>Destination settings for a standard output; one destination for each redundant encoder. See Settings for more details.</summary>
    [JsonPropertyName("h265Settings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettingsH265Settings? H265Settings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptions
{
    /// <summary>Audio codec settings. See Audio Codec Settings for more details.</summary>
    [JsonPropertyName("codecSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptionsCodecSettings? CodecSettings { get; set; }

    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, &quot;80&quot; means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Indicate how to respond to the AFD values that might be in the input video.</summary>
    [JsonPropertyName("respondToAfd")]
    public string? RespondToAfd { get; set; }

    /// <summary>Behavior on how to scale.</summary>
    [JsonPropertyName("scalingBehavior")]
    public string? ScalingBehavior { get; set; }

    /// <summary>Changes the strength of the anti-alias filter used for scaling.</summary>
    [JsonPropertyName("sharpness")]
    public double? Sharpness { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, &quot;80&quot; means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Encoder settings. See Encoder Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderEncoderSettings
{
    /// <summary>Audio descriptions for the channel. See Audio Descriptions for more details.</summary>
    [JsonPropertyName("audioDescriptions")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsAudioDescriptions>? AudioDescriptions { get; set; }

    /// <summary>Settings for ad avail blanking. See Avail Blanking for more details.</summary>
    [JsonPropertyName("availBlanking")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsAvailBlanking? AvailBlanking { get; set; }

    /// <summary>Caption Descriptions. See Caption Descriptions for more details.</summary>
    [JsonPropertyName("captionDescriptions")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsCaptionDescriptions>? CaptionDescriptions { get; set; }

    /// <summary>Configuration settings that apply to the event as a whole. See Global Configuration for more details.</summary>
    [JsonPropertyName("globalConfiguration")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsGlobalConfiguration? GlobalConfiguration { get; set; }

    /// <summary>Settings for motion graphics. See Motion Graphics Configuration for more details.</summary>
    [JsonPropertyName("motionGraphicsConfiguration")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsMotionGraphicsConfiguration? MotionGraphicsConfiguration { get; set; }

    /// <summary>Nielsen configuration settings. See Nielsen Configuration for more details.</summary>
    [JsonPropertyName("nielsenConfiguration")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsNielsenConfiguration? NielsenConfiguration { get; set; }

    /// <summary>Output groups for the channel. See Output Groups for more details.</summary>
    [JsonPropertyName("outputGroups")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsOutputGroups>? OutputGroups { get; set; }

    /// <summary>Contains settings used to acquire and adjust timecode information from inputs. See Timecode Config for more details.</summary>
    [JsonPropertyName("timecodeConfig")]
    public V1beta2ChannelStatusAtProviderEncoderSettingsTimecodeConfig? TimecodeConfig { get; set; }

    /// <summary>Video Descriptions. See Video Descriptions for more details.</summary>
    [JsonPropertyName("videoDescriptions")]
    public IList<V1beta2ChannelStatusAtProviderEncoderSettingsVideoDescriptions>? VideoDescriptions { get; set; }
}

/// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings
{
    /// <summary>The name of the audio selector in the input that MediaLive should monitor to detect silence. Select your most important rendition. If you didn&apos;t create an audio selector in this input, leave blank.</summary>
    [JsonPropertyName("audioSelectorName")]
    public string? AudioSelectorName { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be silent before automatic input failover occurs. Silence is defined as audio loss or audio quieter than -50 dBFS.</summary>
    [JsonPropertyName("audioSilenceThresholdMsec")]
    public double? AudioSilenceThresholdMsec { get; set; }
}

/// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings
{
    /// <summary>The amount of time (in milliseconds) that no input is detected. After that time, an input failover will occur.</summary>
    [JsonPropertyName("inputLossThresholdMsec")]
    public double? InputLossThresholdMsec { get; set; }
}

/// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings
{
    /// <summary>A value used in calculating the threshold below which MediaLive considers a pixel to be &apos;black&apos;. For the input to be considered black, every pixel in a frame must be below this threshold. The threshold is calculated as a percentage (expressed as a decimal) of white. Therefore .1 means 10% white (or 90% black). Note how the formula works for any color depth. For example, if you set this field to 0.1 in 10-bit color depth: (10230.1=102.3), which means a pixel value of 102 or less is &apos;black&apos;. If you set this field to .1 in an 8-bit color depth: (2550.1=25.5), which means a pixel value of 25 or less is &apos;black&apos;. The range is 0.0 to 1.0, with any number of decimal places.</summary>
    [JsonPropertyName("blackDetectThreshold")]
    public double? BlackDetectThreshold { get; set; }

    /// <summary>The amount of time (in milliseconds) that the active input must be black before automatic input failover occurs.</summary>
    [JsonPropertyName("videoBlackThresholdMsec")]
    public double? VideoBlackThresholdMsec { get; set; }
}

/// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings
{
    /// <summary>MediaLive will perform a failover if the specified audio selector is silent for the specified period. See Audio Silence Failover Settings for more details.</summary>
    [JsonPropertyName("audioSilenceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsAudioSilenceSettings? AudioSilenceSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is not detected in this input for the specified period. See Input Loss Failover Settings for more details.</summary>
    [JsonPropertyName("inputLossSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsInputLossSettings? InputLossSettings { get; set; }

    /// <summary>MediaLive will perform a failover if content is considered black for the specified period. See Video Black Failover Settings for more details.</summary>
    [JsonPropertyName("videoBlackSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettingsVideoBlackSettings? VideoBlackSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition
{
    /// <summary>Failover condition type-specific settings. See Failover Condition Settings for more details.</summary>
    [JsonPropertyName("failoverConditionSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverConditionFailoverConditionSettings? FailoverConditionSettings { get; set; }
}

/// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettings
{
    /// <summary>This clear time defines the requirement a recovered input must meet to be considered healthy. The input must have no failover conditions for this length of time. Enter a time in milliseconds. This value is particularly important if the input_preference for the failover pair is set to PRIMARY_INPUT_PREFERRED, because after this time, MediaLive will switch back to the primary input.</summary>
    [JsonPropertyName("errorClearTimeMsec")]
    public double? ErrorClearTimeMsec { get; set; }

    /// <summary>A list of failover conditions. If any of these conditions occur, MediaLive will perform a failover to the other input. See Failover Condition Block for more details.</summary>
    [JsonPropertyName("failoverCondition")]
    public IList<V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettingsFailoverCondition>? FailoverCondition { get; set; }

    /// <summary>Input preference when deciding which input to make active when a previously failed input has recovered.</summary>
    [JsonPropertyName("inputPreference")]
    public string? InputPreference { get; set; }

    /// <summary>The input ID of the secondary input in the automatic input failover pair.</summary>
    [JsonPropertyName("secondaryInputId")]
    public string? SecondaryInputId { get; set; }
}

/// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection
{
    /// <summary>Specifies the GROUP-ID in the #EXT-X-MEDIA tag of the target HLS audio rendition.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>When set to “strict”, the transport stream demux strictly identifies audio streams by their language descriptor. If a PMT update occurs such that an audio stream matching the initially selected language is no longer present then mute will be encoded until the language returns. If “loose”, then on a PMT update the demux will choose another audio stream in the program with the same stream type if it can’t find one with the same language.</summary>
    [JsonPropertyName("languageSelectionPolicy")]
    public string? LanguageSelectionPolicy { get; set; }
}

/// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection
{
    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode
{
    /// <summary>Applies only to Dolby E. Enter the program ID (according to the metadata in the audio) of the Dolby E program to extract from the specified track. One program extracted per audio selector. To select multiple programs, create multiple selectors with the same Track and different Program numbers. “All channels” means to ignore the program IDs and include all the channels in this selector; useful if metadata is known to be incorrect.</summary>
    [JsonPropertyName("programSelection")]
    public string? ProgramSelection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks
{
    /// <summary>1-based integer value that maps to a specific audio track.</summary>
    [JsonPropertyName("track")]
    public double? Track { get; set; }
}

/// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection
{
    /// <summary>Configure decoding options for Dolby E streams - these should be Dolby E frames carried in PCM streams tagged with SMPTE-337. See Dolby E Decode for more details.</summary>
    [JsonPropertyName("dolbyEDecode")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionDolbyEDecode? DolbyEDecode { get; set; }

    /// <summary>Selects one or more unique audio tracks from within a source. See Audio Tracks for more details.</summary>
    [JsonPropertyName("tracks")]
    public IList<V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelectionTracks>? Tracks { get; set; }
}

/// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings
{
    /// <summary>Audio HLS Rendition Selection. See Audio HLS Rendition Selection for more details.</summary>
    [JsonPropertyName("audioHlsRenditionSelection")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioHlsRenditionSelection? AudioHlsRenditionSelection { get; set; }

    /// <summary>Audio Language Selection. See Audio Language Selection for more details.</summary>
    [JsonPropertyName("audioLanguageSelection")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioLanguageSelection? AudioLanguageSelection { get; set; }

    /// <summary>Audio Pid Selection. See Audio PID Selection for more details.</summary>
    [JsonPropertyName("audioPidSelection")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioPidSelection? AudioPidSelection { get; set; }

    /// <summary>Audio Track Selection. See Audio Track Selection for more details.</summary>
    [JsonPropertyName("audioTrackSelection")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettingsAudioTrackSelection? AudioTrackSelection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelector
{
    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelectorSelectorSettings? SelectorSettings { get; set; }
}

/// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings
{
    /// <summary>Specifies the number (1 to 4) of the captions channel you want to extract from the ancillary captions. If you plan to convert the ancillary captions to another format, complete this field. If you plan to choose Embedded as the captions destination in the output (to pass through all the channels in the ancillary captions), leave this field blank because MediaLive ignores the field.</summary>
    [JsonPropertyName("sourceAncillaryChannelNumber")]
    public double? SourceAncillaryChannelNumber { get; set; }
}

/// <summary>ARIB Source Settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings
{
}

/// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Set to “auto” to handle streams with intermittent and/or non-aligned SCTE-20 and Embedded captions.</summary>
    [JsonPropertyName("scte20Detection")]
    public string? Scte20Detection { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings
{
    /// <summary>If upconvert, 608 data is both passed through via the “608 compatibility bytes” fields of the 708 wrapper as well as translated into 708. 708 data present in the source content will be discarded.</summary>
    [JsonPropertyName("convert608To708")]
    public string? Convert608To708 { get; set; }

    /// <summary>Specifies the 608/708 channel number within the video track from which to extract captions. Unused for passthrough.</summary>
    [JsonPropertyName("source608ChannelNumber")]
    public double? Source608ChannelNumber { get; set; }
}

/// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings
{
    /// <summary>If you will configure a WebVTT caption description that references this caption selector, use this field to provide the language to consider when translating the image-based source to text.</summary>
    [JsonPropertyName("ocrLanguage")]
    public string? OcrLanguage { get; set; }

    /// <summary>Selects a specific PID from within a source.</summary>
    [JsonPropertyName("pid")]
    public double? Pid { get; set; }
}

/// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle
{
    /// <summary>See the description in left_offset. For height, specify the entire height of the rectangle as a percentage of the underlying frame height. For example, &quot;80&quot; means the rectangle height is 80% of the underlying frame height. The top_offset and rectangle_height must add up to 100% or less. This field corresponds to tts:extent - Y in the TTML standard.</summary>
    [JsonPropertyName("height")]
    public double? Height { get; set; }

    /// <summary>Applies only if you plan to convert these source captions to EBU-TT-D or TTML in an output. (Make sure to leave the default if you don’t have either of these formats in the output.) You can define a display rectangle for the captions that is smaller than the underlying video frame. You define the rectangle by specifying the position of the left edge, top edge, bottom edge, and right edge of the rectangle, all within the underlying video frame. The units for the measurements are percentages. If you specify a value for one of these fields, you must specify a value for all of them. For leftOffset, specify the position of the left edge of the rectangle, as a percentage of the underlying frame width, and relative to the left edge of the frame. For example, &quot;10&quot; means the measurement is 10% of the underlying frame width. The rectangle left edge starts at that position from the left edge of the frame. This field corresponds to tts:origin - X in the TTML standard.</summary>
    [JsonPropertyName("leftOffset")]
    public double? LeftOffset { get; set; }

    /// <summary>See the description in left_offset. For top_offset, specify the position of the top edge of the rectangle, as a percentage of the underlying frame height, and relative to the top edge of the frame. For example, &quot;10&quot; means the measurement is 10% of the underlying frame height. The rectangle top edge starts at that position from the top edge of the frame. This field corresponds to tts:origin - Y in the TTML standard.</summary>
    [JsonPropertyName("topOffset")]
    public double? TopOffset { get; set; }

    /// <summary>See the description in left_offset. For width, specify the entire width of the rectangle as a percentage of the underlying frame width. For example, &quot;80&quot; means the rectangle width is 80% of the underlying frame width. The left_offset and rectangle_width must add up to 100% or less. This field corresponds to tts:extent - X in the TTML standard.</summary>
    [JsonPropertyName("width")]
    public double? Width { get; set; }
}

/// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings
{
    /// <summary>Optionally defines a region where TTML style captions will be displayed. See Caption Rectangle for more details.</summary>
    [JsonPropertyName("outputRectangle")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettingsOutputRectangle? OutputRectangle { get; set; }

    /// <summary>Specifies the teletext page number within the data stream from which to extract captions. Range of 0x100 (256) to 0x8FF (2303). Unused for passthrough. Should be specified as a hexadecimal string with no “0x” prefix.</summary>
    [JsonPropertyName("pageNumber")]
    public string? PageNumber { get; set; }
}

/// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings
{
    /// <summary>Ancillary Source Settings. See Ancillary Source Settings for more details.</summary>
    [JsonPropertyName("ancillarySourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAncillarySourceSettings? AncillarySourceSettings { get; set; }

    /// <summary>ARIB Source Settings.</summary>
    [JsonPropertyName("aribSourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsAribSourceSettings? AribSourceSettings { get; set; }

    /// <summary>DVB Sub Source Settings. See DVB Sub Source Settings for more details.</summary>
    [JsonPropertyName("dvbSubSourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsDvbSubSourceSettings? DvbSubSourceSettings { get; set; }

    /// <summary>Embedded Source Settings. See Embedded Source Settings for more details.</summary>
    [JsonPropertyName("embeddedSourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsEmbeddedSourceSettings? EmbeddedSourceSettings { get; set; }

    /// <summary>SCTE20 Source Settings. See SCTE 20 Source Settings for more details.</summary>
    [JsonPropertyName("scte20SourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte20SourceSettings? Scte20SourceSettings { get; set; }

    /// <summary>SCTE27 Source Settings. See SCTE 27 Source Settings for more details.</summary>
    [JsonPropertyName("scte27SourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsScte27SourceSettings? Scte27SourceSettings { get; set; }

    /// <summary>Teletext Source Settings. See Teletext Source Settings for more details.</summary>
    [JsonPropertyName("teletextSourceSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettingsTeletextSourceSettings? TeletextSourceSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelector
{
    /// <summary>Selects a specific three-letter language code from within an audio source.</summary>
    [JsonPropertyName("languageCode")]
    public string? LanguageCode { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The audio selector settings. See Audio Selector Settings for more details.</summary>
    [JsonPropertyName("selectorSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelectorSelectorSettings? SelectorSettings { get; set; }
}

/// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings
{
    /// <summary>The bitrate is specified in bits per second, as in an HLS manifest.</summary>
    [JsonPropertyName("bandwidth")]
    public double? Bandwidth { get; set; }

    /// <summary>Buffer segments.</summary>
    [JsonPropertyName("bufferSegments")]
    public double? BufferSegments { get; set; }

    /// <summary>The number of consecutive times that attempts to read a manifest or segment must fail before the input is considered unavailable.</summary>
    [JsonPropertyName("retries")]
    public double? Retries { get; set; }

    /// <summary>The number of seconds between retries when an attempt to read a manifest or segment fails.</summary>
    [JsonPropertyName("retryInterval")]
    public double? RetryInterval { get; set; }

    /// <summary>The source for the timecode that will be associated with the events outputs.</summary>
    [JsonPropertyName("scte35Source")]
    public string? Scte35Source { get; set; }
}

/// <summary>Input settings. See Network Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettings
{
    /// <summary>Specifies HLS input settings when the uri is for a HLS manifest. See HLS Input Settings for more details.</summary>
    [JsonPropertyName("hlsInputSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettingsHlsInputSettings? HlsInputSettings { get; set; }

    /// <summary>Check HTTPS server certificates.</summary>
    [JsonPropertyName("serverValidation")]
    public string? ServerValidation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsVideoSelector
{
    [JsonPropertyName("colorSpace")]
    public string? ColorSpace { get; set; }

    [JsonPropertyName("colorSpaceUsage")]
    public string? ColorSpaceUsage { get; set; }
}

/// <summary>Settings of an input. See Input Settings for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachmentsInputSettings
{
    /// <summary>Used to select the audio stream to decode for inputs that have multiple. See Audio Selectors for more details.</summary>
    [JsonPropertyName("audioSelector")]
    public IList<V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsAudioSelector>? AudioSelector { get; set; }

    /// <summary>Used to select the caption input to use for inputs that have multiple available. See Caption Selectors for more details.</summary>
    [JsonPropertyName("captionSelector")]
    public IList<V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsCaptionSelector>? CaptionSelector { get; set; }

    /// <summary>Enable or disable the deblock filter when filtering.</summary>
    [JsonPropertyName("deblockFilter")]
    public string? DeblockFilter { get; set; }

    /// <summary>Enable or disable the denoise filter when filtering.</summary>
    [JsonPropertyName("denoiseFilter")]
    public string? DenoiseFilter { get; set; }

    /// <summary>Adjusts the magnitude of filtering from 1 (minimal) to 5 (strongest).</summary>
    [JsonPropertyName("filterStrength")]
    public double? FilterStrength { get; set; }

    /// <summary>Turns on the filter for the input.</summary>
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    /// <summary>Input settings. See Network Input Settings for more details.</summary>
    [JsonPropertyName("networkInputSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsNetworkInputSettings? NetworkInputSettings { get; set; }

    /// <summary>PID from which to read SCTE-35 messages.</summary>
    [JsonPropertyName("scte35Pid")]
    public double? Scte35Pid { get; set; }

    /// <summary>Specifies whether to extract applicable ancillary data from a SMPTE-2038 source in the input.</summary>
    [JsonPropertyName("smpte2038DataPreference")]
    public string? Smpte2038DataPreference { get; set; }

    /// <summary>Loop input if it is a file.</summary>
    [JsonPropertyName("sourceEndBehavior")]
    public string? SourceEndBehavior { get; set; }

    [JsonPropertyName("videoSelector")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettingsVideoSelector? VideoSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputAttachments
{
    /// <summary>User-specified settings for defining what the conditions are for declaring the input unhealthy and failing over to a different input. See Automatic Input Failover Settings for more details.</summary>
    [JsonPropertyName("automaticInputFailoverSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsAutomaticInputFailoverSettings? AutomaticInputFailoverSettings { get; set; }

    /// <summary>User-specified name for the attachment.</summary>
    [JsonPropertyName("inputAttachmentName")]
    public string? InputAttachmentName { get; set; }

    /// <summary>The ID of the input.</summary>
    [JsonPropertyName("inputId")]
    public string? InputId { get; set; }

    /// <summary>Settings of an input. See Input Settings for more details.</summary>
    [JsonPropertyName("inputSettings")]
    public V1beta2ChannelStatusAtProviderInputAttachmentsInputSettings? InputSettings { get; set; }
}

/// <summary>Specification of network and file inputs for the channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderInputSpecification
{
    [JsonPropertyName("codec")]
    public string? Codec { get; set; }

    /// <summary>- Maximum CDI input resolution.</summary>
    [JsonPropertyName("inputResolution")]
    public string? InputResolution { get; set; }

    /// <summary>Average bitrate in bits/second.</summary>
    [JsonPropertyName("maximumBitrate")]
    public string? MaximumBitrate { get; set; }
}

/// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderMaintenance
{
    /// <summary>The day of the week to use for maintenance.</summary>
    [JsonPropertyName("maintenanceDay")]
    public string? MaintenanceDay { get; set; }

    /// <summary>The hour maintenance will start.</summary>
    [JsonPropertyName("maintenanceStartTime")]
    public string? MaintenanceStartTime { get; set; }
}

/// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProviderVpc
{
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    [JsonPropertyName("networkInterfaceIds")]
    public IList<string>? NetworkInterfaceIds { get; set; }

    /// <summary>List of public address allocation ids to associate with ENIs that will be created in Output VPC. Must specify one for SINGLE_PIPELINE, two for STANDARD channels.</summary>
    [JsonPropertyName("publicAddressAllocationIds")]
    public IList<string>? PublicAddressAllocationIds { get; set; }

    /// <summary>A list of up to 5 EC2 VPC security group IDs to attach to the Output VPC network interfaces. If none are specified then the VPC default security group will be used.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of VPC subnet IDs from the same VPC. If STANDARD channel, subnet IDs must be mapped to two unique availability zones (AZ).</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusAtProvider
{
    /// <summary>ARN of the Channel.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specification of CDI inputs for this channel. See CDI Input Specification for more details.</summary>
    [JsonPropertyName("cdiInputSpecification")]
    public V1beta2ChannelStatusAtProviderCdiInputSpecification? CdiInputSpecification { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("channelClass")]
    public string? ChannelClass { get; set; }

    /// <summary>ID of the channel in MediaPackage that is the destination for this output group.</summary>
    [JsonPropertyName("channelId")]
    public string? ChannelId { get; set; }

    /// <summary>Destinations for channel. See Destinations for more details.</summary>
    [JsonPropertyName("destinations")]
    public IList<V1beta2ChannelStatusAtProviderDestinations>? Destinations { get; set; }

    /// <summary>Encoder settings. See Encoder Settings for more details.</summary>
    [JsonPropertyName("encoderSettings")]
    public V1beta2ChannelStatusAtProviderEncoderSettings? EncoderSettings { get; set; }

    /// <summary>User-specified id. Ths is used in an output group or an output.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Input attachments for the channel. See Input Attachments for more details.</summary>
    [JsonPropertyName("inputAttachments")]
    public IList<V1beta2ChannelStatusAtProviderInputAttachments>? InputAttachments { get; set; }

    /// <summary>Specification of network and file inputs for the channel.</summary>
    [JsonPropertyName("inputSpecification")]
    public V1beta2ChannelStatusAtProviderInputSpecification? InputSpecification { get; set; }

    /// <summary>The log level to write to Cloudwatch logs.</summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Maintenance settings for this channel. See Maintenance for more details.</summary>
    [JsonPropertyName("maintenance")]
    public V1beta2ChannelStatusAtProviderMaintenance? Maintenance { get; set; }

    /// <summary>Name of the Channel.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Concise argument description.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Whether to start/stop channel. Default: false</summary>
    [JsonPropertyName("startChannel")]
    public bool? StartChannel { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Settings for the VPC outputs. See VPC for more details.</summary>
    [JsonPropertyName("vpc")]
    public V1beta2ChannelStatusAtProviderVpc? Vpc { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatusConditions
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

/// <summary>ChannelStatus defines the observed state of Channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ChannelStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ChannelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ChannelStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Channel is the Schema for the Channels API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Channel : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ChannelSpec>, IStatus<V1beta2ChannelStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Channel";
    public const string KubeGroup = "medialive.aws.upbound.io";
    public const string KubePluralName = "channels";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "medialive.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Channel";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ChannelSpec defines the desired state of Channel</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ChannelSpec Spec { get; set; }

    /// <summary>ChannelStatus defines the observed state of Channel.</summary>
    [JsonPropertyName("status")]
    public V1beta2ChannelStatus? Status { get; set; }
}