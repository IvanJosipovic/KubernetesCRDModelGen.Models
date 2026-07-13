#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dataform.cnrm.cloud.google.com;
/// <summary>DataformRepository is the Schema for the dataform API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataformRepositoryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DataformRepository>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataformRepositoryList";
    public const string KubeGroup = "dataform.cnrm.cloud.google.com";
    public const string KubePluralName = "dataformrepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataformRepositoryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DataformRepository objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DataformRepository> Items { get; set; }
}

/// <summary>The name of the Secret Manager secret version to use as an authentication token for Git operations. Must be in the format projects/* /secrets/* /versions/*.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecGitRemoteSettingsAuthenticationTokenSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The name of the Secret Manager secret version to use as a ssh private key for Git operations. Must be in the format projects/*/secrets/*/versions/* .</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfigUserPrivateKeySecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Authentication fields for remote uris using SSH protocol.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfig
{
    /// <summary>Content of a public SSH key to verify an identity of a remote Git host.</summary>
    [JsonPropertyName("hostPublicKey")]
    public required string HostPublicKey { get; set; }

    /// <summary>The name of the Secret Manager secret version to use as a ssh private key for Git operations. Must be in the format projects/*/secrets/*/versions/* .</summary>
    [JsonPropertyName("userPrivateKeySecretVersionRef")]
    public required V1alpha1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfigUserPrivateKeySecretVersionRef UserPrivateKeySecretVersionRef { get; set; }
}

/// <summary>Optional. If set, configures this repository to be linked to a Git remote.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecGitRemoteSettings
{
    /// <summary>The name of the Secret Manager secret version to use as an authentication token for Git operations. Must be in the format projects/* /secrets/* /versions/*.</summary>
    [JsonPropertyName("authenticationTokenSecretVersionRef")]
    public V1alpha1DataformRepositorySpecGitRemoteSettingsAuthenticationTokenSecretVersionRef? AuthenticationTokenSecretVersionRef { get; set; }

    /// <summary>The Git remote&apos;s default branch name.</summary>
    [JsonPropertyName("defaultBranch")]
    public required string DefaultBranch { get; set; }

    /// <summary>Authentication fields for remote uris using SSH protocol.</summary>
    [JsonPropertyName("sshAuthenticationConfig")]
    public V1alpha1DataformRepositorySpecGitRemoteSettingsSshAuthenticationConfig? SshAuthenticationConfig { get; set; }

    /// <summary>The Git remote&apos;s URL.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>Optional. The name of the Secret Manager secret version to be used to interpolate variables into the .npmrc file for package installation operations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecNpmrcEnvironmentVariablesSecretVersionRef
{
    /// <summary> If provided must be in the format `projects/*/secrets/*/versions/*`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `SecretManagerSecretVersion` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecProjectRef
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

/// <summary>Optional. The service account reference to run workflow invocations under.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. If set, fields of workspaceCompilationOverrides override the default compilation settings that are specified in dataform.json when creating workspace-scoped compilation results.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpecWorkspaceCompilationOverrides
{
    /// <summary>Optional. The default database (Google Cloud project ID).</summary>
    [JsonPropertyName("defaultDatabase")]
    public string? DefaultDatabase { get; set; }

    /// <summary>Optional. The suffix that should be appended to all schema (BigQuery dataset ID) names.</summary>
    [JsonPropertyName("schemaSuffix")]
    public string? SchemaSuffix { get; set; }

    /// <summary>Optional. The prefix that should be prepended to all table names.</summary>
    [JsonPropertyName("tablePrefix")]
    public string? TablePrefix { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositorySpec
{
    /// <summary>Optional. The repository&apos;s user-friendly name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. If set, configures this repository to be linked to a Git remote.</summary>
    [JsonPropertyName("gitRemoteSettings")]
    public V1alpha1DataformRepositorySpecGitRemoteSettings? GitRemoteSettings { get; set; }

    /// <summary>Optional. The name of the Secret Manager secret version to be used to interpolate variables into the .npmrc file for package installation operations.</summary>
    [JsonPropertyName("npmrcEnvironmentVariablesSecretVersionRef")]
    public V1alpha1DataformRepositorySpecNpmrcEnvironmentVariablesSecretVersionRef? NpmrcEnvironmentVariablesSecretVersionRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DataformRepositorySpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. A reference to the region.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The service account reference to run workflow invocations under.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1alpha1DataformRepositorySpecServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Input only. If set to true, the authenticated user will be granted the roles/dataform.admin role on the created repository.</summary>
    [JsonPropertyName("setAuthenticatedUserAdmin")]
    public bool? SetAuthenticatedUserAdmin { get; set; }

    /// <summary>Optional. If set, fields of workspaceCompilationOverrides override the default compilation settings that are specified in dataform.json when creating workspace-scoped compilation results.</summary>
    [JsonPropertyName("workspaceCompilationOverrides")]
    public V1alpha1DataformRepositorySpecWorkspaceCompilationOverrides? WorkspaceCompilationOverrides { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositoryStatusConditions
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

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositoryStatusObservedState
{
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DataformRepositoryStatus
{
    /// <summary>Conditions represent the latest available observations of the DataformRepository&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DataformRepositoryStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DataformReposity resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DataformRepositoryStatusObservedState? ObservedState { get; set; }
}

/// <summary>DataformRepository is the Schema for the dataform API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DataformRepository : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DataformRepositorySpec>, IStatus<V1alpha1DataformRepositoryStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DataformRepository";
    public const string KubeGroup = "dataform.cnrm.cloud.google.com";
    public const string KubePluralName = "dataformrepositories";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dataform.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DataformRepository";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1DataformRepositorySpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1DataformRepositoryStatus? Status { get; set; }
}