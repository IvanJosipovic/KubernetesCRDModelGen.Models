#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.datastream.cnrm.cloud.google.com;
/// <summary>DatastreamPrivateConnection is the Schema for the DatastreamPrivateConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamPrivateConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DatastreamPrivateConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamPrivateConnectionList";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamprivateconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datastream.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatastreamPrivateConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DatastreamPrivateConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DatastreamPrivateConnection> Items { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionSpecProjectRef
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

/// <summary>Required. Fully qualified name of the VPC that Datastream will peer to. Format: `projects/{project}/global/{networks}/{name}`</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionSpecVpcPeeringConfigNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>VPC Peering Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionSpecVpcPeeringConfig
{
    /// <summary>Required. Fully qualified name of the VPC that Datastream will peer to. Format: `projects/{project}/global/{networks}/{name}`</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1DatastreamPrivateConnectionSpecVpcPeeringConfigNetworkRef? NetworkRef { get; set; }

    /// <summary>Required. A free subnet for peering. (CIDR of /29)</summary>
    [JsonPropertyName("subnet")]
    public string? Subnet { get; set; }
}

/// <summary>DatastreamPrivateConnectionSpec defines the desired state of DatastreamPrivateConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionSpec
{
    /// <summary>Required. Display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DatastreamPrivateConnectionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DatastreamPrivateConnection name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>VPC Peering Config.</summary>
    [JsonPropertyName("vpcPeeringConfig")]
    public V1alpha1DatastreamPrivateConnectionSpecVpcPeeringConfig? VpcPeeringConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionStatusConditions
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

/// <summary>Output only. In case of error, the details of the error in a user-friendly format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionStatusObservedStateError
{
    /// <summary>Additional information about the error.</summary>
    [JsonPropertyName("details")]
    public IDictionary<string, string>? Details { get; set; }

    /// <summary>The time when the error occurred.</summary>
    [JsonPropertyName("errorTime")]
    public string? ErrorTime { get; set; }

    /// <summary>A unique identifier for this specific error, allowing it to be traced throughout the system in logs and API responses.</summary>
    [JsonPropertyName("errorUUID")]
    public string? ErrorUUID { get; set; }

    /// <summary>A message containing more information about the error that occurred.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A title that explains the reason for the error.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionStatusObservedState
{
    /// <summary>Output only. The create time of the resource.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. In case of error, the details of the error in a user-friendly format.</summary>
    [JsonPropertyName("error")]
    public V1alpha1DatastreamPrivateConnectionStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. The state of the Private Connection.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The update time of the resource.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>DatastreamPrivateConnectionStatus defines the config connector machine state of DatastreamPrivateConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DatastreamPrivateConnectionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DatastreamPrivateConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DatastreamPrivateConnection resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DatastreamPrivateConnectionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DatastreamPrivateConnection is the Schema for the DatastreamPrivateConnection API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DatastreamPrivateConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DatastreamPrivateConnectionSpec>, IStatus<V1alpha1DatastreamPrivateConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DatastreamPrivateConnection";
    public const string KubeGroup = "datastream.cnrm.cloud.google.com";
    public const string KubePluralName = "datastreamprivateconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "datastream.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DatastreamPrivateConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DatastreamPrivateConnectionSpec defines the desired state of DatastreamPrivateConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DatastreamPrivateConnectionSpec Spec { get; set; }

    /// <summary>DatastreamPrivateConnectionStatus defines the config connector machine state of DatastreamPrivateConnection</summary>
    [JsonPropertyName("status")]
    public V1alpha1DatastreamPrivateConnectionStatus? Status { get; set; }
}