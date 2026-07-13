#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.knative.dev;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RequestReplyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1RequestReply>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RequestReplyList";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "requestreplies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventing.knative.dev/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RequestReplyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1RequestReply objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1RequestReply> Items { get; set; }
}

/// <summary>A KReference referring to the broker this RequestReply forwards events to. CrossNamespace references are not allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplySpecBrokerRef
{
    /// <summary>API Version of the broker.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>Kind of the broker. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the broker. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Spec defines the desired state of the RequestReply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplySpec
{
    /// <summary>A KReference referring to the broker this RequestReply forwards events to. CrossNamespace references are not allowed.</summary>
    [JsonPropertyName("brokerRef")]
    public V1alpha1RequestReplySpecBrokerRef? BrokerRef { get; set; }

    /// <summary>The name of the cloudevent attribute where the correlation id will be set on new events.</summary>
    [JsonPropertyName("correlationAttribute")]
    public string? CorrelationAttribute { get; set; }

    /// <summary>The name of the cloudevents attribute which will hold the correlation id for an event which will be treated as a reply.</summary>
    [JsonPropertyName("replyAttribute")]
    public string? ReplyAttribute { get; set; }

    /// <summary>A ISO8601 string representing how long RequestReply holds onto an incoming request before it times out without a reply.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Delivery contains the delivery spec for each trigger to this Broker. Each trigger delivery spec, if any, overrides this global delivery spec.</summary>
    [JsonPropertyName("delivery")]
    public JsonNode? Delivery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplyStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another. We use VolatileTime in place of metav1.Time to exclude this from creating equality.Semantic differences (all other things held constant).</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Severity with which to treat failures of this type of condition. When this is not specified, it defaults to Error.</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>RequestReply is Addressable. It exposes the endpoint as an URI to get events delivered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplyStatusAddress
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplyStatusAddresses
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("CACerts")]
    public string? CACerts { get; set; }

    [JsonPropertyName("audience")]
    public string? Audience { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplyStatusPolicies
{
    /// <summary>The API version of the applied EventPolicy. This indicates whichversion of EventPolicy is supported by the resource.</summary>
    [JsonPropertyName("apiVersion")]
    public string? ApiVersion { get; set; }

    /// <summary>The name of the applied EventPolicy</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Status represents the current state of the RequestReply. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1RequestReplyStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Conditions the latest available observations of a resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1RequestReplyStatusConditions>? Conditions { get; set; }

    /// <summary>The current replicas (StatefulSet pod + trigger) that are desired</summary>
    [JsonPropertyName("desiredReplicas")]
    public int? DesiredReplicas { get; set; }

    /// <summary>The current replicas (StatefulSet pod + trigger) that are ready</summary>
    [JsonPropertyName("readyReplicas")]
    public int? ReadyReplicas { get; set; }

    /// <summary>RequestReply is Addressable. It exposes the endpoint as an URI to get events delivered.</summary>
    [JsonPropertyName("address")]
    public V1alpha1RequestReplyStatusAddress? Address { get; set; }

    /// <summary>RequestReply is Addressable. It exposes the endpoints as URIs to get events delivered.</summary>
    [JsonPropertyName("addresses")]
    public IList<V1alpha1RequestReplyStatusAddresses>? Addresses { get; set; }

    /// <summary>List of applied EventPolicies</summary>
    [JsonPropertyName("policies")]
    public IList<V1alpha1RequestReplyStatusPolicies>? Policies { get; set; }

    /// <summary>ObservedGeneration is the &apos;Generation&apos; of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1RequestReply : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1RequestReplySpec?>, IStatus<V1alpha1RequestReplyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "RequestReply";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "requestreplies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventing.knative.dev/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RequestReply";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the RequestReply.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1RequestReplySpec? Spec { get; set; }

    /// <summary>Status represents the current state of the RequestReply. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1alpha1RequestReplyStatus? Status { get; set; }
}