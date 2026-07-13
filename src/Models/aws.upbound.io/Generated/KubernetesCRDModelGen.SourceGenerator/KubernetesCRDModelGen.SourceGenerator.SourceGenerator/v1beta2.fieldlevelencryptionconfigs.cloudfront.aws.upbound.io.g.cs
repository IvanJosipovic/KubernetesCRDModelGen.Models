#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfront.aws.upbound.io;
/// <summary>FieldLevelEncryptionConfig is the Schema for the FieldLevelEncryptionConfigs API. Provides a CloudFront Field-level Encryption Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FieldLevelEncryptionConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta2FieldLevelEncryptionConfig>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FieldLevelEncryptionConfigList";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "fieldlevelencryptionconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FieldLevelEncryptionConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2FieldLevelEncryptionConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2FieldLevelEncryptionConfig> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecDeletionPolicyEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfilesItems
{
    /// <summary>he content type for a field-level encryption content type-profile mapping. Valid value is application/x-www-form-urlencoded.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The format for a field-level encryption content type-profile mapping. Valid value is URLEncoded.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfiles
{
    [JsonPropertyName("items")]
    public IList<V1beta2FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfilesItems>? Items { get; set; }
}

/// <summary>Content Type Profile Config specifies when to forward content if a content type isn&apos;t recognized and profiles to use as by default in a request if a query argument doesn&apos;t specify a profile to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfig
{
    /// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
    [JsonPropertyName("contentTypeProfiles")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfigContentTypeProfiles? ContentTypeProfiles { get; set; }

    /// <summary>specifies what to do when an unknown content type is provided for the profile. If true, content is forwarded without being encrypted when the content type is unknown. If false (the default), an error is returned when the content type is unknown.</summary>
    [JsonPropertyName("forwardWhenContentTypeIsUnknown")]
    public bool? ForwardWhenContentTypeIsUnknown { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolutionEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolveEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolveEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector
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
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItems
{
    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }

    /// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdRef")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef? ProfileIdRef { get; set; }

    /// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdSelector")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector? ProfileIdSelector { get; set; }

    /// <summary>Query argument for field-level encryption query argument-profile mapping.</summary>
    [JsonPropertyName("queryArg")]
    public string? QueryArg { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfiles
{
    [JsonPropertyName("items")]
    public IList<V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfilesItems>? Items { get; set; }
}

/// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn&apos;t found and the profile that can be provided as a query argument in a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfig
{
    /// <summary>Flag to set if you want a request to be forwarded to the origin even if the profile specified by the field-level encryption query argument, fle-profile, is unknown.</summary>
    [JsonPropertyName("forwardWhenQueryArgProfileIsUnknown")]
    public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

    /// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
    [JsonPropertyName("queryArgProfiles")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecForProvider
{
    /// <summary>An optional comment about the Field Level Encryption Config.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Content Type Profile Config specifies when to forward content if a content type isn&apos;t recognized and profiles to use as by default in a request if a query argument doesn&apos;t specify a profile to use.</summary>
    [JsonPropertyName("contentTypeProfileConfig")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderContentTypeProfileConfig? ContentTypeProfileConfig { get; set; }

    /// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn&apos;t found and the profile that can be provided as a query argument in a request.</summary>
    [JsonPropertyName("queryArgProfileConfig")]
    public V1beta2FieldLevelEncryptionConfigSpecForProviderQueryArgProfileConfig? QueryArgProfileConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfilesItems
{
    /// <summary>he content type for a field-level encryption content type-profile mapping. Valid value is application/x-www-form-urlencoded.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The format for a field-level encryption content type-profile mapping. Valid value is URLEncoded.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfiles
{
    [JsonPropertyName("items")]
    public IList<V1beta2FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfilesItems>? Items { get; set; }
}

/// <summary>Content Type Profile Config specifies when to forward content if a content type isn&apos;t recognized and profiles to use as by default in a request if a query argument doesn&apos;t specify a profile to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfig
{
    /// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
    [JsonPropertyName("contentTypeProfiles")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfigContentTypeProfiles? ContentTypeProfiles { get; set; }

    /// <summary>specifies what to do when an unknown content type is provided for the profile. If true, content is forwarded without being encrypted when the content type is unknown. If false (the default), an error is returned when the content type is unknown.</summary>
    [JsonPropertyName("forwardWhenContentTypeIsUnknown")]
    public bool? ForwardWhenContentTypeIsUnknown { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolutionEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolveEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolutionEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolveEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector
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
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItems
{
    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }

    /// <summary>Reference to a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdRef")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdRef? ProfileIdRef { get; set; }

    /// <summary>Selector for a FieldLevelEncryptionProfile in cloudfront to populate profileId.</summary>
    [JsonPropertyName("profileIdSelector")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItemsProfileIdSelector? ProfileIdSelector { get; set; }

    /// <summary>Query argument for field-level encryption query argument-profile mapping.</summary>
    [JsonPropertyName("queryArg")]
    public string? QueryArg { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfiles
{
    [JsonPropertyName("items")]
    public IList<V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfilesItems>? Items { get; set; }
}

/// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn&apos;t found and the profile that can be provided as a query argument in a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfig
{
    /// <summary>Flag to set if you want a request to be forwarded to the origin even if the profile specified by the field-level encryption query argument, fle-profile, is unknown.</summary>
    [JsonPropertyName("forwardWhenQueryArgProfileIsUnknown")]
    public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

    /// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
    [JsonPropertyName("queryArgProfiles")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles { get; set; }
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
public partial class V1beta2FieldLevelEncryptionConfigSpecInitProvider
{
    /// <summary>An optional comment about the Field Level Encryption Config.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Content Type Profile Config specifies when to forward content if a content type isn&apos;t recognized and profiles to use as by default in a request if a query argument doesn&apos;t specify a profile to use.</summary>
    [JsonPropertyName("contentTypeProfileConfig")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderContentTypeProfileConfig? ContentTypeProfileConfig { get; set; }

    /// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn&apos;t found and the profile that can be provided as a query argument in a request.</summary>
    [JsonPropertyName("queryArgProfileConfig")]
    public V1beta2FieldLevelEncryptionConfigSpecInitProviderQueryArgProfileConfig? QueryArgProfileConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecManagementPoliciesEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FieldLevelEncryptionConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FieldLevelEncryptionConfigSpec defines the desired state of FieldLevelEncryptionConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigSpec
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
    public V1beta2FieldLevelEncryptionConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FieldLevelEncryptionConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta2FieldLevelEncryptionConfigSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FieldLevelEncryptionConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FieldLevelEncryptionConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FieldLevelEncryptionConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfilesItems
{
    /// <summary>he content type for a field-level encryption content type-profile mapping. Valid value is application/x-www-form-urlencoded.</summary>
    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>The format for a field-level encryption content type-profile mapping. Valid value is URLEncoded.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfiles
{
    [JsonPropertyName("items")]
    public IList<V1beta2FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfilesItems>? Items { get; set; }
}

/// <summary>Content Type Profile Config specifies when to forward content if a content type isn&apos;t recognized and profiles to use as by default in a request if a query argument doesn&apos;t specify a profile to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfig
{
    /// <summary>Object that contains an attribute items that contains the list of configurations for a field-level encryption content type-profile. See Content Type Profile.</summary>
    [JsonPropertyName("contentTypeProfiles")]
    public V1beta2FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfigContentTypeProfiles? ContentTypeProfiles { get; set; }

    /// <summary>specifies what to do when an unknown content type is provided for the profile. If true, content is forwarded without being encrypted when the content type is unknown. If false (the default), an error is returned when the content type is unknown.</summary>
    [JsonPropertyName("forwardWhenContentTypeIsUnknown")]
    public bool? ForwardWhenContentTypeIsUnknown { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfilesItems
{
    /// <summary>The profile ID for a field-level encryption content type-profile mapping.</summary>
    [JsonPropertyName("profileId")]
    public string? ProfileId { get; set; }

    /// <summary>Query argument for field-level encryption query argument-profile mapping.</summary>
    [JsonPropertyName("queryArg")]
    public string? QueryArg { get; set; }
}

/// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfiles
{
    [JsonPropertyName("items")]
    public IList<V1beta2FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfilesItems>? Items { get; set; }
}

/// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn&apos;t found and the profile that can be provided as a query argument in a request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfig
{
    /// <summary>Flag to set if you want a request to be forwarded to the origin even if the profile specified by the field-level encryption query argument, fle-profile, is unknown.</summary>
    [JsonPropertyName("forwardWhenQueryArgProfileIsUnknown")]
    public bool? ForwardWhenQueryArgProfileIsUnknown { get; set; }

    /// <summary>Object that contains an attribute items that contains the list ofrofiles specified for query argument-profile mapping for field-level encryption. see Query Arg Profile.</summary>
    [JsonPropertyName("queryArgProfiles")]
    public V1beta2FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusAtProvider
{
    /// <summary>The Field Level Encryption Config ARN.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Internal value used by CloudFront to allow future updates to the Field Level Encryption Config.</summary>
    [JsonPropertyName("callerReference")]
    public string? CallerReference { get; set; }

    /// <summary>An optional comment about the Field Level Encryption Config.</summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>Content Type Profile Config specifies when to forward content if a content type isn&apos;t recognized and profiles to use as by default in a request if a query argument doesn&apos;t specify a profile to use.</summary>
    [JsonPropertyName("contentTypeProfileConfig")]
    public V1beta2FieldLevelEncryptionConfigStatusAtProviderContentTypeProfileConfig? ContentTypeProfileConfig { get; set; }

    /// <summary>The current version of the Field Level Encryption Config. For example: E2QWRUHAPOMQZL.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>The identifier for the Field Level Encryption Config. For example: K3D5EWEUDCCXON.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Query Arg Profile Config that specifies when to forward content if a profile isn&apos;t found and the profile that can be provided as a query argument in a request.</summary>
    [JsonPropertyName("queryArgProfileConfig")]
    public V1beta2FieldLevelEncryptionConfigStatusAtProviderQueryArgProfileConfig? QueryArgProfileConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatusConditions
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

/// <summary>FieldLevelEncryptionConfigStatus defines the observed state of FieldLevelEncryptionConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FieldLevelEncryptionConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FieldLevelEncryptionConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FieldLevelEncryptionConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>FieldLevelEncryptionConfig is the Schema for the FieldLevelEncryptionConfigs API. Provides a CloudFront Field-level Encryption Config resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FieldLevelEncryptionConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FieldLevelEncryptionConfigSpec>, IStatus<V1beta2FieldLevelEncryptionConfigStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FieldLevelEncryptionConfig";
    public const string KubeGroup = "cloudfront.aws.upbound.io";
    public const string KubePluralName = "fieldlevelencryptionconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfront.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FieldLevelEncryptionConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FieldLevelEncryptionConfigSpec defines the desired state of FieldLevelEncryptionConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FieldLevelEncryptionConfigSpec Spec { get; set; }

    /// <summary>FieldLevelEncryptionConfigStatus defines the observed state of FieldLevelEncryptionConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta2FieldLevelEncryptionConfigStatus? Status { get; set; }
}