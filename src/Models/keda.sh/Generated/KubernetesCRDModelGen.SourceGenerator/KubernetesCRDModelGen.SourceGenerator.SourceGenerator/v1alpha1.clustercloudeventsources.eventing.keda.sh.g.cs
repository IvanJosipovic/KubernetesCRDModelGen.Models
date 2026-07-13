#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.eventing.keda.sh;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterCloudEventSourceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ClusterCloudEventSource>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterCloudEventSourceList";
    public const string KubeGroup = "eventing.keda.sh";
    public const string KubePluralName = "clustercloudeventsources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventing.keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterCloudEventSourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ClusterCloudEventSource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ClusterCloudEventSource> Items { get; set; }
}

/// <summary>Kind of the resource being referred to. Defaults to TriggerAuthentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterCloudEventSourceSpecAuthenticationRefKindEnum>))]
public enum V1alpha1ClusterCloudEventSourceSpecAuthenticationRefKindEnum
{
    [EnumMember(Value = "TriggerAuthentication"), JsonStringEnumMemberName("TriggerAuthentication")]
    TriggerAuthentication,
    [EnumMember(Value = "ClusterTriggerAuthentication"), JsonStringEnumMemberName("ClusterTriggerAuthentication")]
    ClusterTriggerAuthentication
}

/// <summary>
/// AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that
/// is used to authenticate the scaler with the environment
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecAuthenticationRef
{
    /// <summary>Kind of the resource being referred to. Defaults to TriggerAuthentication.</summary>
    [JsonPropertyName("kind")]
    public V1alpha1ClusterCloudEventSourceSpecAuthenticationRefKindEnum? Kind { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecDestinationAzureEventGridTopic
{
    [JsonPropertyName("endpoint")]
    public required string Endpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecDestinationHttp
{
    [JsonPropertyName("uri")]
    public required string Uri { get; set; }
}

/// <summary>Destination defines the various ways to emit events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecDestination
{
    [JsonPropertyName("azureEventGridTopic")]
    public V1alpha1ClusterCloudEventSourceSpecDestinationAzureEventGridTopic? AzureEventGridTopic { get; set; }

    [JsonPropertyName("http")]
    public V1alpha1ClusterCloudEventSourceSpecDestinationHttp? Http { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterCloudEventSourceSpecEventSubscriptionExcludedEventTypesEnum>))]
public enum V1alpha1ClusterCloudEventSourceSpecEventSubscriptionExcludedEventTypesEnum
{
    [EnumMember(Value = "keda.scaledobject.ready.v1"), JsonStringEnumMemberName("keda.scaledobject.ready.v1")]
    KedaScaledobjectReadyV1,
    [EnumMember(Value = "keda.scaledobject.failed.v1"), JsonStringEnumMemberName("keda.scaledobject.failed.v1")]
    KedaScaledobjectFailedV1,
    [EnumMember(Value = "keda.scaledobject.removed.v1"), JsonStringEnumMemberName("keda.scaledobject.removed.v1")]
    KedaScaledobjectRemovedV1,
    [EnumMember(Value = "keda.scaledobject.paused.v1"), JsonStringEnumMemberName("keda.scaledobject.paused.v1")]
    KedaScaledobjectPausedV1,
    [EnumMember(Value = "keda.scaledobject.unpaused.v1"), JsonStringEnumMemberName("keda.scaledobject.unpaused.v1")]
    KedaScaledobjectUnpausedV1,
    [EnumMember(Value = "keda.scaledjob.ready.v1"), JsonStringEnumMemberName("keda.scaledjob.ready.v1")]
    KedaScaledjobReadyV1,
    [EnumMember(Value = "keda.scaledjob.failed.v1"), JsonStringEnumMemberName("keda.scaledjob.failed.v1")]
    KedaScaledjobFailedV1,
    [EnumMember(Value = "keda.scaledjob.removed.v1"), JsonStringEnumMemberName("keda.scaledjob.removed.v1")]
    KedaScaledjobRemovedV1,
    [EnumMember(Value = "keda.scaledjob.paused.v1"), JsonStringEnumMemberName("keda.scaledjob.paused.v1")]
    KedaScaledjobPausedV1,
    [EnumMember(Value = "keda.scaledjob.unpaused.v1"), JsonStringEnumMemberName("keda.scaledjob.unpaused.v1")]
    KedaScaledjobUnpausedV1,
    [EnumMember(Value = "keda.scaledjob.rolloutcleanup.started.v1"), JsonStringEnumMemberName("keda.scaledjob.rolloutcleanup.started.v1")]
    KedaScaledjobRolloutcleanupStartedV1,
    [EnumMember(Value = "keda.scaledjob.rolloutcleanup.completed.v1"), JsonStringEnumMemberName("keda.scaledjob.rolloutcleanup.completed.v1")]
    KedaScaledjobRolloutcleanupCompletedV1,
    [EnumMember(Value = "keda.scaledjob.rolloutcleanup.failed.v1"), JsonStringEnumMemberName("keda.scaledjob.rolloutcleanup.failed.v1")]
    KedaScaledjobRolloutcleanupFailedV1,
    [EnumMember(Value = "keda.authentication.triggerauthentication.created.v1"), JsonStringEnumMemberName("keda.authentication.triggerauthentication.created.v1")]
    KedaAuthenticationTriggerauthenticationCreatedV1,
    [EnumMember(Value = "keda.authentication.triggerauthentication.updated.v1"), JsonStringEnumMemberName("keda.authentication.triggerauthentication.updated.v1")]
    KedaAuthenticationTriggerauthenticationUpdatedV1,
    [EnumMember(Value = "keda.authentication.triggerauthentication.removed.v1"), JsonStringEnumMemberName("keda.authentication.triggerauthentication.removed.v1")]
    KedaAuthenticationTriggerauthenticationRemovedV1,
    [EnumMember(Value = "keda.authentication.clustertriggerauthentication.created.v1"), JsonStringEnumMemberName("keda.authentication.clustertriggerauthentication.created.v1")]
    KedaAuthenticationClustertriggerauthenticationCreatedV1,
    [EnumMember(Value = "keda.authentication.clustertriggerauthentication.updated.v1"), JsonStringEnumMemberName("keda.authentication.clustertriggerauthentication.updated.v1")]
    KedaAuthenticationClustertriggerauthenticationUpdatedV1,
    [EnumMember(Value = "keda.authentication.clustertriggerauthentication.removed.v1"), JsonStringEnumMemberName("keda.authentication.clustertriggerauthentication.removed.v1")]
    KedaAuthenticationClustertriggerauthenticationRemovedV1
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1ClusterCloudEventSourceSpecEventSubscriptionIncludedEventTypesEnum>))]
public enum V1alpha1ClusterCloudEventSourceSpecEventSubscriptionIncludedEventTypesEnum
{
    [EnumMember(Value = "keda.scaledobject.ready.v1"), JsonStringEnumMemberName("keda.scaledobject.ready.v1")]
    KedaScaledobjectReadyV1,
    [EnumMember(Value = "keda.scaledobject.failed.v1"), JsonStringEnumMemberName("keda.scaledobject.failed.v1")]
    KedaScaledobjectFailedV1,
    [EnumMember(Value = "keda.scaledobject.removed.v1"), JsonStringEnumMemberName("keda.scaledobject.removed.v1")]
    KedaScaledobjectRemovedV1,
    [EnumMember(Value = "keda.scaledobject.paused.v1"), JsonStringEnumMemberName("keda.scaledobject.paused.v1")]
    KedaScaledobjectPausedV1,
    [EnumMember(Value = "keda.scaledobject.unpaused.v1"), JsonStringEnumMemberName("keda.scaledobject.unpaused.v1")]
    KedaScaledobjectUnpausedV1,
    [EnumMember(Value = "keda.scaledjob.ready.v1"), JsonStringEnumMemberName("keda.scaledjob.ready.v1")]
    KedaScaledjobReadyV1,
    [EnumMember(Value = "keda.scaledjob.failed.v1"), JsonStringEnumMemberName("keda.scaledjob.failed.v1")]
    KedaScaledjobFailedV1,
    [EnumMember(Value = "keda.scaledjob.removed.v1"), JsonStringEnumMemberName("keda.scaledjob.removed.v1")]
    KedaScaledjobRemovedV1,
    [EnumMember(Value = "keda.scaledjob.paused.v1"), JsonStringEnumMemberName("keda.scaledjob.paused.v1")]
    KedaScaledjobPausedV1,
    [EnumMember(Value = "keda.scaledjob.unpaused.v1"), JsonStringEnumMemberName("keda.scaledjob.unpaused.v1")]
    KedaScaledjobUnpausedV1,
    [EnumMember(Value = "keda.scaledjob.rolloutcleanup.started.v1"), JsonStringEnumMemberName("keda.scaledjob.rolloutcleanup.started.v1")]
    KedaScaledjobRolloutcleanupStartedV1,
    [EnumMember(Value = "keda.scaledjob.rolloutcleanup.completed.v1"), JsonStringEnumMemberName("keda.scaledjob.rolloutcleanup.completed.v1")]
    KedaScaledjobRolloutcleanupCompletedV1,
    [EnumMember(Value = "keda.scaledjob.rolloutcleanup.failed.v1"), JsonStringEnumMemberName("keda.scaledjob.rolloutcleanup.failed.v1")]
    KedaScaledjobRolloutcleanupFailedV1,
    [EnumMember(Value = "keda.authentication.triggerauthentication.created.v1"), JsonStringEnumMemberName("keda.authentication.triggerauthentication.created.v1")]
    KedaAuthenticationTriggerauthenticationCreatedV1,
    [EnumMember(Value = "keda.authentication.triggerauthentication.updated.v1"), JsonStringEnumMemberName("keda.authentication.triggerauthentication.updated.v1")]
    KedaAuthenticationTriggerauthenticationUpdatedV1,
    [EnumMember(Value = "keda.authentication.triggerauthentication.removed.v1"), JsonStringEnumMemberName("keda.authentication.triggerauthentication.removed.v1")]
    KedaAuthenticationTriggerauthenticationRemovedV1,
    [EnumMember(Value = "keda.authentication.clustertriggerauthentication.created.v1"), JsonStringEnumMemberName("keda.authentication.clustertriggerauthentication.created.v1")]
    KedaAuthenticationClustertriggerauthenticationCreatedV1,
    [EnumMember(Value = "keda.authentication.clustertriggerauthentication.updated.v1"), JsonStringEnumMemberName("keda.authentication.clustertriggerauthentication.updated.v1")]
    KedaAuthenticationClustertriggerauthenticationUpdatedV1,
    [EnumMember(Value = "keda.authentication.clustertriggerauthentication.removed.v1"), JsonStringEnumMemberName("keda.authentication.clustertriggerauthentication.removed.v1")]
    KedaAuthenticationClustertriggerauthenticationRemovedV1
}

/// <summary>EventSubscription defines filters for events</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpecEventSubscription
{
    [JsonPropertyName("excludedEventTypes")]
    public IList<V1alpha1ClusterCloudEventSourceSpecEventSubscriptionExcludedEventTypesEnum>? ExcludedEventTypes { get; set; }

    [JsonPropertyName("includedEventTypes")]
    public IList<V1alpha1ClusterCloudEventSourceSpecEventSubscriptionIncludedEventTypesEnum>? IncludedEventTypes { get; set; }
}

/// <summary>CloudEventSourceSpec defines the spec of CloudEventSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceSpec
{
    /// <summary>
    /// AuthenticationRef points to the TriggerAuthentication or ClusterTriggerAuthentication object that
    /// is used to authenticate the scaler with the environment
    /// </summary>
    [JsonPropertyName("authenticationRef")]
    public V1alpha1ClusterCloudEventSourceSpecAuthenticationRef? AuthenticationRef { get; set; }

    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Destination defines the various ways to emit events</summary>
    [JsonPropertyName("destination")]
    public required V1alpha1ClusterCloudEventSourceSpecDestination Destination { get; set; }

    /// <summary>EventSubscription defines filters for events</summary>
    [JsonPropertyName("eventSubscription")]
    public V1alpha1ClusterCloudEventSourceSpecEventSubscription? EventSubscription { get; set; }
}

/// <summary>Condition to store the condition state</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceStatusConditions
{
    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>CloudEventSourceStatus defines the observed state of CloudEventSource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ClusterCloudEventSourceStatus
{
    /// <summary>Conditions an array representation to store multiple Conditions</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ClusterCloudEventSourceStatusConditions>? Conditions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ClusterCloudEventSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ClusterCloudEventSourceSpec>, IStatus<V1alpha1ClusterCloudEventSourceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ClusterCloudEventSource";
    public const string KubeGroup = "eventing.keda.sh";
    public const string KubePluralName = "clustercloudeventsources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "eventing.keda.sh/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ClusterCloudEventSource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CloudEventSourceSpec defines the spec of CloudEventSource</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1ClusterCloudEventSourceSpec Spec { get; set; }

    /// <summary>CloudEventSourceStatus defines the observed state of CloudEventSource</summary>
    [JsonPropertyName("status")]
    public V1alpha1ClusterCloudEventSourceStatus? Status { get; set; }
}