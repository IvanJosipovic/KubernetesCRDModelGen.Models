#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.memorystore.cnrm.cloud.google.com;
/// <summary>MemorystoreInstanceEndpoint is the Schema for the MemorystoreInstanceEndpoint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MemorystoreInstanceEndpointList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MemorystoreInstanceEndpoint>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MemorystoreInstanceEndpointList";
    public const string KubeGroup = "memorystore.cnrm.cloud.google.com";
    public const string KubePluralName = "memorystoreinstanceendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemorystoreInstanceEndpointList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MemorystoreInstanceEndpoint objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MemorystoreInstanceEndpoint> Items { get; set; }
}

/// <summary>Required. The consumer side forwarding rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointSpecEndpointsConnectionsPscConnectionForwardingRuleRef
{
    /// <summary>A reference to an externally managed ComputeForwardingRule resource. Should be in the format &quot;projects/{{projectID}}/global/forwardingRules/{{forwardingRuleID}}&quot; or &quot;projects/{{projectID}}/regions/{{region}}/forwardingRules/{{forwardingRuleID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeForwardingRule resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeForwardingRule resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Detailed information of a PSC connection that is created by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointSpecEndpointsConnectionsPscConnection
{
    /// <summary>Required. The consumer side forwarding rule.</summary>
    [JsonPropertyName("forwardingRuleRef")]
    public required V1alpha1MemorystoreInstanceEndpointSpecEndpointsConnectionsPscConnectionForwardingRuleRef ForwardingRuleRef { get; set; }

    /// <summary>Optional. The port number of the PSC connection. Port will only be set for Primary/Reader or Discovery endpoint.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointSpecEndpointsConnections
{
    /// <summary>Optional. Detailed information of a PSC connection that is created by the user.</summary>
    [JsonPropertyName("pscConnection")]
    public V1alpha1MemorystoreInstanceEndpointSpecEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointSpecEndpoints
{
    /// <summary>Optional. A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.</summary>
    [JsonPropertyName("connections")]
    public IList<V1alpha1MemorystoreInstanceEndpointSpecEndpointsConnections>? Connections { get; set; }
}

/// <summary>Required. The Memorystore instance reference of the endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointSpecInstanceRef
{
    /// <summary>A reference to an externally managed MemorystoreInstance resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/instances/{{instanceID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a MemorystoreInstance resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a MemorystoreInstance resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>MemorystoreInstanceEndpointSpec defines the desired state of MemorystoreInstanceEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointSpec
{
    /// <summary>Optional. Endpoints for the instance.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1alpha1MemorystoreInstanceEndpointSpecEndpoints>? Endpoints { get; set; }

    /// <summary>Required. The Memorystore instance reference of the endpoint.</summary>
    [JsonPropertyName("instanceRef")]
    public required V1alpha1MemorystoreInstanceEndpointSpecInstanceRef InstanceRef { get; set; }

    /// <summary>Optional. The MemorystoreInstanceEndpoint name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointStatusConditions
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

/// <summary>Optional. Detailed information of a PSC connection that is created through service connectivity automation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointStatusObservedStateEndpointsConnectionsPscConnection
{
    /// <summary>Output only. Type of the PSC connection. For valid values, see https://docs.cloud.google.com/memorystore/docs/valkey/reference/rest/v1/projects.locations.instances#connectiontype</summary>
    [JsonPropertyName("connectionType")]
    public string? ConnectionType { get; set; }

    /// <summary>Output only. The consumer project_id where the forwarding rule is created from.</summary>
    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    /// <summary>Output only. The status of the PSC connection: whether a connection exists and ACTIVE or it no longer exists. Please note that this value is updated periodically. Please use Private Service Connect APIs for the latest status. For valid values, see https://docs.cloud.google.com/memorystore/docs/valkey/reference/rest/v1/projects.locations.instances#pscconnectionstatus</summary>
    [JsonPropertyName("pscConnectionStatus")]
    public string? PscConnectionStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointStatusObservedStateEndpointsConnections
{
    /// <summary>Optional. Detailed information of a PSC connection that is created through service connectivity automation.</summary>
    [JsonPropertyName("pscConnection")]
    public V1alpha1MemorystoreInstanceEndpointStatusObservedStateEndpointsConnectionsPscConnection? PscConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointStatusObservedStateEndpoints
{
    /// <summary>Optional. A group of PSC connections. They are created in the same VPC network, one for each service attachment in the cluster.</summary>
    [JsonPropertyName("connections")]
    public IList<V1alpha1MemorystoreInstanceEndpointStatusObservedStateEndpointsConnections>? Connections { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointStatusObservedState
{
    /// <summary>Optional. Endpoints for the instance.</summary>
    [JsonPropertyName("endpoints")]
    public IList<V1alpha1MemorystoreInstanceEndpointStatusObservedStateEndpoints>? Endpoints { get; set; }
}

/// <summary>MemorystoreInstanceEndpointStatus defines the config connector machine state of MemorystoreInstanceEndpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MemorystoreInstanceEndpointStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MemorystoreInstanceEndpointStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1MemorystoreInstanceEndpointStatusObservedState? ObservedState { get; set; }
}

/// <summary>MemorystoreInstanceEndpoint is the Schema for the MemorystoreInstanceEndpoint API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MemorystoreInstanceEndpoint : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MemorystoreInstanceEndpointSpec>, IStatus<V1alpha1MemorystoreInstanceEndpointStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MemorystoreInstanceEndpoint";
    public const string KubeGroup = "memorystore.cnrm.cloud.google.com";
    public const string KubePluralName = "memorystoreinstanceendpoints";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "memorystore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MemorystoreInstanceEndpoint";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MemorystoreInstanceEndpointSpec defines the desired state of MemorystoreInstanceEndpoint</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1MemorystoreInstanceEndpointSpec Spec { get; set; }

    /// <summary>MemorystoreInstanceEndpointStatus defines the config connector machine state of MemorystoreInstanceEndpoint</summary>
    [JsonPropertyName("status")]
    public V1alpha1MemorystoreInstanceEndpointStatus? Status { get; set; }
}