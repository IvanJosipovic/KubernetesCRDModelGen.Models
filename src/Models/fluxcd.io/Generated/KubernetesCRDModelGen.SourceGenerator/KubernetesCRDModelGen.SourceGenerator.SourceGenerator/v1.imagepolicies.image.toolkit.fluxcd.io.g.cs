#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.image.toolkit.fluxcd.io;
/// <summary>ImagePolicy is the Schema for the imagepolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImagePolicyList : IKubernetesObject<V1ListMeta>, IItems<V1ImagePolicy>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImagePolicyList";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imagepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "image.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImagePolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1ImagePolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1ImagePolicy> Items { get; set; }
}

/// <summary>
/// DigestReflectionPolicy governs the setting of the `.status.latestRef.digest` field.
/// 
/// Never: The digest field will always be set to the empty string.
/// 
/// IfNotPresent: The digest field will be set to the digest of the elected
/// latest image if the field is empty and the image did not change.
/// 
/// Always: The digest field will always be set to the digest of the elected
/// latest image.
/// 
/// Default: Never.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImagePolicySpecDigestReflectionPolicyEnum>))]
public enum V1ImagePolicySpecDigestReflectionPolicyEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent,
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never
}

/// <summary>
/// FilterTags enables filtering for only a subset of tags based on a set of
/// rules. If no rules are provided, all the tags from the repository will be
/// ordered and compared.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpecFilterTags
{
    /// <summary>
    /// Extract allows a capture group to be extracted from the specified regular
    /// expression pattern, useful before tag evaluation.
    /// </summary>
    [JsonPropertyName("extract")]
    public string? Extract { get; set; }

    /// <summary>
    /// Pattern specifies a regular expression pattern used to filter for image
    /// tags.
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>
/// ImageRepositoryRef points at the object specifying the image
/// being scanned
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpecImageRepositoryRef
{
    /// <summary>Name of the referent.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referent, when not specified it acts as LocalObjectReference.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// Order specifies the sorting order of the tags. Given the letters of the
/// alphabet as tags, ascending order would select Z, and descending order
/// would select A.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImagePolicySpecPolicyAlphabeticalOrderEnum>))]
public enum V1ImagePolicySpecPolicyAlphabeticalOrderEnum
{
    [EnumMember(Value = "asc"), JsonStringEnumMemberName("asc")]
    Asc,
    [EnumMember(Value = "desc"), JsonStringEnumMemberName("desc")]
    Desc
}

/// <summary>Alphabetical set of rules to use for alphabetical ordering of the tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpecPolicyAlphabetical
{
    /// <summary>
    /// Order specifies the sorting order of the tags. Given the letters of the
    /// alphabet as tags, ascending order would select Z, and descending order
    /// would select A.
    /// </summary>
    [JsonPropertyName("order")]
    public V1ImagePolicySpecPolicyAlphabeticalOrderEnum? Order { get; set; }
}

/// <summary>
/// Order specifies the sorting order of the tags. Given the integer values
/// from 0 to 9 as tags, ascending order would select 9, and descending order
/// would select 0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImagePolicySpecPolicyNumericalOrderEnum>))]
public enum V1ImagePolicySpecPolicyNumericalOrderEnum
{
    [EnumMember(Value = "asc"), JsonStringEnumMemberName("asc")]
    Asc,
    [EnumMember(Value = "desc"), JsonStringEnumMemberName("desc")]
    Desc
}

/// <summary>Numerical set of rules to use for numerical ordering of the tags.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpecPolicyNumerical
{
    /// <summary>
    /// Order specifies the sorting order of the tags. Given the integer values
    /// from 0 to 9 as tags, ascending order would select 9, and descending order
    /// would select 0.
    /// </summary>
    [JsonPropertyName("order")]
    public V1ImagePolicySpecPolicyNumericalOrderEnum? Order { get; set; }
}

/// <summary>
/// SemVer gives a semantic version range to check against the tags
/// available.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpecPolicySemver
{
    /// <summary>
    /// Range gives a semver range for the image tag; the highest
    /// version within the range that&apos;s a tag yields the latest image.
    /// </summary>
    [JsonPropertyName("range")]
    public required string Range { get; set; }
}

/// <summary>
/// Policy gives the particulars of the policy to be followed in
/// selecting the most recent image
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpecPolicy
{
    /// <summary>Alphabetical set of rules to use for alphabetical ordering of the tags.</summary>
    [JsonPropertyName("alphabetical")]
    public V1ImagePolicySpecPolicyAlphabetical? Alphabetical { get; set; }

    /// <summary>Numerical set of rules to use for numerical ordering of the tags.</summary>
    [JsonPropertyName("numerical")]
    public V1ImagePolicySpecPolicyNumerical? Numerical { get; set; }

    /// <summary>
    /// SemVer gives a semantic version range to check against the tags
    /// available.
    /// </summary>
    [JsonPropertyName("semver")]
    public V1ImagePolicySpecPolicySemver? Semver { get; set; }
}

/// <summary>
/// ImagePolicySpec defines the parameters for calculating the
/// ImagePolicy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicySpec
{
    /// <summary>
    /// DigestReflectionPolicy governs the setting of the `.status.latestRef.digest` field.
    /// 
    /// Never: The digest field will always be set to the empty string.
    /// 
    /// IfNotPresent: The digest field will be set to the digest of the elected
    /// latest image if the field is empty and the image did not change.
    /// 
    /// Always: The digest field will always be set to the digest of the elected
    /// latest image.
    /// 
    /// Default: Never.
    /// </summary>
    [JsonPropertyName("digestReflectionPolicy")]
    public V1ImagePolicySpecDigestReflectionPolicyEnum? DigestReflectionPolicy { get; set; }

    /// <summary>
    /// FilterTags enables filtering for only a subset of tags based on a set of
    /// rules. If no rules are provided, all the tags from the repository will be
    /// ordered and compared.
    /// </summary>
    [JsonPropertyName("filterTags")]
    public V1ImagePolicySpecFilterTags? FilterTags { get; set; }

    /// <summary>
    /// ImageRepositoryRef points at the object specifying the image
    /// being scanned
    /// </summary>
    [JsonPropertyName("imageRepositoryRef")]
    public required V1ImagePolicySpecImageRepositoryRef ImageRepositoryRef { get; set; }

    /// <summary>
    /// Interval is the length of time to wait between
    /// refreshing the digest of the latest tag when the
    /// reflection policy is set to &quot;Always&quot;.
    /// 
    /// Defaults to 10m.
    /// </summary>
    [JsonPropertyName("interval")]
    public string? Interval { get; set; }

    /// <summary>
    /// Policy gives the particulars of the policy to be followed in
    /// selecting the most recent image
    /// </summary>
    [JsonPropertyName("policy")]
    public required V1ImagePolicySpecPolicy Policy { get; set; }

    /// <summary>
    /// This flag tells the controller to suspend subsequent policy reconciliations.
    /// It does not apply to already started reconciliations. Defaults to false.
    /// </summary>
    [JsonPropertyName("suspend")]
    public bool? Suspend { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1ImagePolicyStatusConditionsStatusEnum>))]
public enum V1ImagePolicyStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicyStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1ImagePolicyStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// LatestRef gives the first in the list of images scanned by
/// the image repository, when filtered and ordered according
/// to the policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicyStatusLatestRef
{
    /// <summary>Digest is the image&apos;s digest.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name is the bare image&apos;s name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tag is the image&apos;s tag.</summary>
    [JsonPropertyName("tag")]
    public required string Tag { get; set; }
}

/// <summary>
/// ObservedPreviousRef is the observed previous LatestRef. It is used
/// to keep track of the previous and current images.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicyStatusObservedPreviousRef
{
    /// <summary>Digest is the image&apos;s digest.</summary>
    [JsonPropertyName("digest")]
    public string? Digest { get; set; }

    /// <summary>Name is the bare image&apos;s name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Tag is the image&apos;s tag.</summary>
    [JsonPropertyName("tag")]
    public required string Tag { get; set; }
}

/// <summary>ImagePolicyStatus defines the observed state of ImagePolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1ImagePolicyStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1ImagePolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile request value, so a change of the annotation value
    /// can be detected.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// LatestRef gives the first in the list of images scanned by
    /// the image repository, when filtered and ordered according
    /// to the policy.
    /// </summary>
    [JsonPropertyName("latestRef")]
    public V1ImagePolicyStatusLatestRef? LatestRef { get; set; }

    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// ObservedPreviousRef is the observed previous LatestRef. It is used
    /// to keep track of the previous and current images.
    /// </summary>
    [JsonPropertyName("observedPreviousRef")]
    public V1ImagePolicyStatusObservedPreviousRef? ObservedPreviousRef { get; set; }
}

/// <summary>ImagePolicy is the Schema for the imagepolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1ImagePolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1ImagePolicySpec?>, IStatus<V1ImagePolicyStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "ImagePolicy";
    public const string KubeGroup = "image.toolkit.fluxcd.io";
    public const string KubePluralName = "imagepolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "image.toolkit.fluxcd.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImagePolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ImagePolicySpec defines the parameters for calculating the
    /// ImagePolicy.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1ImagePolicySpec? Spec { get; set; }

    /// <summary>ImagePolicyStatus defines the observed state of ImagePolicy</summary>
    [JsonPropertyName("status")]
    public V1ImagePolicyStatus? Status { get; set; }
}