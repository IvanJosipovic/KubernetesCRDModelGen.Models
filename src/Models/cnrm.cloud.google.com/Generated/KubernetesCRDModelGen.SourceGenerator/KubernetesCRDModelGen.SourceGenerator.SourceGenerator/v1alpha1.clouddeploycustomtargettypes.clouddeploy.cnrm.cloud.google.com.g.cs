#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddeploy.cnrm.cloud.google.com;
/// <summary>CloudDeployCustomTargetType is the Schema for the CloudDeployCustomTargetType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployCustomTargetTypeList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDeployCustomTargetType>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployCustomTargetTypeList";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploycustomtargettypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddeploy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDeployCustomTargetTypeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudDeployCustomTargetType objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudDeployCustomTargetType> Items { get; set; }
}

/// <summary>Optional. Remote git repository containing the Skaffold Config modules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGit
{
    /// <summary>Optional. Relative path from the repository root to the Skaffold file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Git branch or tag to use when cloning the repository.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>Required. Git repository the package should be cloned from.</summary>
    [JsonPropertyName("repo")]
    public string? Repo { get; set; }
}

/// <summary>Required. Name of the Cloud Build V2 RepositoryRef. Format is projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepoRepositoryRef
{
    /// <summary>A reference to an externally managed CloudBuildRepository resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/connections/{{connectionID}}/repositories/{{RepositoryID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a CloudBuildRepository resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a CloudBuildRepository resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Cloud Build V2 repository containing the Skaffold Config modules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepo
{
    /// <summary>Optional. Relative path from the repository root to the Skaffold Config file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Branch or tag to use when cloning the repository.</summary>
    [JsonPropertyName("ref")]
    public string? Ref { get; set; }

    /// <summary>Required. Name of the Cloud Build V2 RepositoryRef. Format is projects/{project}/locations/{location}/connections/{connection}/repositories/{repository}.</summary>
    [JsonPropertyName("repositoryRef")]
    public V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepoRepositoryRef? RepositoryRef { get; set; }
}

/// <summary>Optional. Cloud Storage bucket containing the Skaffold Config modules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudStorage
{
    /// <summary>Optional. Relative path from the source to the Skaffold file.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Required. Cloud Storage source paths to copy recursively. For example, providing &quot;gs://my-bucket/dir/configs/*&quot; will result in Skaffold copying all files within the &quot;dir/configs&quot; directory in the bucket &quot;my-bucket&quot;.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModules
{
    /// <summary>Optional. The Skaffold Config modules to use from the specified source.</summary>
    [JsonPropertyName("configs")]
    public IList<string>? Configs { get; set; }

    /// <summary>Optional. Remote git repository containing the Skaffold Config modules.</summary>
    [JsonPropertyName("git")]
    public V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGit? Git { get; set; }

    /// <summary>Optional. Cloud Build V2 repository containing the Skaffold Config modules.</summary>
    [JsonPropertyName("googleCloudBuildRepo")]
    public V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudBuildRepo? GoogleCloudBuildRepo { get; set; }

    /// <summary>Optional. Cloud Storage bucket containing the Skaffold Config modules.</summary>
    [JsonPropertyName("googleCloudStorage")]
    public V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModulesGoogleCloudStorage? GoogleCloudStorage { get; set; }
}

/// <summary>Configures render and deploy for the `CustomTargetType` using Skaffold custom actions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecCustomActions
{
    /// <summary>Required. The Skaffold custom action responsible for deploy operations.</summary>
    [JsonPropertyName("deployAction")]
    public string? DeployAction { get; set; }

    /// <summary>Optional. List of Skaffold modules Cloud Deploy will include in the Skaffold Config as required before performing diagnose.</summary>
    [JsonPropertyName("includeSkaffoldModules")]
    public IList<V1alpha1CloudDeployCustomTargetTypeSpecCustomActionsIncludeSkaffoldModules>? IncludeSkaffoldModules { get; set; }

    /// <summary>Optional. The Skaffold custom action responsible for render operations. If not provided then Cloud Deploy will perform the render operations via `skaffold render`.</summary>
    [JsonPropertyName("renderAction")]
    public string? RenderAction { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpecProjectRef
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

/// <summary>CustomTargetTypeSpec defines the desired state of CloudDeployCustomTargetType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeSpec
{
    /// <summary>Configures render and deploy for the `CustomTargetType` using Skaffold custom actions.</summary>
    [JsonPropertyName("customActions")]
    public V1alpha1CloudDeployCustomTargetTypeSpecCustomActions? CustomActions { get; set; }

    /// <summary>Optional. Description of the `CustomTargetType`. Max length is 255 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudDeployCustomTargetTypeSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CloudDeployCustomTargetType name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeStatusConditions
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
public partial class V1alpha1CloudDeployCustomTargetTypeStatusObservedState
{
    /// <summary>Output only. Time at which the `CustomTargetType` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Resource id of the `CustomTargetType`.</summary>
    [JsonPropertyName("customTargetTypeID")]
    public string? CustomTargetTypeID { get; set; }

    /// <summary>Output only. Unique identifier of the `CustomTargetType`.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. Most recent time at which the `CustomTargetType` was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CustomTargetTypeStatus defines the config connector machine state of CloudDeployCustomTargetType</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDeployCustomTargetTypeStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDeployCustomTargetTypeStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDeployCustomTargetType resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDeployCustomTargetTypeStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudDeployCustomTargetType is the Schema for the CloudDeployCustomTargetType API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDeployCustomTargetType : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDeployCustomTargetTypeSpec>, IStatus<V1alpha1CloudDeployCustomTargetTypeStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDeployCustomTargetType";
    public const string KubeGroup = "clouddeploy.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddeploycustomtargettypes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddeploy.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDeployCustomTargetType";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomTargetTypeSpec defines the desired state of CloudDeployCustomTargetType</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudDeployCustomTargetTypeSpec Spec { get; set; }

    /// <summary>CustomTargetTypeStatus defines the config connector machine state of CloudDeployCustomTargetType</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDeployCustomTargetTypeStatus? Status { get; set; }
}