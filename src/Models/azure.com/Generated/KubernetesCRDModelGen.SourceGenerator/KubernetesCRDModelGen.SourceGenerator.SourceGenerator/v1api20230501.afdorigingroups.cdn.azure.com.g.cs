#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cdn.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501AfdOriginGroupList : IKubernetesObject<V1ListMeta>, IItems<V1api20230501AfdOriginGroup>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "AfdOriginGroupList";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "afdorigingroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AfdOriginGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230501AfdOriginGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230501AfdOriginGroup> Items { get; set; }
}

/// <summary>ProbeProtocol: Protocol to use for health probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501AfdOriginGroupSpecHealthProbeSettingsProbeProtocolEnum>))]
public enum V1api20230501AfdOriginGroupSpecHealthProbeSettingsProbeProtocolEnum
{
    [EnumMember(Value = "Http"), JsonStringEnumMemberName("Http")]
    Http,
    [EnumMember(Value = "Https"), JsonStringEnumMemberName("Https")]
    Https,
    [EnumMember(Value = "NotSet"), JsonStringEnumMemberName("NotSet")]
    NotSet
}

/// <summary>ProbeRequestType: The type of health probe request that is made.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501AfdOriginGroupSpecHealthProbeSettingsProbeRequestTypeEnum>))]
public enum V1api20230501AfdOriginGroupSpecHealthProbeSettingsProbeRequestTypeEnum
{
    [EnumMember(Value = "GET"), JsonStringEnumMemberName("GET")]
    GET,
    [EnumMember(Value = "HEAD"), JsonStringEnumMemberName("HEAD")]
    HEAD,
    [EnumMember(Value = "NotSet"), JsonStringEnumMemberName("NotSet")]
    NotSet
}

/// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpecHealthProbeSettings
{
    /// <summary>ProbeIntervalInSeconds: The number of seconds between health probes.Default is 240sec.</summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary>ProbePath: The path relative to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>ProbeProtocol: Protocol to use for health probe.</summary>
    [JsonPropertyName("probeProtocol")]
    public V1api20230501AfdOriginGroupSpecHealthProbeSettingsProbeProtocolEnum? ProbeProtocol { get; set; }

    /// <summary>ProbeRequestType: The type of health probe request that is made.</summary>
    [JsonPropertyName("probeRequestType")]
    public V1api20230501AfdOriginGroupSpecHealthProbeSettingsProbeRequestTypeEnum? ProbeRequestType { get; set; }
}

/// <summary>LoadBalancingSettings: Load balancing settings for a backend pool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpecLoadBalancingSettings
{
    /// <summary>AdditionalLatencyInMilliseconds: The additional latency in milliseconds for probes to fall into the lowest latency bucket</summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public int? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>SampleSize: The number of samples to consider for load balancing decisions</summary>
    [JsonPropertyName("sampleSize")]
    public int? SampleSize { get; set; }

    /// <summary>SuccessfulSamplesRequired: The number of samples within the sample period that must succeed</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public int? SuccessfulSamplesRequired { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230501AfdOriginGroupSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230501AfdOriginGroupSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a cdn.azure.com/Profile resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>SessionAffinityState: Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20230501AfdOriginGroupSpecSessionAffinityStateEnum>))]
public enum V1api20230501AfdOriginGroupSpecSessionAffinityStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20230501AfdOriginGroupSpecHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary>LoadBalancingSettings: Load balancing settings for a backend pool</summary>
    [JsonPropertyName("loadBalancingSettings")]
    public V1api20230501AfdOriginGroupSpecLoadBalancingSettings? LoadBalancingSettings { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230501AfdOriginGroupSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a cdn.azure.com/Profile resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230501AfdOriginGroupSpecOwner Owner { get; set; }

    /// <summary>SessionAffinityState: Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;</summary>
    [JsonPropertyName("sessionAffinityState")]
    public V1api20230501AfdOriginGroupSpecSessionAffinityStateEnum? SessionAffinityState { get; set; }

    /// <summary>
    /// TrafficRestorationTimeToHealedOrNewEndpointsInMinutes: Time in minutes to shift the traffic to the endpoint gradually
    /// when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not
    /// supported.
    /// </summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupStatusHealthProbeSettings
{
    /// <summary>ProbeIntervalInSeconds: The number of seconds between health probes.Default is 240sec.</summary>
    [JsonPropertyName("probeIntervalInSeconds")]
    public int? ProbeIntervalInSeconds { get; set; }

    /// <summary>ProbePath: The path relative to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("probePath")]
    public string? ProbePath { get; set; }

    /// <summary>ProbeProtocol: Protocol to use for health probe.</summary>
    [JsonPropertyName("probeProtocol")]
    public string? ProbeProtocol { get; set; }

    /// <summary>ProbeRequestType: The type of health probe request that is made.</summary>
    [JsonPropertyName("probeRequestType")]
    public string? ProbeRequestType { get; set; }
}

/// <summary>LoadBalancingSettings: Load balancing settings for a backend pool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupStatusLoadBalancingSettings
{
    /// <summary>AdditionalLatencyInMilliseconds: The additional latency in milliseconds for probes to fall into the lowest latency bucket</summary>
    [JsonPropertyName("additionalLatencyInMilliseconds")]
    public int? AdditionalLatencyInMilliseconds { get; set; }

    /// <summary>SampleSize: The number of samples to consider for load balancing decisions</summary>
    [JsonPropertyName("sampleSize")]
    public int? SampleSize { get; set; }

    /// <summary>SuccessfulSamplesRequired: The number of samples within the sample period that must succeed</summary>
    [JsonPropertyName("successfulSamplesRequired")]
    public int? SuccessfulSamplesRequired { get; set; }
}

/// <summary>SystemData: Read only system data</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC)</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: An identifier for the identity that created the resource</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: An identifier for the identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230501AfdOriginGroupStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20230501AfdOriginGroupStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("deploymentStatus")]
    public string? DeploymentStatus { get; set; }

    /// <summary>HealthProbeSettings: Health probe settings to the origin that is used to determine the health of the origin.</summary>
    [JsonPropertyName("healthProbeSettings")]
    public V1api20230501AfdOriginGroupStatusHealthProbeSettings? HealthProbeSettings { get; set; }

    /// <summary>Id: Resource ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>LoadBalancingSettings: Load balancing settings for a backend pool</summary>
    [JsonPropertyName("loadBalancingSettings")]
    public V1api20230501AfdOriginGroupStatusLoadBalancingSettings? LoadBalancingSettings { get; set; }

    /// <summary>Name: Resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProfileName: The name of the profile which holds the origin group.</summary>
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary>ProvisioningState: Provisioning status</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SessionAffinityState: Whether to allow session affinity on this host. Valid options are &apos;Enabled&apos; or &apos;Disabled&apos;</summary>
    [JsonPropertyName("sessionAffinityState")]
    public string? SessionAffinityState { get; set; }

    /// <summary>SystemData: Read only system data</summary>
    [JsonPropertyName("systemData")]
    public V1api20230501AfdOriginGroupStatusSystemData? SystemData { get; set; }

    /// <summary>
    /// TrafficRestorationTimeToHealedOrNewEndpointsInMinutes: Time in minutes to shift the traffic to the endpoint gradually
    /// when an unhealthy endpoint comes healthy or a new endpoint is added. Default is 10 mins. This property is currently not
    /// supported.
    /// </summary>
    [JsonPropertyName("trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
    public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }

    /// <summary>Type: Resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /cdn/resource-manager/Microsoft.Cdn/Cdn/stable/2023-05-01/afdx.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/originGroups/{originGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230501AfdOriginGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230501AfdOriginGroupSpec?>, IStatus<V1api20230501AfdOriginGroupStatus?>
{
    public const string KubeApiVersion = "v1api20230501";
    public const string KubeKind = "AfdOriginGroup";
    public const string KubeGroup = "cdn.azure.com";
    public const string KubePluralName = "afdorigingroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cdn.azure.com/v1api20230501";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AfdOriginGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20230501AfdOriginGroupSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20230501AfdOriginGroupStatus? Status { get; set; }
}