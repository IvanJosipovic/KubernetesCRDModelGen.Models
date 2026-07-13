#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.artifact.gcp.upbound.io;
/// <summary>RegistryRepository is the Schema for the RegistryRepositorys API. A repository for storing artifacts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegistryRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RegistryRepository>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegistryRepositoryList";
    public const string KubeGroup = "artifact.gcp.upbound.io";
    public const string KubePluralName = "registryrepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "artifact.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegistryRepositoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RegistryRepository objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RegistryRepository> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecDeletionPolicyEnum>))]
public enum V1beta2RegistryRepositorySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Policy condition for matching versions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderCleanupPoliciesCondition
{
    /// <summary>Match versions newer than a duration.</summary>
    [JsonPropertyName("newerThan")]
    public string? NewerThan { get; set; }

    /// <summary>Match versions older than a duration.</summary>
    [JsonPropertyName("olderThan")]
    public string? OlderThan { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }

    /// <summary>Match versions by tag prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("tagPrefixes")]
    public IList<string>? TagPrefixes { get; set; }

    /// <summary>
    /// Match versions by tag status.
    /// Default value is ANY.
    /// Possible values are: TAGGED, UNTAGGED, ANY.
    /// </summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary>
/// Policy condition for retaining a minimum number of versions. May only be
/// specified with a Keep action.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public double? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderCleanupPolicies
{
    /// <summary>
    /// Policy action.
    /// Possible values are: DELETE, KEEP.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Policy condition for matching versions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2RegistryRepositorySpecForProviderCleanupPoliciesCondition? Condition { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Policy condition for retaining a minimum number of versions. May only be
    /// specified with a Keep action.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mostRecentVersions")]
    public V1beta2RegistryRepositorySpecForProviderCleanupPoliciesMostRecentVersions? MostRecentVersions { get; set; }
}

/// <summary>
/// Docker repository config contains repository level configuration for the repositories of docker type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary>
/// MavenRepositoryConfig is maven related repository details.
/// Provides additional configuration details for repositories of the maven
/// format type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderMavenConfig
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>
    /// Version policy defines the versions that the registry will accept.
    /// Default value is VERSION_POLICY_UNSPECIFIED.
    /// Possible values are: VERSION_POLICY_UNSPECIFIED, RELEASE, SNAPSHOT.
    /// </summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary>
/// One of the publicly available Yum repositories supported by Artifact Registry.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepositoryPublicRepository
{
    /// <summary>
    /// A common public repository base for Yum.
    /// Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.
    /// </summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. &quot;pub/rocky/9/BaseOS/x86_64/os&quot;</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary>
/// Specific settings for an Apt remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepository
{
    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepositoryPublicRepository? PublicRepository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelector
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
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specific settings for an Artifact Registory remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate uri.</summary>
    [JsonPropertyName("uriRef")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriRef? UriRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate uri.</summary>
    [JsonPropertyName("uriSelector")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepositoryUriSelector? UriSelector { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Docker remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Maven remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for an Npm remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Python remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector
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
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Use username and password to access the remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials
{
    /// <summary>
    /// The Secret Manager key version that holds the password to access the
    /// remote repository. Must be in the format of
    /// projects/{project}/secrets/{secret}/versions/{version}.
    /// </summary>
    [JsonPropertyName("passwordSecretVersion")]
    public string? PasswordSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionRef")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef? PasswordSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionSelector")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector? PasswordSecretVersionSelector { get; set; }

    /// <summary>The username to access the remote repository.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// The credentials used to access the remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentials
{
    /// <summary>
    /// Use username and password to access the remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("usernamePasswordCredentials")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials? UsernamePasswordCredentials { get; set; }
}

/// <summary>
/// One of the publicly available Yum repositories supported by Artifact Registry.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepositoryPublicRepository
{
    /// <summary>
    /// A common public repository base for Yum.
    /// Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.
    /// </summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. &quot;pub/rocky/9/BaseOS/x86_64/os&quot;</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary>
/// Specific settings for an Yum remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepository
{
    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepositoryPublicRepository? PublicRepository { get; set; }
}

/// <summary>
/// Configuration specific for a Remote Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfig
{
    /// <summary>
    /// Specific settings for an Apt remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aptRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigAptRepository? AptRepository { get; set; }

    /// <summary>
    /// Specific settings for an Artifact Registory remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("commonRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigCommonRepository? CommonRepository { get; set; }

    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    [JsonPropertyName("disableUpstreamValidation")]
    public bool? DisableUpstreamValidation { get; set; }

    /// <summary>
    /// Specific settings for a Docker remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dockerRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigDockerRepository? DockerRepository { get; set; }

    /// <summary>
    /// Specific settings for a Maven remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigMavenRepository? MavenRepository { get; set; }

    /// <summary>
    /// Specific settings for an Npm remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("npmRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigNpmRepository? NpmRepository { get; set; }

    /// <summary>
    /// Specific settings for a Python remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigPythonRepository? PythonRepository { get; set; }

    /// <summary>
    /// The credentials used to access the remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upstreamCredentials")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigUpstreamCredentials? UpstreamCredentials { get; set; }

    /// <summary>
    /// Specific settings for an Yum remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yumRepository")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfigYumRepository? YumRepository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector
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
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// A reference to the repository resource, for example:
    /// &quot;projects/p1/locations/us-central1/repository/repo1&quot;.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector? RepositorySelector { get; set; }
}

/// <summary>
/// Configuration specific for a Virtual Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfig
{
    /// <summary>
    /// Policies that configure the upstream artifacts distributed by the Virtual
    /// Repository. Upstream policies cannot be set on a standard repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary>
/// Configuration for vulnerability scanning of artifacts stored in this repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProviderVulnerabilityScanningConfig
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository.
    /// Possible values are: INHERITED, DISABLED.
    /// </summary>
    [JsonPropertyName("enablementConfig")]
    public string? EnablementConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecForProvider
{
    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta2RegistryRepositorySpecForProviderCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dockerConfig")]
    public V1beta2RegistryRepositorySpecForProviderDockerConfig? DockerConfig { get; set; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found here.
    /// You can only create alpha formats if you are a member of the
    /// alpha user group.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// This field may contain up to 64 entries. Label keys and values may be no
    /// longer than 63 characters. Label keys must begin with a lowercase letter
    /// and may only contain lowercase letters, numeric characters, underscores,
    /// and dashes.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The name of the repository&apos;s location. In addition to specific regions,
    /// special values for multi-region locations are asia, europe, and us.
    /// See here,
    /// or use the
    /// google_artifact_registry_locations
    /// data source for possible values.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenConfig")]
    public V1beta2RegistryRepositorySpecForProviderMavenConfig? MavenConfig { get; set; }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources.
    /// Default value is STANDARD_REPOSITORY.
    /// Possible values are: STANDARD_REPOSITORY, VIRTUAL_REPOSITORY, REMOTE_REPOSITORY.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configuration specific for a Remote Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public V1beta2RegistryRepositorySpecForProviderRemoteRepositoryConfig? RemoteRepositoryConfig { get; set; }

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public V1beta2RegistryRepositorySpecForProviderVirtualRepositoryConfig? VirtualRepositoryConfig { get; set; }

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vulnerabilityScanningConfig")]
    public V1beta2RegistryRepositorySpecForProviderVulnerabilityScanningConfig? VulnerabilityScanningConfig { get; set; }
}

/// <summary>
/// Policy condition for matching versions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderCleanupPoliciesCondition
{
    /// <summary>Match versions newer than a duration.</summary>
    [JsonPropertyName("newerThan")]
    public string? NewerThan { get; set; }

    /// <summary>Match versions older than a duration.</summary>
    [JsonPropertyName("olderThan")]
    public string? OlderThan { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }

    /// <summary>Match versions by tag prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("tagPrefixes")]
    public IList<string>? TagPrefixes { get; set; }

    /// <summary>
    /// Match versions by tag status.
    /// Default value is ANY.
    /// Possible values are: TAGGED, UNTAGGED, ANY.
    /// </summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary>
/// Policy condition for retaining a minimum number of versions. May only be
/// specified with a Keep action.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public double? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderCleanupPolicies
{
    /// <summary>
    /// Policy action.
    /// Possible values are: DELETE, KEEP.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Policy condition for matching versions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2RegistryRepositorySpecInitProviderCleanupPoliciesCondition? Condition { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Policy condition for retaining a minimum number of versions. May only be
    /// specified with a Keep action.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mostRecentVersions")]
    public V1beta2RegistryRepositorySpecInitProviderCleanupPoliciesMostRecentVersions? MostRecentVersions { get; set; }
}

/// <summary>
/// Docker repository config contains repository level configuration for the repositories of docker type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary>
/// MavenRepositoryConfig is maven related repository details.
/// Provides additional configuration details for repositories of the maven
/// format type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderMavenConfig
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>
    /// Version policy defines the versions that the registry will accept.
    /// Default value is VERSION_POLICY_UNSPECIFIED.
    /// Possible values are: VERSION_POLICY_UNSPECIFIED, RELEASE, SNAPSHOT.
    /// </summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary>
/// One of the publicly available Yum repositories supported by Artifact Registry.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepositoryPublicRepository
{
    /// <summary>
    /// A common public repository base for Yum.
    /// Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.
    /// </summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. &quot;pub/rocky/9/BaseOS/x86_64/os&quot;</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary>
/// Specific settings for an Apt remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepository
{
    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepositoryPublicRepository? PublicRepository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate uri.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelector
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
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specific settings for an Artifact Registory remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate uri.</summary>
    [JsonPropertyName("uriRef")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriRef? UriRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate uri.</summary>
    [JsonPropertyName("uriSelector")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepositoryUriSelector? UriSelector { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Docker remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Maven remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for an Npm remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Python remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector
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
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Use username and password to access the remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials
{
    /// <summary>
    /// The Secret Manager key version that holds the password to access the
    /// remote repository. Must be in the format of
    /// projects/{project}/secrets/{secret}/versions/{version}.
    /// </summary>
    [JsonPropertyName("passwordSecretVersion")]
    public string? PasswordSecretVersion { get; set; }

    /// <summary>Reference to a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionRef")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionRef? PasswordSecretVersionRef { get; set; }

    /// <summary>Selector for a SecretVersion in secretmanager to populate passwordSecretVersion.</summary>
    [JsonPropertyName("passwordSecretVersionSelector")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentialsPasswordSecretVersionSelector? PasswordSecretVersionSelector { get; set; }

    /// <summary>The username to access the remote repository.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// The credentials used to access the remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentials
{
    /// <summary>
    /// Use username and password to access the remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("usernamePasswordCredentials")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials? UsernamePasswordCredentials { get; set; }
}

/// <summary>
/// One of the publicly available Yum repositories supported by Artifact Registry.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepositoryPublicRepository
{
    /// <summary>
    /// A common public repository base for Yum.
    /// Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.
    /// </summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. &quot;pub/rocky/9/BaseOS/x86_64/os&quot;</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary>
/// Specific settings for an Yum remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepository
{
    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepositoryPublicRepository? PublicRepository { get; set; }
}

/// <summary>
/// Configuration specific for a Remote Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfig
{
    /// <summary>
    /// Specific settings for an Apt remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aptRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigAptRepository? AptRepository { get; set; }

    /// <summary>
    /// Specific settings for an Artifact Registory remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("commonRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigCommonRepository? CommonRepository { get; set; }

    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    [JsonPropertyName("disableUpstreamValidation")]
    public bool? DisableUpstreamValidation { get; set; }

    /// <summary>
    /// Specific settings for a Docker remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dockerRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigDockerRepository? DockerRepository { get; set; }

    /// <summary>
    /// Specific settings for a Maven remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigMavenRepository? MavenRepository { get; set; }

    /// <summary>
    /// Specific settings for an Npm remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("npmRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigNpmRepository? NpmRepository { get; set; }

    /// <summary>
    /// Specific settings for a Python remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigPythonRepository? PythonRepository { get; set; }

    /// <summary>
    /// The credentials used to access the remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upstreamCredentials")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigUpstreamCredentials? UpstreamCredentials { get; set; }

    /// <summary>
    /// Specific settings for an Yum remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yumRepository")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfigYumRepository? YumRepository { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector
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
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// A reference to the repository resource, for example:
    /// &quot;projects/p1/locations/us-central1/repository/repo1&quot;.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Reference to a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }

    /// <summary>Selector for a RegistryRepository in artifact to populate repository.</summary>
    [JsonPropertyName("repositorySelector")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPoliciesRepositorySelector? RepositorySelector { get; set; }
}

/// <summary>
/// Configuration specific for a Virtual Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfig
{
    /// <summary>
    /// Policies that configure the upstream artifacts distributed by the Virtual
    /// Repository. Upstream policies cannot be set on a standard repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary>
/// Configuration for vulnerability scanning of artifacts stored in this repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecInitProviderVulnerabilityScanningConfig
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository.
    /// Possible values are: INHERITED, DISABLED.
    /// </summary>
    [JsonPropertyName("enablementConfig")]
    public string? EnablementConfig { get; set; }
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
public partial class V1beta2RegistryRepositorySpecInitProvider
{
    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta2RegistryRepositorySpecInitProviderCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dockerConfig")]
    public V1beta2RegistryRepositorySpecInitProviderDockerConfig? DockerConfig { get; set; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found here.
    /// You can only create alpha formats if you are a member of the
    /// alpha user group.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// This field may contain up to 64 entries. Label keys and values may be no
    /// longer than 63 characters. Label keys must begin with a lowercase letter
    /// and may only contain lowercase letters, numeric characters, underscores,
    /// and dashes.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenConfig")]
    public V1beta2RegistryRepositorySpecInitProviderMavenConfig? MavenConfig { get; set; }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources.
    /// Default value is STANDARD_REPOSITORY.
    /// Possible values are: STANDARD_REPOSITORY, VIRTUAL_REPOSITORY, REMOTE_REPOSITORY.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configuration specific for a Remote Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public V1beta2RegistryRepositorySpecInitProviderRemoteRepositoryConfig? RemoteRepositoryConfig { get; set; }

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public V1beta2RegistryRepositorySpecInitProviderVirtualRepositoryConfig? VirtualRepositoryConfig { get; set; }

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vulnerabilityScanningConfig")]
    public V1beta2RegistryRepositorySpecInitProviderVulnerabilityScanningConfig? VulnerabilityScanningConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecManagementPoliciesEnum>))]
public enum V1beta2RegistryRepositorySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RegistryRepositorySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegistryRepositorySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RegistryRepositorySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegistryRepositorySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegistryRepositorySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegistryRepositorySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegistryRepositorySpec defines the desired state of RegistryRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositorySpec
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
    public V1beta2RegistryRepositorySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RegistryRepositorySpecForProvider ForProvider { get; set; }

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
    public V1beta2RegistryRepositorySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RegistryRepositorySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RegistryRepositorySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RegistryRepositorySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Policy condition for matching versions.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderCleanupPoliciesCondition
{
    /// <summary>Match versions newer than a duration.</summary>
    [JsonPropertyName("newerThan")]
    public string? NewerThan { get; set; }

    /// <summary>Match versions older than a duration.</summary>
    [JsonPropertyName("olderThan")]
    public string? OlderThan { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }

    /// <summary>Match versions by tag prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("tagPrefixes")]
    public IList<string>? TagPrefixes { get; set; }

    /// <summary>
    /// Match versions by tag status.
    /// Default value is ANY.
    /// Possible values are: TAGGED, UNTAGGED, ANY.
    /// </summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary>
/// Policy condition for retaining a minimum number of versions. May only be
/// specified with a Keep action.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public double? KeepCount { get; set; }

    /// <summary>Match versions by package prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderCleanupPolicies
{
    /// <summary>
    /// Policy action.
    /// Possible values are: DELETE, KEEP.
    /// </summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Policy condition for matching versions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("condition")]
    public V1beta2RegistryRepositoryStatusAtProviderCleanupPoliciesCondition? Condition { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Policy condition for retaining a minimum number of versions. May only be
    /// specified with a Keep action.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mostRecentVersions")]
    public V1beta2RegistryRepositoryStatusAtProviderCleanupPoliciesMostRecentVersions? MostRecentVersions { get; set; }
}

/// <summary>
/// Docker repository config contains repository level configuration for the repositories of docker type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary>
/// MavenRepositoryConfig is maven related repository details.
/// Provides additional configuration details for repositories of the maven
/// format type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderMavenConfig
{
    /// <summary>
    /// The repository with this flag will allow publishing the same
    /// snapshot versions.
    /// </summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>
    /// Version policy defines the versions that the registry will accept.
    /// Default value is VERSION_POLICY_UNSPECIFIED.
    /// Possible values are: VERSION_POLICY_UNSPECIFIED, RELEASE, SNAPSHOT.
    /// </summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary>
/// One of the publicly available Yum repositories supported by Artifact Registry.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepositoryPublicRepository
{
    /// <summary>
    /// A common public repository base for Yum.
    /// Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.
    /// </summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. &quot;pub/rocky/9/BaseOS/x86_64/os&quot;</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary>
/// Specific settings for an Apt remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepository
{
    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepositoryPublicRepository? PublicRepository { get; set; }
}

/// <summary>
/// Specific settings for an Artifact Registory remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigCommonRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Docker remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Maven remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for an Npm remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepositoryCustomRepository
{
    /// <summary>Specific uri to the registry, e.g. &quot;https://registry-1.docker.io&quot;</summary>
    [JsonPropertyName("uri")]
    public string? Uri { get; set; }
}

/// <summary>
/// Specific settings for a Python remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepository
{
    /// <summary>
    /// [Deprecated, please use commonRepository instead] Settings for a remote repository with a custom uri.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepositoryCustomRepository? CustomRepository { get; set; }

    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>
/// Use username and password to access the remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials
{
    /// <summary>
    /// The Secret Manager key version that holds the password to access the
    /// remote repository. Must be in the format of
    /// projects/{project}/secrets/{secret}/versions/{version}.
    /// </summary>
    [JsonPropertyName("passwordSecretVersion")]
    public string? PasswordSecretVersion { get; set; }

    /// <summary>The username to access the remote repository.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// The credentials used to access the remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentials
{
    /// <summary>
    /// Use username and password to access the remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("usernamePasswordCredentials")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentialsUsernamePasswordCredentials? UsernamePasswordCredentials { get; set; }
}

/// <summary>
/// One of the publicly available Yum repositories supported by Artifact Registry.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepositoryPublicRepository
{
    /// <summary>
    /// A common public repository base for Yum.
    /// Possible values are: CENTOS, CENTOS_DEBUG, CENTOS_VAULT, CENTOS_STREAM, ROCKY, EPEL.
    /// </summary>
    [JsonPropertyName("repositoryBase")]
    public string? RepositoryBase { get; set; }

    /// <summary>Specific repository from the base, e.g. &quot;pub/rocky/9/BaseOS/x86_64/os&quot;</summary>
    [JsonPropertyName("repositoryPath")]
    public string? RepositoryPath { get; set; }
}

/// <summary>
/// Specific settings for an Yum remote repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepository
{
    /// <summary>
    /// One of the publicly available Yum repositories supported by Artifact Registry.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepositoryPublicRepository? PublicRepository { get; set; }
}

/// <summary>
/// Configuration specific for a Remote Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfig
{
    /// <summary>
    /// Specific settings for an Apt remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aptRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigAptRepository? AptRepository { get; set; }

    /// <summary>
    /// Specific settings for an Artifact Registory remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("commonRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigCommonRepository? CommonRepository { get; set; }

    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If true, the remote repository upstream and upstream credentials will
    /// not be validated.
    /// </summary>
    [JsonPropertyName("disableUpstreamValidation")]
    public bool? DisableUpstreamValidation { get; set; }

    /// <summary>
    /// Specific settings for a Docker remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dockerRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigDockerRepository? DockerRepository { get; set; }

    /// <summary>
    /// Specific settings for a Maven remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigMavenRepository? MavenRepository { get; set; }

    /// <summary>
    /// Specific settings for an Npm remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("npmRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigNpmRepository? NpmRepository { get; set; }

    /// <summary>
    /// Specific settings for a Python remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pythonRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigPythonRepository? PythonRepository { get; set; }

    /// <summary>
    /// The credentials used to access the remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upstreamCredentials")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigUpstreamCredentials? UpstreamCredentials { get; set; }

    /// <summary>
    /// Specific settings for an Yum remote repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("yumRepository")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfigYumRepository? YumRepository { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>
    /// A reference to the repository resource, for example:
    /// &quot;projects/p1/locations/us-central1/repository/repo1&quot;.
    /// </summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>
/// Configuration specific for a Virtual Repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderVirtualRepositoryConfig
{
    /// <summary>
    /// Policies that configure the upstream artifacts distributed by the Virtual
    /// Repository. Upstream policies cannot be set on a standard repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta2RegistryRepositoryStatusAtProviderVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary>
/// Configuration for vulnerability scanning of artifacts stored in this repository.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProviderVulnerabilityScanningConfig
{
    /// <summary>
    /// This configures whether vulnerability scanning is automatically performed for artifacts pushed to this repository.
    /// Possible values are: INHERITED, DISABLED.
    /// </summary>
    [JsonPropertyName("enablementConfig")]
    public string? EnablementConfig { get; set; }

    /// <summary>
    /// (Output)
    /// This field returns whether scanning is active for this repository.
    /// </summary>
    [JsonPropertyName("enablementState")]
    public string? EnablementState { get; set; }

    /// <summary>
    /// (Output)
    /// This provides an explanation for the state of scanning on this repository.
    /// </summary>
    [JsonPropertyName("enablementStateReason")]
    public string? EnablementStateReason { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusAtProvider
{
    /// <summary>
    /// Cleanup policies for this repository. Cleanup policies indicate when
    /// certain package versions can be automatically deleted.
    /// Map keys are policy IDs supplied by users during policy creation. They must
    /// unique within a repository and be under 128 characters in length.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta2RegistryRepositoryStatusAtProviderCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>
    /// If true, the cleanup pipeline is prevented from deleting versions in this
    /// repository.
    /// </summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The time when the repository was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Docker repository config contains repository level configuration for the repositories of docker type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dockerConfig")]
    public V1beta2RegistryRepositoryStatusAtProviderDockerConfig? DockerConfig { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// The format of packages that are stored in the repository. Supported formats
    /// can be found here.
    /// You can only create alpha formats if you are a member of the
    /// alpha user group.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/repositories/{{repository_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The Cloud KMS resource name of the customer managed encryption key that’s
    /// used to encrypt the contents of the Repository. Has the form:
    /// projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key.
    /// This value may not be changed after the Repository has been created.
    /// </summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// This field may contain up to 64 entries. Label keys and values may be no
    /// longer than 63 characters. Label keys must begin with a lowercase letter
    /// and may only contain lowercase letters, numeric characters, underscores,
    /// and dashes.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The name of the repository&apos;s location. In addition to specific regions,
    /// special values for multi-region locations are asia, europe, and us.
    /// See here,
    /// or use the
    /// google_artifact_registry_locations
    /// data source for possible values.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MavenRepositoryConfig is maven related repository details.
    /// Provides additional configuration details for repositories of the maven
    /// format type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("mavenConfig")]
    public V1beta2RegistryRepositoryStatusAtProviderMavenConfig? MavenConfig { get; set; }

    /// <summary>
    /// The mode configures the repository to serve artifacts from different sources.
    /// Default value is STANDARD_REPOSITORY.
    /// Possible values are: STANDARD_REPOSITORY, VIRTUAL_REPOSITORY, REMOTE_REPOSITORY.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// The name of the repository, for example:
    /// &quot;repo1&quot;
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Configuration specific for a Remote Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public V1beta2RegistryRepositoryStatusAtProviderRemoteRepositoryConfig? RemoteRepositoryConfig { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>The time when the repository was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>
    /// Configuration specific for a Virtual Repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public V1beta2RegistryRepositoryStatusAtProviderVirtualRepositoryConfig? VirtualRepositoryConfig { get; set; }

    /// <summary>
    /// Configuration for vulnerability scanning of artifacts stored in this repository.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("vulnerabilityScanningConfig")]
    public V1beta2RegistryRepositoryStatusAtProviderVulnerabilityScanningConfig? VulnerabilityScanningConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatusConditions
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

/// <summary>RegistryRepositoryStatus defines the observed state of RegistryRepository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegistryRepositoryStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RegistryRepositoryStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RegistryRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegistryRepository is the Schema for the RegistryRepositorys API. A repository for storing artifacts</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegistryRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RegistryRepositorySpec>, IStatus<V1beta2RegistryRepositoryStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegistryRepository";
    public const string KubeGroup = "artifact.gcp.upbound.io";
    public const string KubePluralName = "registryrepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "artifact.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegistryRepository";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegistryRepositorySpec defines the desired state of RegistryRepository</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RegistryRepositorySpec Spec { get; set; }

    /// <summary>RegistryRepositoryStatus defines the observed state of RegistryRepository.</summary>
    [JsonPropertyName("status")]
    public V1beta2RegistryRepositoryStatus? Status { get; set; }
}