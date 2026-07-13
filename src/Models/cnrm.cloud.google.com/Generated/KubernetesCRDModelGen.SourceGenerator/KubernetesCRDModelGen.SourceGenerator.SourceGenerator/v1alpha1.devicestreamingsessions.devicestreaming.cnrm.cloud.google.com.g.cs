#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.devicestreaming.cnrm.cloud.google.com;
/// <summary>DeviceStreamingSession is the Schema for the DeviceStreamingSession API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeviceStreamingSessionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1DeviceStreamingSession>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeviceStreamingSessionList";
    public const string KubeGroup = "devicestreaming.cnrm.cloud.google.com";
    public const string KubePluralName = "devicestreamingsessions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devicestreaming.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeviceStreamingSessionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1DeviceStreamingSession objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1DeviceStreamingSession> Items { get; set; }
}

/// <summary>Required. The requested device</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeviceStreamingSessionSpecAndroidDevice
{
    /// <summary>Required. The id of the Android device to be used. Use the TestEnvironmentDiscoveryService to get supported options.</summary>
    [JsonPropertyName("androidModelID")]
    public required string AndroidModelID { get; set; }

    /// <summary>Required. The id of the Android OS version to be used. Use the TestEnvironmentDiscoveryService to get supported options.</summary>
    [JsonPropertyName("androidVersionID")]
    public required string AndroidVersionID { get; set; }

    /// <summary>Optional. The locale the test device used for testing. Use the TestEnvironmentDiscoveryService to get supported options.</summary>
    [JsonPropertyName("locale")]
    public string? Locale { get; set; }

    /// <summary>Optional. How the device is oriented during the test. Use the TestEnvironmentDiscoveryService to get supported options.</summary>
    [JsonPropertyName("orientation")]
    public string? Orientation { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeviceStreamingSessionSpecProjectRef
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

/// <summary>DeviceStreamingSessionSpec defines the desired state of DeviceStreamingSession</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeviceStreamingSessionSpec
{
    /// <summary>Required. The requested device</summary>
    [JsonPropertyName("androidDevice")]
    public required V1alpha1DeviceStreamingSessionSpecAndroidDevice AndroidDevice { get; set; }

    /// <summary>Optional. If the device is still in use at this time, any connections will be ended and the SessionState will transition from ACTIVE to FINISHED.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1DeviceStreamingSessionSpecProjectRef ProjectRef { get; set; }

    /// <summary>The DeviceStreamingSession name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Optional. The amount of time that a device will be initially allocated for. This can eventually be extended with the UpdateDeviceSession RPC. Default: 15 minutes.</summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeviceStreamingSessionStatusConditions
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
public partial class V1alpha1DeviceStreamingSessionStatusObservedStateStateHistories
{
    /// <summary>Output only. The time that the session_state first encountered that state.</summary>
    [JsonPropertyName("eventTime")]
    public string? EventTime { get; set; }

    /// <summary>Output only. The session_state tracked by this event</summary>
    [JsonPropertyName("sessionState")]
    public string? SessionState { get; set; }

    /// <summary>Output only. A human-readable message to explain the state.</summary>
    [JsonPropertyName("stateMessage")]
    public string? StateMessage { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeviceStreamingSessionStatusObservedState
{
    /// <summary>Output only. The timestamp that the session first became ACTIVE.</summary>
    [JsonPropertyName("activeStartTime")]
    public string? ActiveStartTime { get; set; }

    /// <summary>Output only. The time that the Session was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The title of the DeviceSession to be presented in the UI.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Output only. The interval of time that this device must be interacted with before it transitions from ACTIVE to TIMEOUT_INACTIVITY.</summary>
    [JsonPropertyName("inactivityTimeout")]
    public string? InactivityTimeout { get; set; }

    /// <summary>Output only. Current state of the DeviceSession.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. The historical state transitions of the session_state message including the current session state.</summary>
    [JsonPropertyName("stateHistories")]
    public IList<V1alpha1DeviceStreamingSessionStatusObservedStateStateHistories>? StateHistories { get; set; }
}

/// <summary>DeviceStreamingSessionStatus defines the config connector machine state of DeviceStreamingSession</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1DeviceStreamingSessionStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1DeviceStreamingSessionStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the DeviceStreamingSession resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1DeviceStreamingSessionStatusObservedState? ObservedState { get; set; }
}

/// <summary>DeviceStreamingSession is the Schema for the DeviceStreamingSession API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1DeviceStreamingSession : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1DeviceStreamingSessionSpec>, IStatus<V1alpha1DeviceStreamingSessionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "DeviceStreamingSession";
    public const string KubeGroup = "devicestreaming.cnrm.cloud.google.com";
    public const string KubePluralName = "devicestreamingsessions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "devicestreaming.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeviceStreamingSession";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeviceStreamingSessionSpec defines the desired state of DeviceStreamingSession</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1DeviceStreamingSessionSpec Spec { get; set; }

    /// <summary>DeviceStreamingSessionStatus defines the config connector machine state of DeviceStreamingSession</summary>
    [JsonPropertyName("status")]
    public V1alpha1DeviceStreamingSessionStatus? Status { get; set; }
}