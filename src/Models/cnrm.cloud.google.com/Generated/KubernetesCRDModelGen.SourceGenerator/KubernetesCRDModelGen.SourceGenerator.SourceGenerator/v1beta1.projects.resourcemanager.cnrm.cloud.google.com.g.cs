#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.resourcemanager.cnrm.cloud.google.com;
/// <summary>Project is the Schema for the Project API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ProjectList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Project>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ProjectList";
    public const string KubeGroup = "resourcemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resourcemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProjectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Project objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Project> Items { get; set; }
}

/// <summary>The billing account of the project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecBillingAccountRef
{
    /// <summary>A reference to an externally managed BillingAccount resource. Should be in the format &quot;billingAccounts/{billingAccountID}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BillingAccount resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BillingAccount resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The folder that this resource belongs to. Changing this forces the resource to be migrated to the newly specified folder. Only one of folderRef or organizationRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecFolderRef
{
    /// <summary>The &apos;name&apos; field of a folder, when not managed by Config Connector. This field must be set when &apos;name&apos; field is not set.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The &apos;name&apos; field of a &apos;Folder&apos; resource. This field must be set when &apos;external&apos; field is not set.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The &apos;namespace&apos; field of a &apos;Folder&apos; resource. If unset, the namespace is defaulted to the namespace of the referencer resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The organization that this resource belongs to. Changing this forces the resource to be migrated to the newly specified organization. Only one of folderRef or organizationRef may be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpecOrganizationRef
{
    /// <summary>The &apos;name&apos; field of an organization, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The &apos;name&apos; field of an &apos;Organization&apos; resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The &apos;namespace&apos; field of an &apos;Organization&apos; resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>ProjectSpec defines the desired state of Project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectSpec
{
    /// <summary>The billing account of the project.</summary>
    [JsonPropertyName("billingAccountRef")]
    public V1beta1ProjectSpecBillingAccountRef? BillingAccountRef { get; set; }

    /// <summary>The folder that this resource belongs to. Changing this forces the resource to be migrated to the newly specified folder. Only one of folderRef or organizationRef may be specified.</summary>
    [JsonPropertyName("folderRef")]
    public V1beta1ProjectSpecFolderRef? FolderRef { get; set; }

    /// <summary>The display name of the project.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>The organization that this resource belongs to. Changing this forces the resource to be migrated to the newly specified organization. Only one of folderRef or organizationRef may be specified.</summary>
    [JsonPropertyName("organizationRef")]
    public V1beta1ProjectSpecOrganizationRef? OrganizationRef { get; set; }

    /// <summary>Immutable. Optional. The projectId of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatusConditions
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

/// <summary>ProjectStatus defines the config connector machine state of Project</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ProjectStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ProjectStatusConditions>? Conditions { get; set; }

    /// <summary>The numeric identifier of the project.</summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Project is the Schema for the Project API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Project : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ProjectSpec>, IStatus<V1beta1ProjectStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Project";
    public const string KubeGroup = "resourcemanager.cnrm.cloud.google.com";
    public const string KubePluralName = "projects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "resourcemanager.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Project";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ProjectSpec defines the desired state of Project</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ProjectSpec Spec { get; set; }

    /// <summary>ProjectStatus defines the config connector machine state of Project</summary>
    [JsonPropertyName("status")]
    public V1beta1ProjectStatus? Status { get; set; }
}