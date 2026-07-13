#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.dialogflow.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowFulfillmentList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DialogflowFulfillment>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowFulfillmentList";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowfulfillments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowFulfillmentList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DialogflowFulfillment objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DialogflowFulfillment> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowFulfillmentSpecFeatures
{
    /// <summary>
    /// The type of the feature that enabled for fulfillment.
    /// * SMALLTALK: Fulfillment is enabled for SmallTalk. Possible values: [&quot;SMALLTALK&quot;].
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Represents configuration for a generic web service. Dialogflow supports two mechanisms for authentications: - Basic authentication with username and password. - Authentication with additional authentication headers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowFulfillmentSpecGenericWebService
{
    /// <summary>The password for HTTP Basic authentication.</summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>The HTTP request headers to send together with fulfillment requests.</summary>
    [JsonPropertyName("requestHeaders")]
    public IDictionary<string, string>? RequestHeaders { get; set; }

    /// <summary>The fulfillment URI for receiving POST requests. It must use https protocol.</summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; set; }

    /// <summary>The user name for HTTP Basic authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowFulfillmentSpecProjectRef
{
    /// <summary>Allowed value: The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowFulfillmentSpec
{
    /// <summary>The human-readable name of the fulfillment, unique within the agent.</summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>Whether fulfillment is enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The field defines whether the fulfillment is enabled for certain features.</summary>
    [JsonPropertyName("features")]
    public IList<V1alpha1DialogflowFulfillmentSpecFeatures>? Features { get; set; }

    /// <summary>Represents configuration for a generic web service. Dialogflow supports two mechanisms for authentications: - Basic authentication with username and password. - Authentication with additional authentication headers.</summary>
    [JsonPropertyName("genericWebService")]
    public V1alpha1DialogflowFulfillmentSpecGenericWebService? GenericWebService { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DialogflowFulfillmentSpecProjectRef ProjectRef { get; set; }

    /// <summary>Immutable. Optional. The service-generated name of the resource. Used for acquisition only. Leave unset to create a new resource.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DialogflowFulfillmentStatusConditions
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
public partial class V1alpha1DialogflowFulfillmentStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DialogflowFulfillmentStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The unique identifier of the fulfillment.
    /// Format: projects/&lt;Project ID&gt;/agent/fulfillment - projects/&lt;Project ID&gt;/locations/&lt;Location ID&gt;/agent/fulfillment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DialogflowFulfillment : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DialogflowFulfillmentSpec>, IStatus<V1alpha1DialogflowFulfillmentStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DialogflowFulfillment";
    public const string KubeGroup = "dialogflow.cnrm.cloud.google.com";
    public const string KubePluralName = "dialogflowfulfillments";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "dialogflow.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DialogflowFulfillment";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1DialogflowFulfillmentSpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1DialogflowFulfillmentStatus? Status { get; set; }
}