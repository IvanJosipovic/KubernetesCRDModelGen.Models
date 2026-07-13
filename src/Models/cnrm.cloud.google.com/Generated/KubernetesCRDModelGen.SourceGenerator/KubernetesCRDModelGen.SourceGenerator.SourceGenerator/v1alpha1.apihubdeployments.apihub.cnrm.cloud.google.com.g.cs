#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apihub.cnrm.cloud.google.com;
/// <summary>APIHubDeployment is the Schema for the APIHubDeployment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubDeploymentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIHubDeployment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubDeploymentList";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubDeploymentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIHubDeployment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIHubDeployment> Items { get; set; }
}

/// <summary>Required. The type of deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-deployment-type` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentSpecDeploymentTypeRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The documentation of the deployment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentSpecDocumentation
{
    /// <summary>Optional. The uri of the externally hosted documentation.</summary>
    [JsonPropertyName("externalURI")]
    public string? ExternalURI { get; set; }
}

/// <summary>Optional. The environment mapping to this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-environment` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentSpecEnvironmentRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentSpecProjectRef
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

/// <summary>Optional. The SLO for this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-slo` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentSpecSloRef
{
    /// <summary>The `id` of an allowed value of an attribute, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `APIHubAttribute` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>APIHubDeploymentSpec defines the desired state of APIHubDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentSpec
{
    /// <summary>Required. The type of deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-deployment-type` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
    [JsonPropertyName("deploymentTypeRef")]
    public required V1alpha1APIHubDeploymentSpecDeploymentTypeRef DeploymentTypeRef { get; set; }

    /// <summary>Optional. The description of the deployment.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. The display name of the deployment.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Optional. The documentation of the deployment.</summary>
    [JsonPropertyName("documentation")]
    public V1alpha1APIHubDeploymentSpecDocumentation? Documentation { get; set; }

    /// <summary>Required. The endpoints at which this deployment resource is listening for API requests. This could be a list of complete URIs, hostnames or an IP addresses.</summary>
    [JsonPropertyName("endpoints")]
    public required IList<string> Endpoints { get; set; }

    /// <summary>Optional. The environment mapping to this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-environment` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
    [JsonPropertyName("environmentRef")]
    public V1alpha1APIHubDeploymentSpecEnvironmentRef? EnvironmentRef { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1APIHubDeploymentSpecProjectRef ProjectRef { get; set; }

    /// <summary>The APIHubDeployment name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. A URI to the runtime resource. This URI can be used to manage the resource. For example, if the runtime resource is of type APIGEE_PROXY, then this field will contain the URI to the management UI of the proxy.</summary>
    [JsonPropertyName("resourceURI")]
    public required string ResourceURI { get; set; }

    /// <summary>Optional. The SLO for this deployment. This maps to the following system defined attribute: `projects/{project}/locations/{location}/attributes/system-slo` attribute. The number of values for this attribute will be based on the cardinality of the attribute. The same can be retrieved via GetAttribute API. All values should be from the list of allowed values defined for the attribute.</summary>
    [JsonPropertyName("sloRef")]
    public V1alpha1APIHubDeploymentSpecSloRef? SloRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentStatusConditions
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
public partial class V1alpha1APIHubDeploymentStatusObservedState
{
    /// <summary>Output only. The API versions linked to this deployment. Note: A particular deployment could be linked to multiple different API versions (of same or different APIs).</summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>Output only. The time at which the deployment was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The time at which the deployment was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>APIHubDeploymentStatus defines the config connector machine state of APIHubDeployment</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIHubDeploymentStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIHubDeploymentStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the APIHubDeployment resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1APIHubDeploymentStatusObservedState? ObservedState { get; set; }
}

/// <summary>APIHubDeployment is the Schema for the APIHubDeployment API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIHubDeployment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIHubDeploymentSpec>, IStatus<V1alpha1APIHubDeploymentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIHubDeployment";
    public const string KubeGroup = "apihub.cnrm.cloud.google.com";
    public const string KubePluralName = "apihubdeployments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apihub.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIHubDeployment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>APIHubDeploymentSpec defines the desired state of APIHubDeployment</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1APIHubDeploymentSpec Spec { get; set; }

    /// <summary>APIHubDeploymentStatus defines the config connector machine state of APIHubDeployment</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIHubDeploymentStatus? Status { get; set; }
}