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
/// <summary>Trigger represents a request to have events delivered to a subscriber from a Broker&apos;s event pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1TriggerList : IKubernetesObject<V1ListMeta>, IItems<V1Trigger>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "TriggerList";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "triggers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventing.knative.dev/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TriggerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Trigger objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Trigger> Items { get; set; }
}

/// <summary>Auth provides the relevant information for OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TriggerStatusAuth
{
    /// <summary>ServiceAccountName is the name of the generated service account used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>ServiceAccountNames is the list of names of the generated service accounts used for this components OIDC authentication.</summary>
    [JsonPropertyName("serviceAccountNames")]
    public IList<string>? ServiceAccountNames { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TriggerStatusConditions
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

/// <summary>Status represents the current state of the Trigger. This data may be out of date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1TriggerStatus
{
    /// <summary>Annotations is additional Status fields for the Resource to save some additional State as well as convey more information to the user. This is roughly akin to Annotations on any k8s resource, just the reconciler conveying richer information outwards.</summary>
    [JsonPropertyName("annotations")]
    public JsonNode? Annotations { get; set; }

    /// <summary>Auth provides the relevant information for OIDC authentication.</summary>
    [JsonPropertyName("auth")]
    public V1TriggerStatusAuth? Auth { get; set; }

    /// <summary>Conditions the latest available observations of a resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1TriggerStatusConditions>? Conditions { get; set; }

    /// <summary>DeadLetterSinkURI is the resolved URI of the dead letter sink for this Trigger, in case there is none this will fallback to it&apos;s Broker status DeadLetterSinkURI.</summary>
    [JsonPropertyName("deadLetterSinkUri")]
    public string? DeadLetterSinkUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("deadLetterSinkCACerts")]
    public string? DeadLetterSinkCACerts { get; set; }

    /// <summary>OIDC audience of the dead letter sink.</summary>
    [JsonPropertyName("deadLetterSinkAudience")]
    public string? DeadLetterSinkAudience { get; set; }

    /// <summary>ObservedGeneration is the &apos;Generation&apos; of the Service that was last processed by the controller.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>SubscriberURI is the resolved URI of the receiver for this Trigger.</summary>
    [JsonPropertyName("subscriberUri")]
    public string? SubscriberUri { get; set; }

    /// <summary>Certification Authority (CA) certificates in PEM format according to https://www.rfc-editor.org/rfc/rfc7468.</summary>
    [JsonPropertyName("subscriberCACerts")]
    public string? SubscriberCACerts { get; set; }

    /// <summary>OIDC audience of the subscriber.</summary>
    [JsonPropertyName("subscriberAudience")]
    public string? SubscriberAudience { get; set; }
}

/// <summary>Trigger represents a request to have events delivered to a subscriber from a Broker&apos;s event pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Trigger : IKubernetesObject<V1ObjectMeta>, ISpec<JsonNode?>, IStatus<V1TriggerStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Trigger";
    public const string KubeGroup = "eventing.knative.dev";
    public const string KubePluralName = "triggers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventing.knative.dev/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Trigger";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Spec defines the desired state of the Trigger.</summary>
    [JsonPropertyName("spec")]
    public JsonNode? Spec { get; set; }

    /// <summary>Status represents the current state of the Trigger. This data may be out of date.</summary>
    [JsonPropertyName("status")]
    public V1TriggerStatus? Status { get; set; }
}