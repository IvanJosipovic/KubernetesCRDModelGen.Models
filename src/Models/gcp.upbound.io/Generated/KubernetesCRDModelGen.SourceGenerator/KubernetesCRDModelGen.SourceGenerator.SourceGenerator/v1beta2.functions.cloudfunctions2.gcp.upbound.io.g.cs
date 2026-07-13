#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudfunctions2.gcp.upbound.io;
/// <summary>Function is the Schema for the Functions API. A Cloud Function that contains user computation executed in response to an event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2FunctionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Function>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "FunctionList";
    public const string KubeGroup = "cloudfunctions2.gcp.upbound.io";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfunctions2.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FunctionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Function objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Function> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecDeletionPolicyEnum>))]
public enum V1beta2FunctionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Security patches are applied automatically to the runtime without requiring
/// the function to be redeployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigAutomaticUpdatePolicy
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate dockerRepository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate dockerRepository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelector
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
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Security patches are only applied when a function is redeployed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigOnDeployUpdatePolicy
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelector
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
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If provided, get the source from this location in a Cloud Source Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceRepoSource
{
    /// <summary>Regex matching branches to build.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Only trigger a build if the revision regex does
    /// NOT match the revision regex.
    /// </summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelector
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
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketObject in storage to populate object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketObject in storage to populate object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelector
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
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If provided, get the source from this location in Google Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceBucketSelector? BucketSelector { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object. If the generation
    /// is omitted, the latest generation will be used.
    /// </summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Reference to a BucketObject in storage to populate object.</summary>
    [JsonPropertyName("objectRef")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectRef? ObjectRef { get; set; }

    /// <summary>Selector for a BucketObject in storage to populate object.</summary>
    [JsonPropertyName("objectSelector")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSourceObjectSelector? ObjectSelector { get; set; }
}

/// <summary>
/// The location of the function source code.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigSource
{
    /// <summary>
    /// If provided, get the source from this location in a Cloud Source Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repoSource")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceRepoSource? RepoSource { get; set; }

    /// <summary>
    /// If provided, get the source from this location in Google Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageSource")]
    public V1beta2FunctionSpecForProviderBuildConfigSourceStorageSource? StorageSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WorkerPool in cloudbuild to populate workerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WorkerPool in cloudbuild to populate workerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelector
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
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Describes the Build step of the function that builds a container
/// from the given source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderBuildConfig
{
    /// <summary>
    /// Security patches are applied automatically to the runtime without requiring
    /// the function to be redeployed.
    /// </summary>
    [JsonPropertyName("automaticUpdatePolicy")]
    public V1beta2FunctionSpecForProviderBuildConfigAutomaticUpdatePolicy? AutomaticUpdatePolicy { get; set; }

    /// <summary>User managed repository created in Artifact Registry optionally with a customer managed encryption key.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate dockerRepository.</summary>
    [JsonPropertyName("dockerRepositoryRef")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositoryRef? DockerRepositoryRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate dockerRepository.</summary>
    [JsonPropertyName("dockerRepositorySelector")]
    public V1beta2FunctionSpecForProviderBuildConfigDockerRepositorySelector? DockerRepositorySelector { get; set; }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &quot;function&quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>User-provided build-time environment variables for the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("onDeployUpdatePolicy")]
    public V1beta2FunctionSpecForProviderBuildConfigOnDeployUpdatePolicy? OnDeployUpdatePolicy { get; set; }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The fully-qualified name of the service account to be used for building the container.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2FunctionSpecForProviderBuildConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// The location of the function source code.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2FunctionSpecForProviderBuildConfigSource? Source { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }

    /// <summary>Reference to a WorkerPool in cloudbuild to populate workerPool.</summary>
    [JsonPropertyName("workerPoolRef")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolRef? WorkerPoolRef { get; set; }

    /// <summary>Selector for a WorkerPool in cloudbuild to populate workerPool.</summary>
    [JsonPropertyName("workerPoolSelector")]
    public V1beta2FunctionSpecForProviderBuildConfigWorkerPoolSelector? WorkerPoolSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelector
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
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerEventFilters
{
    /// <summary>
    /// &apos;Required. The name of a CloudEvents attribute.
    /// Currently, only a subset of attributes are supported for filtering. Use the gcloud eventarc providers describe command to learn more about events and their attributes.
    /// Do not filter for the &apos;type&apos; attribute here, as this is already achieved by the resource&apos;s event_type attribute.
    /// </summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of
    /// the filter. If not specified, only events that have an exact key-value
    /// pair specified in the filter are matched.
    /// The only allowed value is match-path-pattern.
    /// See documentation on path patterns here&apos;
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Required. The value for the attribute.
    /// If the operator field is set as match-path-pattern, this value can be a path pattern instead of an exact value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to a Bucket in storage to populate value.</summary>
    [JsonPropertyName("valueRef")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueRef? ValueRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate value.</summary>
    [JsonPropertyName("valueSelector")]
    public V1beta2FunctionSpecForProviderEventTriggerEventFiltersValueSelector? ValueSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelector
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
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelector
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
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// An Eventarc trigger managed by Google Cloud Functions that fires events in
/// response to a condition in another service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderEventTrigger
{
    /// <summary>
    /// Criteria used to filter events.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventFilters")]
    public IList<V1beta2FunctionSpecForProviderEventTriggerEventFilters>? EventFilters { get; set; }

    /// <summary>Required. The type of event to observe.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicRef")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicRef? PubsubTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicSelector")]
    public V1beta2FunctionSpecForProviderEventTriggerPubsubTopicSelector? PubsubTopicSelector { get; set; }

    /// <summary>
    /// Describes the retry policy in case of function&apos;s execution failure.
    /// Retried execution is charged as any other execution.
    /// Possible values are: RETRY_POLICY_UNSPECIFIED, RETRY_POLICY_DO_NOT_RETRY, RETRY_POLICY_RETRY.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public string? RetryPolicy { get; set; }

    /// <summary>
    /// Optional. The email of the trigger&apos;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2FunctionSpecForProviderEventTriggerServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    [JsonPropertyName("triggerRegion")]
    public string? TriggerRegion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelector
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
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariablesSecretSelector? SecretSelector { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelector
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
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mountPath as &apos;/etc/secrets&apos; and path as secret_foo would mount the secret value file at /etc/secrets/secret_foo.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mountPath as /etc/secrets would mount the secret value files under the /etc/secrets directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount path: /etc/secrets</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta2FunctionSpecForProviderServiceConfigSecretVolumesSecretSelector? SecretSelector { get; set; }

    /// <summary>
    /// List of secret versions to mount for this secret. If empty, the latest version of the secret will be made available in a file named after the secret under the mount point.&apos;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("versions")]
    public IList<V1beta2FunctionSpecForProviderServiceConfigSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelector
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
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Describes the Service being deployed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProviderServiceConfig
{
    /// <summary>Whether 100% of traffic is routed to the latest revision. Defaults to true.</summary>
    [JsonPropertyName("allTrafficOnLatestRevision")]
    public bool? AllTrafficOnLatestRevision { get; set; }

    /// <summary>The number of CPUs used in a single container instance. Default value is calculated from available memory.</summary>
    [JsonPropertyName("availableCpu")]
    public string? AvailableCpu { get; set; }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    [JsonPropertyName("availableMemory")]
    public string? AvailableMemory { get; set; }

    /// <summary>The binary authorization policy to be checked when deploying the Cloud Run service.</summary>
    [JsonPropertyName("binaryAuthorizationPolicy")]
    public string? BinaryAuthorizationPolicy { get; set; }

    /// <summary>Environment variables that shall be available during function execution.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// Available ingress settings. Defaults to &quot;ALLOW_ALL&quot; if unspecified.
    /// Default value is ALLOW_ALL.
    /// Possible values are: ALLOW_ALL, ALLOW_INTERNAL_ONLY, ALLOW_INTERNAL_AND_GCLB.
    /// </summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public double? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>
    /// Secret environment variables configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1beta2FunctionSpecForProviderServiceConfigSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>
    /// Secret volumes configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1beta2FunctionSpecForProviderServiceConfigSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>Name of the service associated with a Function.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The email of the service account for this function.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2FunctionSpecForProviderServiceConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The Serverless VPC Access connector that this cloud function can connect to.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>
    /// Available egress settings.
    /// Possible values are: VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED, PRIVATE_RANGES_ONLY, ALL_TRAFFIC.
    /// </summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecForProvider
{
    /// <summary>
    /// Describes the Build step of the function that builds a container
    /// from the given source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buildConfig")]
    public V1beta2FunctionSpecForProviderBuildConfig? BuildConfig { get; set; }

    /// <summary>User-provided description of a function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// An Eventarc trigger managed by Google Cloud Functions that fires events in
    /// response to a condition in another service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta2FunctionSpecForProviderEventTrigger? EventTrigger { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs associated with this Cloud Function.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this cloud function.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Describes the Service being deployed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceConfig")]
    public V1beta2FunctionSpecForProviderServiceConfig? ServiceConfig { get; set; }
}

/// <summary>
/// Security patches are applied automatically to the runtime without requiring
/// the function to be redeployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigAutomaticUpdatePolicy
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate dockerRepository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate dockerRepository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelector
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
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Security patches are only applied when a function is redeployed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigOnDeployUpdatePolicy
{
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelector
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
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If provided, get the source from this location in a Cloud Source Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceRepoSource
{
    /// <summary>Regex matching branches to build.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Only trigger a build if the revision regex does
    /// NOT match the revision regex.
    /// </summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelector
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
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a BucketObject in storage to populate object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a BucketObject in storage to populate object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelector
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
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// If provided, get the source from this location in Google Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>Reference to a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketRef? BucketRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate bucket.</summary>
    [JsonPropertyName("bucketSelector")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceBucketSelector? BucketSelector { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object. If the generation
    /// is omitted, the latest generation will be used.
    /// </summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    /// <summary>Reference to a BucketObject in storage to populate object.</summary>
    [JsonPropertyName("objectRef")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectRef? ObjectRef { get; set; }

    /// <summary>Selector for a BucketObject in storage to populate object.</summary>
    [JsonPropertyName("objectSelector")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSourceObjectSelector? ObjectSelector { get; set; }
}

/// <summary>
/// The location of the function source code.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigSource
{
    /// <summary>
    /// If provided, get the source from this location in a Cloud Source Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repoSource")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceRepoSource? RepoSource { get; set; }

    /// <summary>
    /// If provided, get the source from this location in Google Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageSource")]
    public V1beta2FunctionSpecInitProviderBuildConfigSourceStorageSource? StorageSource { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WorkerPool in cloudbuild to populate workerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WorkerPool in cloudbuild to populate workerPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelector
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
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Describes the Build step of the function that builds a container
/// from the given source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderBuildConfig
{
    /// <summary>
    /// Security patches are applied automatically to the runtime without requiring
    /// the function to be redeployed.
    /// </summary>
    [JsonPropertyName("automaticUpdatePolicy")]
    public V1beta2FunctionSpecInitProviderBuildConfigAutomaticUpdatePolicy? AutomaticUpdatePolicy { get; set; }

    /// <summary>User managed repository created in Artifact Registry optionally with a customer managed encryption key.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate dockerRepository.</summary>
    [JsonPropertyName("dockerRepositoryRef")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositoryRef? DockerRepositoryRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate dockerRepository.</summary>
    [JsonPropertyName("dockerRepositorySelector")]
    public V1beta2FunctionSpecInitProviderBuildConfigDockerRepositorySelector? DockerRepositorySelector { get; set; }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &quot;function&quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>User-provided build-time environment variables for the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("onDeployUpdatePolicy")]
    public V1beta2FunctionSpecInitProviderBuildConfigOnDeployUpdatePolicy? OnDeployUpdatePolicy { get; set; }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The fully-qualified name of the service account to be used for building the container.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccount.</summary>
    [JsonPropertyName("serviceAccountSelector")]
    public V1beta2FunctionSpecInitProviderBuildConfigServiceAccountSelector? ServiceAccountSelector { get; set; }

    /// <summary>
    /// The location of the function source code.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2FunctionSpecInitProviderBuildConfigSource? Source { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }

    /// <summary>Reference to a WorkerPool in cloudbuild to populate workerPool.</summary>
    [JsonPropertyName("workerPoolRef")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolRef? WorkerPoolRef { get; set; }

    /// <summary>Selector for a WorkerPool in cloudbuild to populate workerPool.</summary>
    [JsonPropertyName("workerPoolSelector")]
    public V1beta2FunctionSpecInitProviderBuildConfigWorkerPoolSelector? WorkerPoolSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Bucket in storage to populate value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Bucket in storage to populate value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelector
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
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerEventFilters
{
    /// <summary>
    /// &apos;Required. The name of a CloudEvents attribute.
    /// Currently, only a subset of attributes are supported for filtering. Use the gcloud eventarc providers describe command to learn more about events and their attributes.
    /// Do not filter for the &apos;type&apos; attribute here, as this is already achieved by the resource&apos;s event_type attribute.
    /// </summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of
    /// the filter. If not specified, only events that have an exact key-value
    /// pair specified in the filter are matched.
    /// The only allowed value is match-path-pattern.
    /// See documentation on path patterns here&apos;
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Required. The value for the attribute.
    /// If the operator field is set as match-path-pattern, this value can be a path pattern instead of an exact value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to a Bucket in storage to populate value.</summary>
    [JsonPropertyName("valueRef")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueRef? ValueRef { get; set; }

    /// <summary>Selector for a Bucket in storage to populate value.</summary>
    [JsonPropertyName("valueSelector")]
    public V1beta2FunctionSpecInitProviderEventTriggerEventFiltersValueSelector? ValueSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelector
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
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelector
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
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// An Eventarc trigger managed by Google Cloud Functions that fires events in
/// response to a condition in another service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderEventTrigger
{
    /// <summary>
    /// Criteria used to filter events.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventFilters")]
    public IList<V1beta2FunctionSpecInitProviderEventTriggerEventFilters>? EventFilters { get; set; }

    /// <summary>Required. The type of event to observe.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }

    /// <summary>Reference to a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicRef")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicRef? PubsubTopicRef { get; set; }

    /// <summary>Selector for a Topic in pubsub to populate pubsubTopic.</summary>
    [JsonPropertyName("pubsubTopicSelector")]
    public V1beta2FunctionSpecInitProviderEventTriggerPubsubTopicSelector? PubsubTopicSelector { get; set; }

    /// <summary>
    /// Describes the retry policy in case of function&apos;s execution failure.
    /// Retried execution is charged as any other execution.
    /// Possible values are: RETRY_POLICY_UNSPECIFIED, RETRY_POLICY_DO_NOT_RETRY, RETRY_POLICY_RETRY.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public string? RetryPolicy { get; set; }

    /// <summary>
    /// Optional. The email of the trigger&apos;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2FunctionSpecInitProviderEventTriggerServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    [JsonPropertyName("triggerRegion")]
    public string? TriggerRegion { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelector
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
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariablesSecretSelector? SecretSelector { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelector
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
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mountPath as &apos;/etc/secrets&apos; and path as secret_foo would mount the secret value file at /etc/secrets/secret_foo.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mountPath as /etc/secrets would mount the secret value files under the /etc/secrets directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount path: /etc/secrets</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Reference to a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretRef? SecretRef { get; set; }

    /// <summary>Selector for a Secret in secretmanager to populate secret.</summary>
    [JsonPropertyName("secretSelector")]
    public V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesSecretSelector? SecretSelector { get; set; }

    /// <summary>
    /// List of secret versions to mount for this secret. If empty, the latest version of the secret will be made available in a file named after the secret under the mount point.&apos;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("versions")]
    public IList<V1beta2FunctionSpecInitProviderServiceConfigSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelector
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
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Describes the Service being deployed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecInitProviderServiceConfig
{
    /// <summary>Whether 100% of traffic is routed to the latest revision. Defaults to true.</summary>
    [JsonPropertyName("allTrafficOnLatestRevision")]
    public bool? AllTrafficOnLatestRevision { get; set; }

    /// <summary>The number of CPUs used in a single container instance. Default value is calculated from available memory.</summary>
    [JsonPropertyName("availableCpu")]
    public string? AvailableCpu { get; set; }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    [JsonPropertyName("availableMemory")]
    public string? AvailableMemory { get; set; }

    /// <summary>The binary authorization policy to be checked when deploying the Cloud Run service.</summary>
    [JsonPropertyName("binaryAuthorizationPolicy")]
    public string? BinaryAuthorizationPolicy { get; set; }

    /// <summary>Environment variables that shall be available during function execution.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// Available ingress settings. Defaults to &quot;ALLOW_ALL&quot; if unspecified.
    /// Default value is ALLOW_ALL.
    /// Possible values are: ALLOW_ALL, ALLOW_INTERNAL_ONLY, ALLOW_INTERNAL_AND_GCLB.
    /// </summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public double? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>
    /// Secret environment variables configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1beta2FunctionSpecInitProviderServiceConfigSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>
    /// Secret volumes configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1beta2FunctionSpecInitProviderServiceConfigSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>Name of the service associated with a Function.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The email of the service account for this function.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailRef")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailRef? ServiceAccountEmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate serviceAccountEmail.</summary>
    [JsonPropertyName("serviceAccountEmailSelector")]
    public V1beta2FunctionSpecInitProviderServiceConfigServiceAccountEmailSelector? ServiceAccountEmailSelector { get; set; }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>The Serverless VPC Access connector that this cloud function can connect to.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>
    /// Available egress settings.
    /// Possible values are: VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED, PRIVATE_RANGES_ONLY, ALL_TRAFFIC.
    /// </summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
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
public partial class V1beta2FunctionSpecInitProvider
{
    /// <summary>
    /// Describes the Build step of the function that builds a container
    /// from the given source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buildConfig")]
    public V1beta2FunctionSpecInitProviderBuildConfig? BuildConfig { get; set; }

    /// <summary>User-provided description of a function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// An Eventarc trigger managed by Google Cloud Functions that fires events in
    /// response to a condition in another service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta2FunctionSpecInitProviderEventTrigger? EventTrigger { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs associated with this Cloud Function.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Describes the Service being deployed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceConfig")]
    public V1beta2FunctionSpecInitProviderServiceConfig? ServiceConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecManagementPoliciesEnum>))]
public enum V1beta2FunctionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2FunctionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2FunctionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2FunctionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2FunctionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2FunctionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2FunctionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>FunctionSpec defines the desired state of Function</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionSpec
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
    public V1beta2FunctionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2FunctionSpecForProvider ForProvider { get; set; }

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
    public V1beta2FunctionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2FunctionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2FunctionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2FunctionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Security patches are applied automatically to the runtime without requiring
/// the function to be redeployed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderBuildConfigAutomaticUpdatePolicy
{
}

/// <summary>
/// Security patches are only applied when a function is redeployed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderBuildConfigOnDeployUpdatePolicy
{
    /// <summary>
    /// (Output)
    /// The runtime version which was used during latest function deployment.
    /// </summary>
    [JsonPropertyName("runtimeVersion")]
    public string? RuntimeVersion { get; set; }
}

/// <summary>
/// If provided, get the source from this location in a Cloud Source Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderBuildConfigSourceRepoSource
{
    /// <summary>Regex matching branches to build.</summary>
    [JsonPropertyName("branchName")]
    public string? BranchName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("commitSha")]
    public string? CommitSha { get; set; }

    /// <summary>Directory, relative to the source root, in which to run the build.</summary>
    [JsonPropertyName("dir")]
    public string? Dir { get; set; }

    /// <summary>
    /// Only trigger a build if the revision regex does
    /// NOT match the revision regex.
    /// </summary>
    [JsonPropertyName("invertRegex")]
    public bool? InvertRegex { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the Cloud Source Repository.</summary>
    [JsonPropertyName("repoName")]
    public string? RepoName { get; set; }

    /// <summary>Regex matching tags to build.</summary>
    [JsonPropertyName("tagName")]
    public string? TagName { get; set; }
}

/// <summary>
/// If provided, get the source from this location in Google Cloud Storage.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderBuildConfigSourceStorageSource
{
    /// <summary>Google Cloud Storage bucket containing the source</summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// Google Cloud Storage generation for the object. If the generation
    /// is omitted, the latest generation will be used.
    /// </summary>
    [JsonPropertyName("generation")]
    public double? Generation { get; set; }

    /// <summary>Google Cloud Storage object containing the source.</summary>
    [JsonPropertyName("object")]
    public string? Object { get; set; }
}

/// <summary>
/// The location of the function source code.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderBuildConfigSource
{
    /// <summary>
    /// If provided, get the source from this location in a Cloud Source Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("repoSource")]
    public V1beta2FunctionStatusAtProviderBuildConfigSourceRepoSource? RepoSource { get; set; }

    /// <summary>
    /// If provided, get the source from this location in Google Cloud Storage.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("storageSource")]
    public V1beta2FunctionStatusAtProviderBuildConfigSourceStorageSource? StorageSource { get; set; }
}

/// <summary>
/// Describes the Build step of the function that builds a container
/// from the given source.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderBuildConfig
{
    /// <summary>
    /// Security patches are applied automatically to the runtime without requiring
    /// the function to be redeployed.
    /// </summary>
    [JsonPropertyName("automaticUpdatePolicy")]
    public V1beta2FunctionStatusAtProviderBuildConfigAutomaticUpdatePolicy? AutomaticUpdatePolicy { get; set; }

    /// <summary>
    /// (Output)
    /// The Cloud Build name of the latest successful
    /// deployment of the function.
    /// </summary>
    [JsonPropertyName("build")]
    public string? Build { get; set; }

    /// <summary>User managed repository created in Artifact Registry optionally with a customer managed encryption key.</summary>
    [JsonPropertyName("dockerRepository")]
    public string? DockerRepository { get; set; }

    /// <summary>
    /// The name of the function (as defined in source code) that will be executed.
    /// Defaults to the resource name suffix, if not specified. For backward
    /// compatibility, if function with given name is not found, then the system
    /// will try to use function named &quot;function&quot;. For Node.js this is name of a
    /// function exported by the module specified in source_location.
    /// </summary>
    [JsonPropertyName("entryPoint")]
    public string? EntryPoint { get; set; }

    /// <summary>User-provided build-time environment variables for the function.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// Security patches are only applied when a function is redeployed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("onDeployUpdatePolicy")]
    public V1beta2FunctionStatusAtProviderBuildConfigOnDeployUpdatePolicy? OnDeployUpdatePolicy { get; set; }

    /// <summary>
    /// The runtime in which to run the function. Required when deploying a new
    /// function, optional when updating an existing function.
    /// </summary>
    [JsonPropertyName("runtime")]
    public string? Runtime { get; set; }

    /// <summary>The fully-qualified name of the service account to be used for building the container.</summary>
    [JsonPropertyName("serviceAccount")]
    public string? ServiceAccount { get; set; }

    /// <summary>
    /// The location of the function source code.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("source")]
    public V1beta2FunctionStatusAtProviderBuildConfigSource? Source { get; set; }

    /// <summary>Name of the Cloud Build Custom Worker Pool that should be used to build the function.</summary>
    [JsonPropertyName("workerPool")]
    public string? WorkerPool { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderEventTriggerEventFilters
{
    /// <summary>
    /// &apos;Required. The name of a CloudEvents attribute.
    /// Currently, only a subset of attributes are supported for filtering. Use the gcloud eventarc providers describe command to learn more about events and their attributes.
    /// Do not filter for the &apos;type&apos; attribute here, as this is already achieved by the resource&apos;s event_type attribute.
    /// </summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>
    /// Optional. The operator used for matching the events with the value of
    /// the filter. If not specified, only events that have an exact key-value
    /// pair specified in the filter are matched.
    /// The only allowed value is match-path-pattern.
    /// See documentation on path patterns here&apos;
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// Required. The value for the attribute.
    /// If the operator field is set as match-path-pattern, this value can be a path pattern instead of an exact value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// An Eventarc trigger managed by Google Cloud Functions that fires events in
/// response to a condition in another service.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderEventTrigger
{
    /// <summary>
    /// Criteria used to filter events.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventFilters")]
    public IList<V1beta2FunctionStatusAtProviderEventTriggerEventFilters>? EventFilters { get; set; }

    /// <summary>Required. The type of event to observe.</summary>
    [JsonPropertyName("eventType")]
    public string? EventType { get; set; }

    /// <summary>
    /// The name of a Pub/Sub topic in the same project that will be used
    /// as the transport topic for the event delivery.
    /// </summary>
    [JsonPropertyName("pubsubTopic")]
    public string? PubsubTopic { get; set; }

    /// <summary>
    /// Describes the retry policy in case of function&apos;s execution failure.
    /// Retried execution is charged as any other execution.
    /// Possible values are: RETRY_POLICY_UNSPECIFIED, RETRY_POLICY_DO_NOT_RETRY, RETRY_POLICY_RETRY.
    /// </summary>
    [JsonPropertyName("retryPolicy")]
    public string? RetryPolicy { get; set; }

    /// <summary>
    /// Optional. The email of the trigger&apos;s service account. The service account
    /// must have permission to invoke Cloud Run services. If empty, defaults to the
    /// Compute Engine default service account: {project_number}-compute@developer.gserviceaccount.com.
    /// </summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>
    /// (Output)
    /// Output only. The resource name of the Eventarc trigger.
    /// </summary>
    [JsonPropertyName("trigger")]
    public string? Trigger { get; set; }

    /// <summary>
    /// The region that the trigger will be in. The trigger will only receive
    /// events originating in this region. It can be the same
    /// region as the function, a different region or multi-region, or the global
    /// region. If not provided, defaults to the same region as the function.
    /// </summary>
    [JsonPropertyName("triggerRegion")]
    public string? TriggerRegion { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderServiceConfigSecretEnvironmentVariables
{
    /// <summary>Name of the environment variable.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderServiceConfigSecretVolumesVersions
{
    /// <summary>Relative path of the file under the mount path where the secret value for this version will be fetched and made available. For example, setting the mountPath as &apos;/etc/secrets&apos; and path as secret_foo would mount the secret value file at /etc/secrets/secret_foo.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Version of the secret (version number or the string &apos;latest&apos;). It is preferable to use latest version with secret volumes as secret value changes are reflected immediately.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderServiceConfigSecretVolumes
{
    /// <summary>The path within the container to mount the secret volume. For example, setting the mountPath as /etc/secrets would mount the secret value files under the /etc/secrets directory. This directory will also be completely shadowed and unavailable to mount any other secrets. Recommended mount path: /etc/secrets</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Project identifier (preferably project number but can also be the project ID) of the project that contains the secret. If not set, it will be populated with the function&apos;s project assuming that the secret exists in the same project as of the function.</summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>Name of the secret in secret manager (not the full resource name).</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>
    /// List of secret versions to mount for this secret. If empty, the latest version of the secret will be made available in a file named after the secret under the mount point.&apos;
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("versions")]
    public IList<V1beta2FunctionStatusAtProviderServiceConfigSecretVolumesVersions>? Versions { get; set; }
}

/// <summary>
/// Describes the Service being deployed.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProviderServiceConfig
{
    /// <summary>Whether 100% of traffic is routed to the latest revision. Defaults to true.</summary>
    [JsonPropertyName("allTrafficOnLatestRevision")]
    public bool? AllTrafficOnLatestRevision { get; set; }

    /// <summary>The number of CPUs used in a single container instance. Default value is calculated from available memory.</summary>
    [JsonPropertyName("availableCpu")]
    public string? AvailableCpu { get; set; }

    /// <summary>
    /// The amount of memory available for a function.
    /// Defaults to 256M. Supported units are k, M, G, Mi, Gi. If no unit is
    /// supplied the value is interpreted as bytes.
    /// </summary>
    [JsonPropertyName("availableMemory")]
    public string? AvailableMemory { get; set; }

    /// <summary>The binary authorization policy to be checked when deploying the Cloud Run service.</summary>
    [JsonPropertyName("binaryAuthorizationPolicy")]
    public string? BinaryAuthorizationPolicy { get; set; }

    /// <summary>Environment variables that shall be available during function execution.</summary>
    [JsonPropertyName("environmentVariables")]
    public IDictionary<string, string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// (Output)
    /// URIs of the Service deployed
    /// </summary>
    [JsonPropertyName("gcfUri")]
    public string? GcfUri { get; set; }

    /// <summary>
    /// Available ingress settings. Defaults to &quot;ALLOW_ALL&quot; if unspecified.
    /// Default value is ALLOW_ALL.
    /// Possible values are: ALLOW_ALL, ALLOW_INTERNAL_ONLY, ALLOW_INTERNAL_AND_GCLB.
    /// </summary>
    [JsonPropertyName("ingressSettings")]
    public string? IngressSettings { get; set; }

    /// <summary>
    /// The limit on the maximum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Sets the maximum number of concurrent requests that each instance can receive. Defaults to 1.</summary>
    [JsonPropertyName("maxInstanceRequestConcurrency")]
    public double? MaxInstanceRequestConcurrency { get; set; }

    /// <summary>
    /// The limit on the minimum number of function instances that may coexist at a
    /// given time.
    /// </summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>
    /// Secret environment variables configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretEnvironmentVariables")]
    public IList<V1beta2FunctionStatusAtProviderServiceConfigSecretEnvironmentVariables>? SecretEnvironmentVariables { get; set; }

    /// <summary>
    /// Secret volumes configuration.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("secretVolumes")]
    public IList<V1beta2FunctionStatusAtProviderServiceConfigSecretVolumes>? SecretVolumes { get; set; }

    /// <summary>Name of the service associated with a Function.</summary>
    [JsonPropertyName("service")]
    public string? Service { get; set; }

    /// <summary>The email of the service account for this function.</summary>
    [JsonPropertyName("serviceAccountEmail")]
    public string? ServiceAccountEmail { get; set; }

    /// <summary>
    /// The function execution timeout. Execution is considered failed and
    /// can be terminated if the function is not completed at the end of the
    /// timeout period. Defaults to 60 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// (Output)
    /// URI of the Service deployed.
    /// </summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>The Serverless VPC Access connector that this cloud function can connect to.</summary>
    [JsonPropertyName("vpcConnector")]
    public string? VpcConnector { get; set; }

    /// <summary>
    /// Available egress settings.
    /// Possible values are: VPC_CONNECTOR_EGRESS_SETTINGS_UNSPECIFIED, PRIVATE_RANGES_ONLY, ALL_TRAFFIC.
    /// </summary>
    [JsonPropertyName("vpcConnectorEgressSettings")]
    public string? VpcConnectorEgressSettings { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusAtProvider
{
    /// <summary>
    /// Describes the Build step of the function that builds a container
    /// from the given source.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("buildConfig")]
    public V1beta2FunctionStatusAtProviderBuildConfig? BuildConfig { get; set; }

    /// <summary>User-provided description of a function.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>The environment the function is hosted on.</summary>
    [JsonPropertyName("environment")]
    public string? Environment { get; set; }

    /// <summary>
    /// An Eventarc trigger managed by Google Cloud Functions that fires events in
    /// response to a condition in another service.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("eventTrigger")]
    public V1beta2FunctionStatusAtProviderEventTrigger? EventTrigger { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/functions/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Resource name of a KMS crypto key (managed by the user) used to encrypt/decrypt function resources.
    /// It must match the pattern projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>A set of key/value label pairs associated with this Cloud Function.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this cloud function.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Describes the Service being deployed.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("serviceConfig")]
    public V1beta2FunctionStatusAtProviderServiceConfig? ServiceConfig { get; set; }

    /// <summary>Describes the current state of the function.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The last update timestamp of a Cloud Function.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>Output only. The deployed url for the function.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatusConditions
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

/// <summary>FunctionStatus defines the observed state of Function.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2FunctionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2FunctionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2FunctionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Function is the Schema for the Functions API. A Cloud Function that contains user computation executed in response to an event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Function : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2FunctionSpec>, IStatus<V1beta2FunctionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Function";
    public const string KubeGroup = "cloudfunctions2.gcp.upbound.io";
    public const string KubePluralName = "functions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudfunctions2.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Function";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FunctionSpec defines the desired state of Function</summary>
    [JsonPropertyName("spec")]
    public required V1beta2FunctionSpec Spec { get; set; }

    /// <summary>FunctionStatus defines the observed state of Function.</summary>
    [JsonPropertyName("status")]
    public V1beta2FunctionStatus? Status { get; set; }
}