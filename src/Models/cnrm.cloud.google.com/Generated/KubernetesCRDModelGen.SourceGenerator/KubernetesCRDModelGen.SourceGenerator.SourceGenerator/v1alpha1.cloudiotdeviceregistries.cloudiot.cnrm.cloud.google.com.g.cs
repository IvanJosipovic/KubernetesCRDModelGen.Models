#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudiot.cnrm.cloud.google.com;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudIOTDeviceRegistryList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CloudIOTDeviceRegistry>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudIOTDeviceRegistryList";
    public const string KubeGroup = "cloudiot.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudiotdeviceregistries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudiot.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudIOTDeviceRegistryList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CloudIOTDeviceRegistry objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CloudIOTDeviceRegistry> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceRegistrySpecCredentials
{
    /// <summary>A public key certificate format and data.</summary>
    [JsonPropertyName("publicKeyCertificate")]
    public required JsonNode PublicKeyCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceRegistrySpecEventNotificationConfigs
{
    /// <summary>PubSub topic name to publish device events.</summary>
    [JsonPropertyName("pubsubTopicName")]
    public required string PubsubTopicName { get; set; }

    /// <summary>
    /// If the subfolder name matches this string exactly, this
    /// configuration will be used. The string must not include the
    /// leading &apos;/&apos; character. If empty, all strings are matched. Empty
    /// value can only be used for the last &apos;event_notification_configs&apos;
    /// item.
    /// </summary>
    [JsonPropertyName("subfolderMatches")]
    public string? SubfolderMatches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceRegistrySpec
{
    /// <summary>List of public key certificates to authenticate devices.</summary>
    [JsonPropertyName("credentials")]
    public IList<V1alpha1CloudIOTDeviceRegistrySpecCredentials>? Credentials { get; set; }

    /// <summary>
    /// List of configurations for event notifications, such as PubSub topics
    /// to publish device events to.
    /// </summary>
    [JsonPropertyName("eventNotificationConfigs")]
    public IList<V1alpha1CloudIOTDeviceRegistrySpecEventNotificationConfigs>? EventNotificationConfigs { get; set; }

    /// <summary>Activate or deactivate HTTP.</summary>
    [JsonPropertyName("httpConfig")]
    public JsonNode? HttpConfig { get; set; }

    /// <summary>
    /// The default logging verbosity for activity from devices in this
    /// registry. Specifies which events should be written to logs. For
    /// example, if the LogLevel is ERROR, only events that terminate in
    /// errors will be logged. LogLevel is inclusive; enabling INFO logging
    /// will also enable ERROR logging. Default value: &quot;NONE&quot; Possible values: [&quot;NONE&quot;, &quot;ERROR&quot;, &quot;INFO&quot;, &quot;DEBUG&quot;].
    /// </summary>
    [JsonPropertyName("logLevel")]
    public string? LogLevel { get; set; }

    /// <summary>Activate or deactivate MQTT.</summary>
    [JsonPropertyName("mqttConfig")]
    public JsonNode? MqttConfig { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Immutable. The region in which the created registry should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>A PubSub topic to publish device state updates.</summary>
    [JsonPropertyName("stateNotificationConfig")]
    public JsonNode? StateNotificationConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CloudIOTDeviceRegistryStatusConditions
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
public partial class V1alpha1CloudIOTDeviceRegistryStatus
{
    /// <summary>Conditions represent the latest available observation of the resource&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CloudIOTDeviceRegistryStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CloudIOTDeviceRegistry : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CloudIOTDeviceRegistrySpec>, IStatus<V1alpha1CloudIOTDeviceRegistryStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CloudIOTDeviceRegistry";
    public const string KubeGroup = "cloudiot.cnrm.cloud.google.com";
    public const string KubePluralName = "cloudiotdeviceregistries";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudiot.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CloudIOTDeviceRegistry";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public required V1alpha1CloudIOTDeviceRegistrySpec Spec { get; set; }

    [JsonPropertyName("status")]
    public V1alpha1CloudIOTDeviceRegistryStatus? Status { get; set; }
}