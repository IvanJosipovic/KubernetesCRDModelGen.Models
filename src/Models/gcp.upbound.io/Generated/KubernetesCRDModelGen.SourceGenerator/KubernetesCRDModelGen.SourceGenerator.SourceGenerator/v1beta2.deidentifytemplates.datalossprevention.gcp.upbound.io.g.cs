#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datalossprevention.gcp.upbound.io;
/// <summary>DeidentifyTemplate is the Schema for the DeidentifyTemplates API. Allows creation of templates to de-identify content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DeidentifyTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DeidentifyTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DeidentifyTemplateList";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "deidentifytemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeidentifyTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DeidentifyTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DeidentifyTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeidentifyTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2DeidentifyTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Apply transformation to all findings not specified in other ImageTransformation&apos;s selectedInfoTypes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes
{
}

/// <summary>Apply transformation to all text that doesn&apos;t match an infoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllText
{
}

/// <summary>
/// The color to use when redacting content from an image. If not specified, the default is black.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsRedactionColor
{
    /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("blue")]
    public double? Blue { get; set; }

    /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("green")]
    public double? Green { get; set; }

    /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("red")]
    public double? Red { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Apply transformation to the selected infoTypes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes>? InfoTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransforms
{
    /// <summary>Apply transformation to all findings not specified in other ImageTransformation&apos;s selectedInfoTypes.</summary>
    [JsonPropertyName("allInfoTypes")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes? AllInfoTypes { get; set; }

    /// <summary>Apply transformation to all text that doesn&apos;t match an infoType.</summary>
    [JsonPropertyName("allText")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsAllText? AllText { get; set; }

    /// <summary>
    /// The color to use when redacting content from an image. If not specified, the default is black.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("redactionColor")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsRedactionColor? RedactionColor { get; set; }

    /// <summary>
    /// Apply transformation to the selected infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selectedInfoTypes")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes? SelectedInfoTypes { get; set; }
}

/// <summary>
/// Treat the dataset as an image and redact.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformations
{
    /// <summary>
    /// For determination of how redaction of images should occur.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transforms")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformationsTransforms>? Transforms { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public double? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public bool? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Treat the dataset as free-form text and apply the same free text transformation everywhere
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformations
{
    /// <summary>
    /// Transformation for each infoType. Cannot specify more than one for a given infoType.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary>
/// Field within the record this condition is evaluated against.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Value to compare against.
/// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
/// This argument is mandatory, except for conditions using the EXISTS operator.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>
    /// Field within the record this condition is evaluated against.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField? Field { get; set; }

    /// <summary>
    /// Operator used to compare the field or infoType to the value.
    /// Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Value to compare against.
    /// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
    /// This argument is mandatory, except for conditions using the EXISTS operator.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("value")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>
/// Conditions to apply to the expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>
/// An expression, consisting of an operator and conditions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND.
    /// Default value is AND.
    /// Possible values are: AND.
    /// </summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>
/// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>
    /// An expression, consisting of an operator and conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expressions")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions? Expressions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>Replace each matching finding with the name of the info type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig
{
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Treat the contents of the field as free text, and selectively transform content that matches an InfoType.
/// Only one of primitive_transformation or info_type_transformations must be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>
    /// Transformation for each infoType. Cannot specify more than one for a given infoType.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>
    /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition? Condition { get; set; }

    /// <summary>
    /// Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId.
    /// FieldId name matching ignores the index. For example, instead of &quot;contact.nums[0].type&quot;, use &quot;contact.nums.type&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields>? Fields { get; set; }

    /// <summary>
    /// Treat the contents of the field as free text, and selectively transform content that matches an InfoType.
    /// Only one of primitive_transformation or info_type_transformations must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Field within the record this condition is evaluated against.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Value to compare against.
/// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
/// This argument is mandatory, except for conditions using the EXISTS operator.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>
    /// Field within the record this condition is evaluated against.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField? Field { get; set; }

    /// <summary>
    /// Operator used to compare the field or infoType to the value.
    /// Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Value to compare against.
    /// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
    /// This argument is mandatory, except for conditions using the EXISTS operator.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("value")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>
/// Conditions to apply to the expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>
/// An expression, consisting of an operator and conditions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND.
    /// Default value is AND.
    /// Possible values are: AND.
    /// </summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>
/// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>
    /// An expression, consisting of an operator and conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expressions")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions? Expressions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>
    /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition? Condition { get; set; }
}

/// <summary>
/// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformations
{
    /// <summary>
    /// Transform the record by applying various field transformations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>
    /// Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary>
/// Configuration of the deidentify template
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfig
{
    /// <summary>
    /// Treat the dataset as an image and redact.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageTransformations")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigImageTransformations? ImageTransformations { get; set; }

    /// <summary>
    /// Treat the dataset as free-form text and apply the same free text transformation everywhere
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>
    /// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recordTransformations")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfigRecordTransformations? RecordTransformations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecForProvider
{
    /// <summary>
    /// Configuration of the deidentify template
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deidentifyConfig")]
    public V1beta2DeidentifyTemplateSpecForProviderDeidentifyConfig? DeidentifyConfig { get; set; }

    /// <summary>A description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The parent of the template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>Apply transformation to all findings not specified in other ImageTransformation&apos;s selectedInfoTypes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes
{
}

/// <summary>Apply transformation to all text that doesn&apos;t match an infoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllText
{
}

/// <summary>
/// The color to use when redacting content from an image. If not specified, the default is black.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsRedactionColor
{
    /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("blue")]
    public double? Blue { get; set; }

    /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("green")]
    public double? Green { get; set; }

    /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("red")]
    public double? Red { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Apply transformation to the selected infoTypes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes>? InfoTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransforms
{
    /// <summary>Apply transformation to all findings not specified in other ImageTransformation&apos;s selectedInfoTypes.</summary>
    [JsonPropertyName("allInfoTypes")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes? AllInfoTypes { get; set; }

    /// <summary>Apply transformation to all text that doesn&apos;t match an infoType.</summary>
    [JsonPropertyName("allText")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsAllText? AllText { get; set; }

    /// <summary>
    /// The color to use when redacting content from an image. If not specified, the default is black.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("redactionColor")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsRedactionColor? RedactionColor { get; set; }

    /// <summary>
    /// Apply transformation to the selected infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selectedInfoTypes")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes? SelectedInfoTypes { get; set; }
}

/// <summary>
/// Treat the dataset as an image and redact.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformations
{
    /// <summary>
    /// For determination of how redaction of images should occur.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transforms")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformationsTransforms>? Transforms { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public double? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public bool? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Treat the dataset as free-form text and apply the same free text transformation everywhere
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformations
{
    /// <summary>
    /// Transformation for each infoType. Cannot specify more than one for a given infoType.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary>
/// Field within the record this condition is evaluated against.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Value to compare against.
/// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
/// This argument is mandatory, except for conditions using the EXISTS operator.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>
    /// Field within the record this condition is evaluated against.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField? Field { get; set; }

    /// <summary>
    /// Operator used to compare the field or infoType to the value.
    /// Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Value to compare against.
    /// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
    /// This argument is mandatory, except for conditions using the EXISTS operator.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("value")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>
/// Conditions to apply to the expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>
/// An expression, consisting of an operator and conditions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND.
    /// Default value is AND.
    /// Possible values are: AND.
    /// </summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>
/// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>
    /// An expression, consisting of an operator and conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expressions")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions? Expressions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public required V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public required V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public required V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public required V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>Replace each matching finding with the name of the info type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig
{
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Treat the contents of the field as free text, and selectively transform content that matches an InfoType.
/// Only one of primitive_transformation or info_type_transformations must be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>
    /// Transformation for each infoType. Cannot specify more than one for a given infoType.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>
    /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition? Condition { get; set; }

    /// <summary>
    /// Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId.
    /// FieldId name matching ignores the index. For example, instead of &quot;contact.nums[0].type&quot;, use &quot;contact.nums.type&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields>? Fields { get; set; }

    /// <summary>
    /// Treat the contents of the field as free text, and selectively transform content that matches an InfoType.
    /// Only one of primitive_transformation or info_type_transformations must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Field within the record this condition is evaluated against.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Value to compare against.
/// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
/// This argument is mandatory, except for conditions using the EXISTS operator.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>
    /// Field within the record this condition is evaluated against.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField? Field { get; set; }

    /// <summary>
    /// Operator used to compare the field or infoType to the value.
    /// Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Value to compare against.
    /// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
    /// This argument is mandatory, except for conditions using the EXISTS operator.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("value")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>
/// Conditions to apply to the expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>
/// An expression, consisting of an operator and conditions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND.
    /// Default value is AND.
    /// Possible values are: AND.
    /// </summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>
/// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>
    /// An expression, consisting of an operator and conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expressions")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions? Expressions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>
    /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition? Condition { get; set; }
}

/// <summary>
/// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformations
{
    /// <summary>
    /// Transform the record by applying various field transformations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>
    /// Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary>
/// Configuration of the deidentify template
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfig
{
    /// <summary>
    /// Treat the dataset as an image and redact.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageTransformations")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigImageTransformations? ImageTransformations { get; set; }

    /// <summary>
    /// Treat the dataset as free-form text and apply the same free text transformation everywhere
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>
    /// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recordTransformations")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfigRecordTransformations? RecordTransformations { get; set; }
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
public partial class V1beta2DeidentifyTemplateSpecInitProvider
{
    /// <summary>
    /// Configuration of the deidentify template
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deidentifyConfig")]
    public V1beta2DeidentifyTemplateSpecInitProviderDeidentifyConfig? DeidentifyConfig { get; set; }

    /// <summary>A description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The parent of the template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeidentifyTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2DeidentifyTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeidentifyTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DeidentifyTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeidentifyTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DeidentifyTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeidentifyTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeidentifyTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeidentifyTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DeidentifyTemplateSpec defines the desired state of DeidentifyTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateSpec
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
    public V1beta2DeidentifyTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DeidentifyTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2DeidentifyTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DeidentifyTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DeidentifyTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DeidentifyTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Apply transformation to all findings not specified in other ImageTransformation&apos;s selectedInfoTypes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes
{
}

/// <summary>Apply transformation to all text that doesn&apos;t match an infoType.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllText
{
}

/// <summary>
/// The color to use when redacting content from an image. If not specified, the default is black.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsRedactionColor
{
    /// <summary>The amount of blue in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("blue")]
    public double? Blue { get; set; }

    /// <summary>The amount of green in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("green")]
    public double? Green { get; set; }

    /// <summary>The amount of red in the color as a value in the interval [0, 1].</summary>
    [JsonPropertyName("red")]
    public double? Red { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Apply transformation to the selected infoTypes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypesInfoTypes>? InfoTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransforms
{
    /// <summary>Apply transformation to all findings not specified in other ImageTransformation&apos;s selectedInfoTypes.</summary>
    [JsonPropertyName("allInfoTypes")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllInfoTypes? AllInfoTypes { get; set; }

    /// <summary>Apply transformation to all text that doesn&apos;t match an infoType.</summary>
    [JsonPropertyName("allText")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsAllText? AllText { get; set; }

    /// <summary>
    /// The color to use when redacting content from an image. If not specified, the default is black.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("redactionColor")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsRedactionColor? RedactionColor { get; set; }

    /// <summary>
    /// Apply transformation to the selected infoTypes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selectedInfoTypes")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransformsSelectedInfoTypes? SelectedInfoTypes { get; set; }
}

/// <summary>
/// Treat the dataset as an image and redact.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformations
{
    /// <summary>
    /// For determination of how redaction of images should occur.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transforms")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformationsTransforms>? Transforms { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public double? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public bool? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformations
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Treat the dataset as free-form text and apply the same free text transformation everywhere
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformations
{
    /// <summary>
    /// Transformation for each infoType. Cannot specify more than one for a given infoType.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary>
/// Field within the record this condition is evaluated against.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Value to compare against.
/// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
/// This argument is mandatory, except for conditions using the EXISTS operator.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions
{
    /// <summary>
    /// Field within the record this condition is evaluated against.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsField? Field { get; set; }

    /// <summary>
    /// Operator used to compare the field or infoType to the value.
    /// Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Value to compare against.
    /// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
    /// This argument is mandatory, except for conditions using the EXISTS operator.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("value")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>
/// Conditions to apply to the expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>
/// An expression, consisting of an operator and conditions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND.
    /// Default value is AND.
    /// Possible values are: AND.
    /// </summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>
/// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition
{
    /// <summary>
    /// An expression, consisting of an operator and conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expressions")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsConditionExpressions? Expressions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypesSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// A 128/192/256 bit key.
/// A base64-encoded string.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef
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
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrappedKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>Replace each matching finding with the name of the info type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig
{
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>Replace each matching finding with the name of the info type.</summary>
    [JsonPropertyName("replaceWithInfoTypeConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationReplaceWithInfoTypeConfig? ReplaceWithInfoTypeConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations
{
    /// <summary>
    /// InfoTypes to apply the transformation to. Leaving this empty will apply the transformation to apply to
    /// all findings that correspond to infoTypes that were requested in InspectConfig.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypes")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsInfoTypes>? InfoTypes { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Treat the contents of the field as free text, and selectively transform content that matches an InfoType.
/// Only one of primitive_transformation or info_type_transformations must be specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations
{
    /// <summary>
    /// Transformation for each infoType. Cannot specify more than one for a given infoType.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transformations")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformationsTransformations>? Transformations { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound of the range, exclusive; type must match min.
/// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMaxTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound of the range, inclusive. Type should be the same as max if used.
/// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMinTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replacement value for this bucket.
/// The replacement_value block must only contain one argument.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets
{
    /// <summary>
    /// Upper bound of the range, exclusive; type must match min.
    /// The max block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("max")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMax? Max { get; set; }

    /// <summary>
    /// Lower bound of the range, inclusive. Type should be the same as max if used.
    /// The min block must only contain one argument. See the bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("min")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsMin? Min { get; set; }

    /// <summary>
    /// Replacement value for this bucket.
    /// The replacement_value block must only contain one argument.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replacementValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBucketsReplacementValue? ReplacementValue { get; set; }
}

/// <summary>
/// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
/// This can be used on data of type: number, long, string, timestamp.
/// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig
{
    /// <summary>
    /// Set of buckets. Ranges must be non-overlapping.
    /// Bucket is represented as a range, along with replacement values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buckets")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfigBuckets>? Buckets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore
{
    /// <summary>Characters to not transform when masking.</summary>
    [JsonPropertyName("charactersToSkip")]
    public string? CharactersToSkip { get; set; }

    /// <summary>
    /// Common characters to not transform when masking. Useful to avoid removing punctuation.
    /// Possible values are: NUMERIC, ALPHA_UPPER_CASE, ALPHA_LOWER_CASE, PUNCTUATION, WHITESPACE.
    /// </summary>
    [JsonPropertyName("commonCharactersToIgnore")]
    public string? CommonCharactersToIgnore { get; set; }
}

/// <summary>
/// Partially mask a string by replacing a given number of characters with a fixed character.
/// Masking can start from the beginning or end of the string.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig
{
    [JsonPropertyName("charactersToIgnore")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfigCharactersToIgnore>? CharactersToIgnore { get; set; }

    /// <summary>is *</summary>
    [JsonPropertyName("maskingCharacter")]
    public string? MaskingCharacter { get; set; }

    /// <summary>4</summary>
    [JsonPropertyName("numberToMask")]
    public double? NumberToMask { get; set; }

    /// <summary>is false</summary>
    [JsonPropertyName("reverseOrder")]
    public bool? ReverseOrder { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
/// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
/// Currently, only string and integer values can be hashed.
/// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig
{
    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfigCryptoKey? CryptoKey { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Optional custom sensitivity for this InfoType. This only applies to data profiling.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore
{
    /// <summary>
    /// The sensitivity score applied to the resource.
    /// Possible values are: SENSITIVITY_LOW, SENSITIVITY_MODERATE, SENSITIVITY_HIGH.
    /// </summary>
    [JsonPropertyName("score")]
    public string? Score { get; set; }
}

/// <summary>
/// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
/// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
/// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
/// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Optional custom sensitivity for this InfoType. This only applies to data profiling.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sensitivityScore")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoTypeSensitivityScore? SensitivityScore { get; set; }

    /// <summary>Optional version name for this InfoType.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
/// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig
{
    /// <summary>
    /// Common alphabets.
    /// Possible values are: FFX_COMMON_NATIVE_ALPHABET_UNSPECIFIED, NUMERIC, HEXADECIMAL, UPPER_CASE_ALPHA_NUMERIC, ALPHA_NUMERIC.
    /// </summary>
    [JsonPropertyName("commonAlphabet")]
    public string? CommonAlphabet { get; set; }

    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>
    /// This is supported by mapping these to the alphanumeric characters that the FFX mode natively supports. This happens before/after encryption/decryption. Each character listed must appear only once. Number of characters must be in the range [2, 95]. This must be encoded as ASCII. The order of characters does not matter. The full list of allowed characters is:
    /// 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz ~`!@#$%^&amp;*()_-+={[}]|:;&quot; &apos; &lt;,&gt;.?/
    /// </summary>
    [JsonPropertyName("customAlphabet")]
    public string? CustomAlphabet { get; set; }

    /// <summary>The native way to select the alphabet. Must be in the range [2, 95].</summary>
    [JsonPropertyName("radix")]
    public double? Radix { get; set; }

    /// <summary>
    /// The custom infoType to annotate the surrogate with. This annotation will be applied to the surrogate by prefixing it with the name of the custom infoType followed by the number of characters comprising the surrogate. The following scheme defines the format: info_type_name(surrogate_character_count):surrogate
    /// For example, if the name of custom infoType is &apos;MY_TOKEN_INFO_TYPE&apos; and the surrogate is &apos;abc&apos;, the full replacement value will be: &apos;MY_TOKEN_INFO_TYPE(3):abc&apos;
    /// This annotation identifies the surrogate when inspecting content using the custom infoType SurrogateType. This facilitates reversal of the surrogate when it occurs in free text.
    /// In order for inspection to work properly, the name of this infoType must not occur naturally anywhere in your data; otherwise, inspection may find a surrogate that does not correspond to an actual identifier. Therefore, choose your custom infoType name carefully after considering what your data looks like. One way to select a name that has a high chance of yielding reliable detection is to include one or more unicode characters that are highly improbable to exist in your data. For example, assuming your data is entered from a regular ASCII keyboard, the symbol with the hex code point 29DD might be used like so: ⧝MY_TOKEN_TYPE
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("surrogateInfoType")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfigSurrogateInfoType? SurrogateInfoType { get; set; }
}

/// <summary>
/// Points to the field that contains the context, for example, an entity id.
/// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// KMS wrapped key.
/// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
/// For more information, see Creating a wrapped key.
/// Note: When you use Cloud KMS for cryptographic operations, charges apply.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped
{
    /// <summary>The resource name of the KMS CryptoKey to use for unwrapping.</summary>
    [JsonPropertyName("cryptoKeyName")]
    public string? CryptoKeyName { get; set; }

    /// <summary>
    /// The wrapped data crypto key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("wrappedKey")]
    public string? WrappedKey { get; set; }
}

/// <summary>
/// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped
{
    /// <summary>
    /// A 128/192/256 bit key.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

/// <summary>
/// The key used by the encryption function.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey
{
    /// <summary>
    /// KMS wrapped key.
    /// Include to use an existing data crypto key wrapped by KMS. The wrapped key must be a 128-, 192-, or 256-bit key. Authorization requires the following IAM permissions when sending a request to perform a crypto transformation using a KMS-wrapped crypto key: dlp.kms.encrypt
    /// For more information, see Creating a wrapped key.
    /// Note: When you use Cloud KMS for cryptographic operations, charges apply.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("kmsWrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyKmsWrapped? KmsWrapped { get; set; }

    /// <summary>
    /// Transient crypto key. Use this to have a random data crypto key generated. It will be discarded after the request finishes.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("transient")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyTransient? Transient { get; set; }

    /// <summary>
    /// Unwrapped crypto key. Using raw keys is prone to security risks due to accidentally leaking the key. Choose another type of key if possible.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unwrapped")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKeyUnwrapped? Unwrapped { get; set; }
}

/// <summary>
/// Shifts dates by random number of days, with option to be consistent for the same context.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig
{
    /// <summary>
    /// Points to the field that contains the context, for example, an entity id.
    /// If set, must also set cryptoKey. If set, shift will be consistent for the given context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("context")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigContext? Context { get; set; }

    /// <summary>
    /// The key used by the encryption function.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoKey")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfigCryptoKey? CryptoKey { get; set; }

    /// <summary>Range of shift in days. Negative means shift to earlier in time.</summary>
    [JsonPropertyName("lowerBoundDays")]
    public double? LowerBoundDays { get; set; }

    /// <summary>
    /// Range of shift in days. Actual shift will be selected at random within this range (inclusive ends).
    /// Negative means shift to earlier in time. Must not be more than 365250 days (1000 years) each direction.
    /// </summary>
    [JsonPropertyName("upperBoundDays")]
    public double? UpperBoundDays { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Lower bound value of buckets.
/// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
/// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBoundTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Upper bound value of buckets.
/// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
/// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBoundTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
/// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
/// This can be used on data of type: double, long.
/// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
/// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig
{
    /// <summary>
    /// Size of each bucket (except for minimum and maximum buckets).
    /// So if lower_bound = 10, upper_bound = 89, and bucketSize = 10, then the following buckets would be used: -10, 10-20, 20-30, 30-40, 40-50, 50-60, 60-70, 70-80, 80-89, 89+.
    /// Precision up to 2 decimals works.
    /// </summary>
    [JsonPropertyName("bucketSize")]
    public double? BucketSize { get; set; }

    /// <summary>
    /// Lower bound value of buckets.
    /// All values less than lower_bound are grouped together into a single bucket; for example if lower_bound = 10, then all values less than 10 are replaced with the value &quot;-10&quot;.
    /// The lower_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("lowerBound")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigLowerBound? LowerBound { get; set; }

    /// <summary>
    /// Upper bound value of buckets.
    /// All values greater than upper_bound are grouped together into a single bucket; for example if upper_bound = 89, then all values greater than 89 are replaced with the value &quot;89+&quot;.
    /// The upper_bound block must only contain one argument. See the fixed_size_bucketing_config block description for more information about choosing a data type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upperBound")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfigUpperBound? UpperBound { get; set; }
}

/// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig
{
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

/// <summary>
/// Replace each input value with a given value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig
{
    /// <summary>
    /// Replace each input value with a given value.
    /// The new_value block must only contain one argument. For example when replacing the contents of a string-type field, only string_value should be set.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("newValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfigNewValue? NewValue { get; set; }
}

/// <summary>
/// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList
{
    /// <summary>Words or phrases defining the dictionary. The dictionary must contain at least one phrase and every phrase must contain at least 2 characters that are letters or digits.</summary>
    [JsonPropertyName("words")]
    public IList<string>? Words { get; set; }
}

/// <summary>
/// Replace with a value randomly drawn (with replacement) from a dictionary.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig
{
    /// <summary>
    /// A list of words to select from for random replacement. The limits page contains details about the size limits of dictionaries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("wordList")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfigWordList? WordList { get; set; }
}

/// <summary>
/// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig
{
    /// <summary>
    /// The part of the time to keep.
    /// Possible values are: YEAR, MONTH, DAY_OF_MONTH, DAY_OF_WEEK, WEEK_OF_YEAR, HOUR_OF_DAY.
    /// </summary>
    [JsonPropertyName("partToExtract")]
    public string? PartToExtract { get; set; }
}

/// <summary>
/// Primitive transformation to apply to the infoType.
/// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation
{
    /// <summary>
    /// Generalization function that buckets values based on ranges. The ranges and replacement values are dynamically provided by the user for custom behavior, such as 1-30 -&gt; LOW 31-65 -&gt; MEDIUM 66-100 -&gt; HIGH
    /// This can be used on data of type: number, long, string, timestamp.
    /// If the provided value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("bucketingConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationBucketingConfig? BucketingConfig { get; set; }

    /// <summary>
    /// Partially mask a string by replacing a given number of characters with a fixed character.
    /// Masking can start from the beginning or end of the string.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("characterMaskConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCharacterMaskConfig? CharacterMaskConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates deterministic encryption for the given input. Outputs a base64 encoded representation of the encrypted output. Uses AES-SIV based on the RFC https://tools.ietf.org/html/rfc5297.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoDeterministicConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoDeterministicConfig? CryptoDeterministicConfig { get; set; }

    /// <summary>
    /// Pseudonymization method that generates surrogates via cryptographic hashing. Uses SHA-256. The key size must be either 32 or 64 bytes.
    /// Outputs a base64 encoded representation of the hashed output (for example, L7k0BHmF1ha5U3NfGykjro4xWi1MPVQPjhMAZbSV9mM=).
    /// Currently, only string and integer values can be hashed.
    /// See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoHashConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoHashConfig? CryptoHashConfig { get; set; }

    /// <summary>
    /// Replaces an identifier with a surrogate using Format Preserving Encryption (FPE) with the FFX mode of operation; however when used in the content.reidentify API method, it serves the opposite function by reversing the surrogate back into the original identifier. The identifier must be encoded as ASCII. For a given crypto key and context, the same identifier will be replaced with the same surrogate. Identifiers must be at least two characters long. In the case that the identifier is the empty string, it will be skipped. See https://cloud.google.com/dlp/docs/pseudonymization to learn more.
    /// Note: We recommend using CryptoDeterministicConfig for all use cases which do not require preserving the input alphabet space and size, plus warrant referential integrity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cryptoReplaceFfxFpeConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationCryptoReplaceFfxFpeConfig? CryptoReplaceFfxFpeConfig { get; set; }

    /// <summary>
    /// Shifts dates by random number of days, with option to be consistent for the same context.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateShiftConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationDateShiftConfig? DateShiftConfig { get; set; }

    /// <summary>
    /// Buckets values based on fixed size ranges. The Bucketing transformation can provide all of this functionality, but requires more configuration. This message is provided as a convenience to the user for simple bucketing strategies.
    /// The transformed value will be a hyphenated string of {lower_bound}-{upper_bound}. For example, if lower_bound = 10 and upper_bound = 20, all values that are within this bucket will be replaced with &quot;10-20&quot;.
    /// This can be used on data of type: double, long.
    /// If the bound Value type differs from the type of data being transformed, we will first attempt converting the type of the data to be transformed to match the type of the bound before comparing.
    /// See https://cloud.google.com/dlp/docs/concepts-bucketing to learn more.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fixedSizeBucketingConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationFixedSizeBucketingConfig? FixedSizeBucketingConfig { get; set; }

    /// <summary>Redact a given value. For example, if used with an InfoTypeTransformation transforming PHONE_NUMBER, and input &apos;My phone number is 206-555-0123&apos;, the output would be &apos;My phone number is &apos;.</summary>
    [JsonPropertyName("redactConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationRedactConfig? RedactConfig { get; set; }

    /// <summary>
    /// Replace each input value with a given value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceConfig? ReplaceConfig { get; set; }

    /// <summary>
    /// Replace with a value randomly drawn (with replacement) from a dictionary.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("replaceDictionaryConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationReplaceDictionaryConfig? ReplaceDictionaryConfig { get; set; }

    /// <summary>
    /// For use with Date, Timestamp, and TimeOfDay, extract or preserve a portion of the value.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timePartConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformationTimePartConfig? TimePartConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformations
{
    /// <summary>
    /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsCondition? Condition { get; set; }

    /// <summary>
    /// Input field(s) to apply the transformation to. When you have columns that reference their position within a list, omit the index from the FieldId.
    /// FieldId name matching ignores the index. For example, instead of &quot;contact.nums[0].type&quot;, use &quot;contact.nums.type&quot;.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fields")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsFields>? Fields { get; set; }

    /// <summary>
    /// Treat the contents of the field as free text, and selectively transform content that matches an InfoType.
    /// Only one of primitive_transformation or info_type_transformations must be specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>
    /// Primitive transformation to apply to the infoType.
    /// The primitive_transformation block must only contain one argument, corresponding to the type of transformation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("primitiveTransformation")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformationsPrimitiveTransformation? PrimitiveTransformation { get; set; }
}

/// <summary>
/// Field within the record this condition is evaluated against.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField
{
    /// <summary>Name of the key. This is an arbitrary string used to differentiate different keys. A unique key is generated per name: two separate TransientCryptoKey protos share the same generated key if their names are the same. When the data crypto key is generated, this name is not used in any way (repeating the api call will result in a different key being generated).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Represents a whole or partial calendar date.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue
{
    /// <summary>
    /// Day of month. Must be from 1 to 31 and valid for the year and month, or 0 if specifying a
    /// year by itself or a year and month where the day is not significant.
    /// </summary>
    [JsonPropertyName("day")]
    public double? Day { get; set; }

    /// <summary>Month of year. Must be from 1 to 12, or 0 if specifying a year without a month and day.</summary>
    [JsonPropertyName("month")]
    public double? Month { get; set; }

    /// <summary>Year of date. Must be from 1 to 9999, or 0 if specifying a date without a year.</summary>
    [JsonPropertyName("year")]
    public double? Year { get; set; }
}

/// <summary>
/// Represents a time of day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue
{
    /// <summary>Hours of day in 24 hour format. Should be from 0 to 23.</summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>Minutes of hour of day. Must be from 0 to 59.</summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.</summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>Seconds of minutes of the time. Must normally be from 0 to 59.</summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Value to compare against.
/// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
/// This argument is mandatory, except for conditions using the EXISTS operator.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue
{
    /// <summary>A boolean value.</summary>
    [JsonPropertyName("booleanValue")]
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Represents a whole or partial calendar date.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dateValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueDateValue? DateValue { get; set; }

    /// <summary>
    /// Represents a day of the week.
    /// Possible values are: MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY.
    /// </summary>
    [JsonPropertyName("dayOfWeekValue")]
    public string? DayOfWeekValue { get; set; }

    /// <summary>A float value.</summary>
    [JsonPropertyName("floatValue")]
    public double? FloatValue { get; set; }

    /// <summary>An integer value (int64 format)</summary>
    [JsonPropertyName("integerValue")]
    public string? IntegerValue { get; set; }

    /// <summary>A string value.</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }

    /// <summary>
    /// Represents a time of day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("timeValue")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValueTimeValue? TimeValue { get; set; }

    /// <summary>A timestamp in RFC3339 UTC &quot;Zulu&quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &quot;2014-10-02T15:01:23Z&quot; and &quot;2014-10-02T15:01:23.045123456Z&quot;.</summary>
    [JsonPropertyName("timestampValue")]
    public string? TimestampValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions
{
    /// <summary>
    /// Field within the record this condition is evaluated against.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("field")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsField? Field { get; set; }

    /// <summary>
    /// Operator used to compare the field or infoType to the value.
    /// Possible values are: EQUAL_TO, NOT_EQUAL_TO, GREATER_THAN, LESS_THAN, GREATER_THAN_OR_EQUALS, LESS_THAN_OR_EQUALS, EXISTS.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Value to compare against.
    /// The value block must only contain one argument. For example when a condition is evaluated against a string-type field, only string_value should be set.
    /// This argument is mandatory, except for conditions using the EXISTS operator.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("value")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditionsValue? Value { get; set; }
}

/// <summary>
/// Conditions to apply to the expression.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditionsConditions>? Conditions { get; set; }
}

/// <summary>
/// An expression, consisting of an operator and conditions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions
{
    /// <summary>
    /// Conditions to apply to the expression.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressionsConditions? Conditions { get; set; }

    /// <summary>
    /// The operator to apply to the result of conditions. Default and currently only supported value is AND.
    /// Default value is AND.
    /// Possible values are: AND.
    /// </summary>
    [JsonPropertyName("logicalOperator")]
    public string? LogicalOperator { get; set; }
}

/// <summary>
/// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition
{
    /// <summary>
    /// An expression, consisting of an operator and conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("expressions")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsConditionExpressions? Expressions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressions
{
    /// <summary>
    /// A condition that when it evaluates to true will result in the record being evaluated to be suppressed from the transformed content.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressionsCondition? Condition { get; set; }
}

/// <summary>
/// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformations
{
    /// <summary>
    /// Transform the record by applying various field transformations.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("fieldTransformations")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsFieldTransformations>? FieldTransformations { get; set; }

    /// <summary>
    /// Configuration defining which records get suppressed entirely. Records that match any suppression rule are omitted from the output.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recordSuppressions")]
    public IList<V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformationsRecordSuppressions>? RecordSuppressions { get; set; }
}

/// <summary>
/// Configuration of the deidentify template
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfig
{
    /// <summary>
    /// Treat the dataset as an image and redact.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageTransformations")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigImageTransformations? ImageTransformations { get; set; }

    /// <summary>
    /// Treat the dataset as free-form text and apply the same free text transformation everywhere
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("infoTypeTransformations")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigInfoTypeTransformations? InfoTypeTransformations { get; set; }

    /// <summary>
    /// Treat the dataset as structured. Transformations can be applied to specific locations within structured datasets, such as transforming a column within a table.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("recordTransformations")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfigRecordTransformations? RecordTransformations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusAtProvider
{
    /// <summary>The creation timestamp of an deidentifyTemplate. Set by the server.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Configuration of the deidentify template
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("deidentifyConfig")]
    public V1beta2DeidentifyTemplateStatusAtProviderDeidentifyConfig? DeidentifyConfig { get; set; }

    /// <summary>A description of the template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>User set display name of the template.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format {{parent}}/deidentifyTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource name of the template. Set by the server.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The parent of the template in any of the following formats:</summary>
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    /// <summary>
    /// The template id can contain uppercase and lowercase letters, numbers, and hyphens;
    /// that is, it must match the regular expression: [a-zA-Z\d-_]+. The maximum length is
    /// 100 characters. Can be empty to allow the system to generate one.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    /// <summary>The last update timestamp of an deidentifyTemplate. Set by the server.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatusConditions
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

/// <summary>DeidentifyTemplateStatus defines the observed state of DeidentifyTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeidentifyTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DeidentifyTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeidentifyTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeidentifyTemplate is the Schema for the DeidentifyTemplates API. Allows creation of templates to de-identify content.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DeidentifyTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DeidentifyTemplateSpec>, IStatus<V1beta2DeidentifyTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DeidentifyTemplate";
    public const string KubeGroup = "datalossprevention.gcp.upbound.io";
    public const string KubePluralName = "deidentifytemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datalossprevention.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeidentifyTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeidentifyTemplateSpec defines the desired state of DeidentifyTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DeidentifyTemplateSpec Spec { get; set; }

    /// <summary>DeidentifyTemplateStatus defines the observed state of DeidentifyTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2DeidentifyTemplateStatus? Status { get; set; }
}