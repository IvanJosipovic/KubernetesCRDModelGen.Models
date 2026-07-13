#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.networkconnectivity.cnrm.cloud.google.com;
/// <summary>NetworkConnectivityRegionalEndpoint is the Schema for the NetworkConnectivityRegionalEndpoint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkConnectivityRegionalEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1NetworkConnectivityRegionalEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkConnectivityRegionalEndpointList";
    public const string KubeGroup = "networkconnectivity.cnrm.cloud.google.com";
    public const string KubePluralName = "networkconnectivityregionalendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkconnectivity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkConnectivityRegionalEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1NetworkConnectivityRegionalEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1NetworkConnectivityRegionalEndpoint> Items { get; set; }
}

/// <summary>Optional. The IP Address of the Regional Endpoint. When no address is provided, an IP from the subnetwork is allocated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointSpecAddressRef
{
    /// <summary>The ComputeAddress selflink in the form &quot;projects/{{project}}/regions/{{region}}/addresses/{{name}}&quot; when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeAddress` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The name of the VPC network for this private regional endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointSpecNetworkRef
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

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointSpecProjectRef
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

/// <summary>Optional. The name of the subnetwork from which the IP address will be allocated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointSpecSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form &quot;projects/{{project}}/regions/{{region}}/subnetworks/{{name}}&quot;, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>NetworkConnectivityRegionalEndpointSpec defines the desired state of NetworkConnectivityRegionalEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointSpec
{
    /// <summary>Required. The access type of this regional endpoint. This field is reflected in the PSC Forwarding Rule configuration to enable global access.</summary>
    [JsonPropertyName("accessType")]
    public required string AccessType { get; set; }

    /// <summary>Optional. The IP Address of the Regional Endpoint. When no address is provided, an IP from the subnetwork is allocated.</summary>
    [JsonPropertyName("addressRef")]
    public V1alpha1NetworkConnectivityRegionalEndpointSpecAddressRef? AddressRef { get; set; }

    /// <summary>Optional. A description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. The name of the VPC network for this private regional endpoint.</summary>
    [JsonPropertyName("networkRef")]
    public V1alpha1NetworkConnectivityRegionalEndpointSpecNetworkRef? NetworkRef { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1NetworkConnectivityRegionalEndpointSpecProjectRef ProjectRef { get; set; }

    /// <summary>The NetworkConnectivityRegionalEndpoint name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The name of the subnetwork from which the IP address will be allocated.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1alpha1NetworkConnectivityRegionalEndpointSpecSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Required. The service endpoint this private regional endpoint connects to. Format: `{apiname}.{region}.p.rep.googleapis.com` Example: &quot;cloudkms.us-central1.p.rep.googleapis.com&quot;.</summary>
    [JsonPropertyName("targetGoogleAPI")]
    public required string TargetGoogleAPI { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointStatusConditions
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
public partial class V1alpha1NetworkConnectivityRegionalEndpointStatusObservedState
{
    /// <summary>Output only. Time when the RegionalEndpoint was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The literal IP address of the PSC Forwarding Rule created on behalf of the customer. This field is deprecated. Use address instead.</summary>
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>Output only. The resource reference of the PSC Forwarding Rule created on behalf of the customer. Format: `//compute.googleapis.com/projects/{project}/regions/{region}/forwardingRules/{forwarding_rule_name}`</summary>
    [JsonPropertyName("pscForwardingRule")]
    public string? PscForwardingRule { get; set; }

    /// <summary>Output only. Time when the RegionalEndpoint was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>NetworkConnectivityRegionalEndpointStatus defines the config connector machine state of NetworkConnectivityRegionalEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1NetworkConnectivityRegionalEndpointStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1NetworkConnectivityRegionalEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the NetworkConnectivityRegionalEndpoint resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1NetworkConnectivityRegionalEndpointStatusObservedState? ObservedState { get; set; }
}

/// <summary>NetworkConnectivityRegionalEndpoint is the Schema for the NetworkConnectivityRegionalEndpoint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1NetworkConnectivityRegionalEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1NetworkConnectivityRegionalEndpointSpec>, IStatus<V1alpha1NetworkConnectivityRegionalEndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "NetworkConnectivityRegionalEndpoint";
    public const string KubeGroup = "networkconnectivity.cnrm.cloud.google.com";
    public const string KubePluralName = "networkconnectivityregionalendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "networkconnectivity.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NetworkConnectivityRegionalEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>NetworkConnectivityRegionalEndpointSpec defines the desired state of NetworkConnectivityRegionalEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1NetworkConnectivityRegionalEndpointSpec Spec { get; set; }

    /// <summary>NetworkConnectivityRegionalEndpointStatus defines the config connector machine state of NetworkConnectivityRegionalEndpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1NetworkConnectivityRegionalEndpointStatus? Status { get; set; }
}