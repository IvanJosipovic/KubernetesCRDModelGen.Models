#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.clouddms.cnrm.cloud.google.com;
/// <summary>CloudDMSConversionWorkspace is the Schema for the CloudDMSConversionWorkspace API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSConversionWorkspaceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudDMSConversionWorkspace>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSConversionWorkspaceList";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsconversionworkspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddms.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDMSConversionWorkspaceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudDMSConversionWorkspace objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudDMSConversionWorkspace> Items { get; set; }
}

/// <summary>Required. The destination engine details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpecDestination
{
    /// <summary>Required. Engine type.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Required. Engine named version, for example 12.c.1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpecProjectRef
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

/// <summary>Required. The source engine details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpecSource
{
    /// <summary>Required. Engine type.</summary>
    [JsonPropertyName("engine")]
    public string? Engine { get; set; }

    /// <summary>Required. Engine named version, for example 12.c.1.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>CloudDMSConversionWorkspaceSpec defines the desired state of CloudDMSConversionWorkspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceSpec
{
    /// <summary>Required. The destination engine details.</summary>
    [JsonPropertyName("destination")]
    public V1alpha1CloudDMSConversionWorkspaceSpecDestination? Destination { get; set; }

    /// <summary>Optional. The display name for the workspace.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Optional. A generic list of settings for the workspace. The settings are database pair dependant and can indicate default behavior for the mapping rules engine or turn on or off specific features. Such examples can be: convert_foreign_key_to_interleave=true, skip_triggers=false, ignore_non_table_synonyms=true</summary>
    [JsonPropertyName("globalSettings")]
    public IDictionary<string, string>? GlobalSettings { get; set; }

    /// <summary>Immutable. The location where the alloydb cluster should reside.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1CloudDMSConversionWorkspaceSpecProjectRef ProjectRef { get; set; }

    /// <summary>The CloudDMSConversionWorkspace name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The source engine details.</summary>
    [JsonPropertyName("source")]
    public V1alpha1CloudDMSConversionWorkspaceSpecSource? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceStatusConditions
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
public partial class V1alpha1CloudDMSConversionWorkspaceStatusObservedState
{
    /// <summary>Output only. The timestamp when the workspace resource was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Whether the workspace has uncommitted changes (changes which were made after the workspace was committed).</summary>
    [JsonPropertyName("hasUncommittedChanges")]
    public bool? HasUncommittedChanges { get; set; }

    /// <summary>Output only. The latest commit ID.</summary>
    [JsonPropertyName("latestCommitID")]
    public string? LatestCommitID { get; set; }

    /// <summary>Output only. The timestamp when the workspace was committed.</summary>
    [JsonPropertyName("latestCommitTime")]
    public string? LatestCommitTime { get; set; }

    /// <summary>Output only. The timestamp when the workspace resource was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>CloudDMSConversionWorkspaceStatus defines the config connector machine state of CloudDMSConversionWorkspace</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudDMSConversionWorkspaceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudDMSConversionWorkspaceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the CloudDMSConversionWorkspace resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1CloudDMSConversionWorkspaceStatusObservedState? ObservedState { get; set; }
}

/// <summary>CloudDMSConversionWorkspace is the Schema for the CloudDMSConversionWorkspace API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudDMSConversionWorkspace : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudDMSConversionWorkspaceSpec>, IStatus<V1alpha1CloudDMSConversionWorkspaceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudDMSConversionWorkspace";
    public const string KubeGroup = "clouddms.cnrm.cloud.google.com";
    public const string KubePluralName = "clouddmsconversionworkspaces";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "clouddms.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudDMSConversionWorkspace";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudDMSConversionWorkspaceSpec defines the desired state of CloudDMSConversionWorkspace</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1CloudDMSConversionWorkspaceSpec Spec { get; set; }

    /// <summary>CloudDMSConversionWorkspaceStatus defines the config connector machine state of CloudDMSConversionWorkspace</summary>
    [JsonPropertyName("status")]
    public V1alpha1CloudDMSConversionWorkspaceStatus? Status { get; set; }
}