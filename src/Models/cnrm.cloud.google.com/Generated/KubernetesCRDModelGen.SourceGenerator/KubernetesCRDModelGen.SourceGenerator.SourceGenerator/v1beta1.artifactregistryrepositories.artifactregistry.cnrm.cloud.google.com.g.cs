#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.artifactregistry.cnrm.cloud.google.com;
/// <summary>ArtifactRegistryRepository is the Schema for the ArtifactRegistryRepository API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ArtifactRegistryRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ArtifactRegistryRepository>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ArtifactRegistryRepositoryList";
    public const string KubeGroup = "artifactregistry.cnrm.cloud.google.com";
    public const string KubePluralName = "artifactregistryrepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "artifactregistry.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ArtifactRegistryRepositoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ArtifactRegistryRepository objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ArtifactRegistryRepository> Items { get; set; }
}

/// <summary>Policy condition for matching versions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesCondition
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

    /// <summary>Match versions by tag status.</summary>
    [JsonPropertyName("tagState")]
    public string? TagState { get; set; }

    /// <summary>Match versions by version name prefix. Applied on any prefix match.</summary>
    [JsonPropertyName("versionNamePrefixes")]
    public IList<string>? VersionNamePrefixes { get; set; }
}

/// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesMostRecentVersions
{
    /// <summary>Minimum number of versions to keep.</summary>
    [JsonPropertyName("keepCount")]
    public int? KeepCount { get; set; }

    /// <summary>List of package name prefixes that will apply this rule.</summary>
    [JsonPropertyName("packageNamePrefixes")]
    public IList<string>? PackageNamePrefixes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecCleanupPolicies
{
    /// <summary>Policy action.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Policy condition for matching versions.</summary>
    [JsonPropertyName("condition")]
    public V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesCondition? Condition { get; set; }

    /// <summary>The user-provided ID of the cleanup policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy condition for retaining a minimum number of versions. May only be specified with a Keep action.</summary>
    [JsonPropertyName("mostRecentVersions")]
    public V1beta1ArtifactRegistryRepositorySpecCleanupPoliciesMostRecentVersions? MostRecentVersions { get; set; }
}

/// <summary>Docker repository config contains repository level configuration for the repositories of docker type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecDockerConfig
{
    /// <summary>The repository which enabled this flag prevents all tags from being modified, moved or deleted. This does not prevent tags from being created.</summary>
    [JsonPropertyName("immutableTags")]
    public bool? ImmutableTags { get; set; }
}

/// <summary>The Cloud KMS resource name of the customer managed encryption key that&apos;s used to encrypt the contents of the Repository. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. This value may not be changed after the Repository has been created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Maven repository config contains repository level configuration for the repositories of maven type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecMavenConfig
{
    /// <summary>The repository with this flag will allow publishing the same snapshot versions.</summary>
    [JsonPropertyName("allowSnapshotOverwrites")]
    public bool? AllowSnapshotOverwrites { get; set; }

    /// <summary>Version policy defines the versions that the registry will accept.</summary>
    [JsonPropertyName("versionPolicy")]
    public string? VersionPolicy { get; set; }
}

/// <summary>Specific settings for a Docker remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigDockerRepository
{
    /// <summary>One of the publicly available Docker repositories supported by Artifact Registry.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Specific settings for a Maven remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigMavenRepository
{
    /// <summary>One of the publicly available Maven repositories supported by Artifact Registry.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Specific settings for an Npm remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigNpmRepository
{
    /// <summary>One of the publicly available Npm repositories supported by Artifact Registry.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Specific settings for a Python remote repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigPythonRepository
{
    /// <summary>One of the publicly available Python repositories supported by Artifact Registry.</summary>
    [JsonPropertyName("publicRepository")]
    public string? PublicRepository { get; set; }
}

/// <summary>Configuration specific for a Remote Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfig
{
    /// <summary>The description of the remote source.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specific settings for a Docker remote repository.</summary>
    [JsonPropertyName("dockerRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigDockerRepository? DockerRepository { get; set; }

    /// <summary>Specific settings for a Maven remote repository.</summary>
    [JsonPropertyName("mavenRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigMavenRepository? MavenRepository { get; set; }

    /// <summary>Specific settings for an Npm remote repository.</summary>
    [JsonPropertyName("npmRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigNpmRepository? NpmRepository { get; set; }

    /// <summary>Specific settings for a Python remote repository.</summary>
    [JsonPropertyName("pythonRepository")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfigPythonRepository? PythonRepository { get; set; }
}

/// <summary>A reference to the repository resource, for example: `projects/p1/locations/us-central1/repositories/repo1`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPoliciesRepositoryRef
{
    /// <summary>A reference to an externally managed ArtifactRegistryRepository resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/repositories/{{repositoryID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ArtifactRegistryRepository resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ArtifactRegistryRepository resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPolicies
{
    /// <summary>The user-provided ID of the upstream policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Entries with a greater priority value take precedence in the pull order.</summary>
    [JsonPropertyName("priority")]
    public int? Priority { get; set; }

    /// <summary>A reference to the repository resource, for example: `projects/p1/locations/us-central1/repositories/repo1`.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPoliciesRepositoryRef? RepositoryRef { get; set; }
}

/// <summary>Configuration specific for a Virtual Repository.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfig
{
    /// <summary>Policies that configure the upstream artifacts distributed by the Virtual Repository. Upstream policies cannot be set on a standard repository.</summary>
    [JsonPropertyName("upstreamPolicies")]
    public IList<V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfigUpstreamPolicies>? UpstreamPolicies { get; set; }
}

/// <summary>ArtifactRegistryRepositorySpec defines the desired state of ArtifactRegistryRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositorySpec
{
    /// <summary>Cleanup policies for this repository. Cleanup policies indicate when certain package versions can be automatically deleted. Map keys are policy IDs supplied by users during policy creation. They must unique within a repository and be under 128 characters in length.</summary>
    [JsonPropertyName("cleanupPolicies")]
    public IList<V1beta1ArtifactRegistryRepositorySpecCleanupPolicies>? CleanupPolicies { get; set; }

    /// <summary>Optional. If true, the cleanup pipeline is prevented from deleting versions in this repository.</summary>
    [JsonPropertyName("cleanupPolicyDryRun")]
    public bool? CleanupPolicyDryRun { get; set; }

    /// <summary>The user-provided description of the repository.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Docker repository config contains repository level configuration for the repositories of docker type.</summary>
    [JsonPropertyName("dockerConfig")]
    public V1beta1ArtifactRegistryRepositorySpecDockerConfig? DockerConfig { get; set; }

    /// <summary>Optional. The format of packages that are stored in the repository.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>The Cloud KMS resource name of the customer managed encryption key that&apos;s used to encrypt the contents of the Repository. Has the form: `projects/my-project/locations/my-region/keyRings/my-kr/cryptoKeys/my-key`. This value may not be changed after the Repository has been created.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public V1beta1ArtifactRegistryRepositorySpecKmsKeyRef? KmsKeyRef { get; set; }

    /// <summary>Immutable. The name of the location this repository is located in.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Maven repository config contains repository level configuration for the repositories of maven type.</summary>
    [JsonPropertyName("mavenConfig")]
    public V1beta1ArtifactRegistryRepositorySpecMavenConfig? MavenConfig { get; set; }

    /// <summary>Optional. The mode of the repository.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Configuration specific for a Remote Repository.</summary>
    [JsonPropertyName("remoteRepositoryConfig")]
    public V1beta1ArtifactRegistryRepositorySpecRemoteRepositoryConfig? RemoteRepositoryConfig { get; set; }

    /// <summary>The ArtifactRegistryRepository name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Configuration specific for a Virtual Repository.</summary>
    [JsonPropertyName("virtualRepositoryConfig")]
    public V1beta1ArtifactRegistryRepositorySpecVirtualRepositoryConfig? VirtualRepositoryConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositoryStatusConditions
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

/// <summary>ArtifactRegistryRepositoryStatus defines the config connector machine state of ArtifactRegistryRepository</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ArtifactRegistryRepositoryStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ArtifactRegistryRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The time when the repository was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The name of the repository, for example: &quot;repo1&quot;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Output only. The time when the repository was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>ArtifactRegistryRepository is the Schema for the ArtifactRegistryRepository API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ArtifactRegistryRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ArtifactRegistryRepositorySpec>, IStatus<V1beta1ArtifactRegistryRepositoryStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ArtifactRegistryRepository";
    public const string KubeGroup = "artifactregistry.cnrm.cloud.google.com";
    public const string KubePluralName = "artifactregistryrepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "artifactregistry.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ArtifactRegistryRepository";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ArtifactRegistryRepositorySpec defines the desired state of ArtifactRegistryRepository</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ArtifactRegistryRepositorySpec Spec { get; set; }

    /// <summary>ArtifactRegistryRepositoryStatus defines the config connector machine state of ArtifactRegistryRepository</summary>
    [JsonPropertyName("status")]
    public V1beta1ArtifactRegistryRepositoryStatus? Status { get; set; }
}