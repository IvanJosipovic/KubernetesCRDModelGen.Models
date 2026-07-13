#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.beyondcorp.cnrm.cloud.google.com;
/// <summary>BeyondCorpClientConnectorService is the Schema for the BeyondCorpClientConnectorService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BeyondCorpClientConnectorServiceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1BeyondCorpClientConnectorService>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BeyondCorpClientConnectorServiceList";
    public const string KubeGroup = "beyondcorp.cnrm.cloud.google.com";
    public const string KubePluralName = "beyondcorpclientconnectorservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "beyondcorp.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BeyondCorpClientConnectorServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1BeyondCorpClientConnectorService objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1BeyondCorpClientConnectorService> Items { get; set; }
}

/// <summary>A VPC from the consumer project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpecEgressPeeredVPC
{
    /// <summary>Required. The name of the peered VPC owned by the consumer project.</summary>
    [JsonPropertyName("networkVPC")]
    public string? NetworkVPC { get; set; }
}

/// <summary>Required. The details of the egress settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpecEgress
{
    /// <summary>A VPC from the consumer project.</summary>
    [JsonPropertyName("peeredVPC")]
    public V1alpha1BeyondCorpClientConnectorServiceSpecEgressPeeredVPC? PeeredVPC { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpecIngressConfigDestinationRoutes
{
    /// <summary>Required. The network address of the subnet for which the packet is routed to the ClientGateway.</summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>Required. The network mask of the subnet for which the packet is routed to the ClientGateway.</summary>
    [JsonPropertyName("netmask")]
    public string? Netmask { get; set; }
}

/// <summary>The basic ingress config for ClientGateways.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpecIngressConfig
{
    /// <summary>Required. The settings used to configure basic ClientGateways.</summary>
    [JsonPropertyName("destinationRoutes")]
    public IList<V1alpha1BeyondCorpClientConnectorServiceSpecIngressConfigDestinationRoutes>? DestinationRoutes { get; set; }

    /// <summary>Required. Immutable. The transport protocol used between the client and the server.</summary>
    [JsonPropertyName("transportProtocol")]
    public string? TransportProtocol { get; set; }
}

/// <summary>Required. The details of the ingress settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpecIngress
{
    /// <summary>The basic ingress config for ClientGateways.</summary>
    [JsonPropertyName("config")]
    public V1alpha1BeyondCorpClientConnectorServiceSpecIngressConfig? Config { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpecProjectRef
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

/// <summary>BeyondCorpClientConnectorServiceSpec defines the desired state of BeyondCorpClientConnectorService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceSpec
{
    /// <summary>Optional. User-provided name. The display name should follow certain format. * Must be 6 to 30 characters in length. * Can only contain lowercase letters, numbers, and hyphens. * Must start with a letter.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Required. The details of the egress settings.</summary>
    [JsonPropertyName("egress")]
    public required V1alpha1BeyondCorpClientConnectorServiceSpecEgress Egress { get; set; }

    /// <summary>Required. The details of the ingress settings.</summary>
    [JsonPropertyName("ingress")]
    public required V1alpha1BeyondCorpClientConnectorServiceSpecIngress Ingress { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1BeyondCorpClientConnectorServiceSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BeyondCorpClientConnectorService name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceStatusConditions
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
public partial class V1alpha1BeyondCorpClientConnectorServiceStatusObservedState
{
    /// <summary>Output only. [Output only] Create time stamp.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The operational state of the ClientConnectorService.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. [Output only] Update time stamp.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BeyondCorpClientConnectorServiceStatus defines the config connector machine state of BeyondCorpClientConnectorService</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1BeyondCorpClientConnectorServiceStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1BeyondCorpClientConnectorServiceStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BeyondCorpClientConnectorService resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1BeyondCorpClientConnectorServiceStatusObservedState? ObservedState { get; set; }
}

/// <summary>BeyondCorpClientConnectorService is the Schema for the BeyondCorpClientConnectorService API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1BeyondCorpClientConnectorService : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1BeyondCorpClientConnectorServiceSpec>, IStatus<V1alpha1BeyondCorpClientConnectorServiceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "BeyondCorpClientConnectorService";
    public const string KubeGroup = "beyondcorp.cnrm.cloud.google.com";
    public const string KubePluralName = "beyondcorpclientconnectorservices";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "beyondcorp.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BeyondCorpClientConnectorService";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BeyondCorpClientConnectorServiceSpec defines the desired state of BeyondCorpClientConnectorService</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1BeyondCorpClientConnectorServiceSpec Spec { get; set; }

    /// <summary>BeyondCorpClientConnectorServiceStatus defines the config connector machine state of BeyondCorpClientConnectorService</summary>
    [JsonPropertyName("status")]
    public V1alpha1BeyondCorpClientConnectorServiceStatus? Status { get; set; }
}