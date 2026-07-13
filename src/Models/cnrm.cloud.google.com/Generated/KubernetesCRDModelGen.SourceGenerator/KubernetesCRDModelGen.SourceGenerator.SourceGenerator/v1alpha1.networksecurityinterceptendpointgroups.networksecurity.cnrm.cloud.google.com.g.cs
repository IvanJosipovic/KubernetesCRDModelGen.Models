#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networksecurity.cnrm.cloud.google.com;
/// <summary>NetworkSecurityInterceptEndpointGroup is the Schema for the NetworkSecurityInterceptEndpointGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkSecurityInterceptEndpointGroup>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityInterceptEndpointGroupList";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityinterceptendpointgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityInterceptEndpointGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkSecurityInterceptEndpointGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkSecurityInterceptEndpointGroup> Items { get; set; }
}

/// <summary>Required. Immutable. The deployment group that this endpoint group is connected to, for example: `projects/123456789/locations/global/interceptDeploymentGroups/my-dg`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupSpecInterceptDeploymentGroupRef
{
    /// <summary>A reference to an externally managed NetworkSecurityInterceptDeploymentGroup resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/interceptDeploymentGroups/{{interceptDeploymentGroupID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name field of a NetworkSecurityInterceptDeploymentGroup resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace field of a NetworkSecurityInterceptDeploymentGroup resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupSpecProjectRef
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

/// <summary>NetworkSecurityInterceptEndpointGroupSpec defines the desired state of NetworkSecurityInterceptEndpointGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupSpec
{
    /// <summary>Optional. User-provided description of the endpoint group. Used as additional context for the endpoint group.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Required. Immutable. The deployment group that this endpoint group is connected to, for example: `projects/123456789/locations/global/interceptDeploymentGroups/my-dg`.</summary>
    [JsonPropertyName("interceptDeploymentGroupRef")]
    public required V1alpha1NetworkSecurityInterceptEndpointGroupSpecInterceptDeploymentGroupRef InterceptDeploymentGroupRef { get; set; }

    /// <summary>Optional. Labels are key/value pairs that help to organize and filter resources.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkSecurityInterceptEndpointGroupSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkSecurityInterceptEndpointGroup name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedStateAssociations
{
    /// <summary>Output only. The connected association&apos;s resource name, for example: `projects/123456789/locations/global/interceptEndpointGroupAssociations/my-ega`. See https://google.aip.dev/124.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The associated network, for example: projects/123456789/global/networks/my-network. See https://google.aip.dev/124.</summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>Output only. Most recent known state of the association.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedStateConnectedDeploymentGroupLocations
{
    /// <summary>Output only. The cloud location, e.g. &quot;us-central1-a&quot; or &quot;asia-south1&quot;.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Output only. The current state of the association in this location.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Output only. Details about the connected deployment group to this endpoint group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedStateConnectedDeploymentGroup
{
    /// <summary>Output only. The list of locations where the deployment group is present.</summary>
    [JsonPropertyName("locations")]
    public IList<V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedStateConnectedDeploymentGroupLocations>? Locations { get; set; }

    /// <summary>Output only. The connected deployment group&apos;s resource name, for example: `projects/123456789/locations/global/interceptDeploymentGroups/my-dg`. See https://google.aip.dev/124.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedState
{
    /// <summary>Output only. List of associations to this endpoint group.</summary>
    [JsonPropertyName("associations")]
    public IList<V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedStateAssociations>? Associations { get; set; }

    /// <summary>Output only. Details about the connected deployment group to this endpoint group.</summary>
    [JsonPropertyName("connectedDeploymentGroup")]
    public V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedStateConnectedDeploymentGroup? ConnectedDeploymentGroup { get; set; }

    /// <summary>Output only. The timestamp when the resource was created. See https://google.aip.dev/148#timestamps.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The current state of the resource does not match the user&apos;s intended state, and the system is working to reconcile them. This is part of the normal operation (e.g. adding a new association to the group). See https://google.aip.dev/128.</summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The current state of the endpoint group. See https://google.aip.dev/216.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The timestamp when the resource was most recently updated. See https://google.aip.dev/148#timestamps.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkSecurityInterceptEndpointGroupStatus defines the config connector machine state of NetworkSecurityInterceptEndpointGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroupStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkSecurityInterceptEndpointGroupStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkSecurityInterceptEndpointGroup resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkSecurityInterceptEndpointGroupStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkSecurityInterceptEndpointGroup is the Schema for the NetworkSecurityInterceptEndpointGroup API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkSecurityInterceptEndpointGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkSecurityInterceptEndpointGroupSpec>, IStatus<V1alpha1NetworkSecurityInterceptEndpointGroupStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkSecurityInterceptEndpointGroup";
    public const string KubeGroup = "networksecurity.cnrm.cloud.google.com";
    public const string KubePluralName = "networksecurityinterceptendpointgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networksecurity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkSecurityInterceptEndpointGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkSecurityInterceptEndpointGroupSpec defines the desired state of NetworkSecurityInterceptEndpointGroup</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkSecurityInterceptEndpointGroupSpec Spec { get; set; }

    /// <summary>NetworkSecurityInterceptEndpointGroupStatus defines the config connector machine state of NetworkSecurityInterceptEndpointGroup</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkSecurityInterceptEndpointGroupStatus? Status { get; set; }
}