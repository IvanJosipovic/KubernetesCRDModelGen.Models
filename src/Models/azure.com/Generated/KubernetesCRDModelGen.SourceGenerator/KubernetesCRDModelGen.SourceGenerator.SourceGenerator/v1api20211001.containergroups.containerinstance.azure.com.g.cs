#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerinstance.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /containerinstance/resource-manager/Microsoft.ContainerInstance/ContainerInstance/stable/2021-10-01/containerInstance.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211001ContainerGroupList : IKubernetesObject<V1ListMeta>, IItems<V1api20211001ContainerGroup>
{
    public const string KubeApiVersion = "v1api20211001";
    public const string KubeKind = "ContainerGroupList";
    public const string KubeGroup = "containerinstance.azure.com";
    public const string KubePluralName = "containergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerinstance.azure.com/v1api20211001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20211001ContainerGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20211001ContainerGroup> Items { get; set; }
}

/// <summary>SecureValue: The value of the secure environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersEnvironmentVariablesSecureValue
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The environment variable to set within the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersEnvironmentVariables
{
    /// <summary>Name: The name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>SecureValue: The value of the secure environment variable.</summary>
    [JsonPropertyName("secureValue")]
    public V1api20211001ContainerGroupSpecContainersEnvironmentVariablesSecureValue? SecureValue { get; set; }

    /// <summary>Value: The value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Exec: The execution command to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersLivenessProbeExec
{
    /// <summary>Command: The commands to execute within the container.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>The HTTP header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Name: The header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Scheme: The scheme.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGetSchemeEnum>))]
public enum V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGetSchemeEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "https"), JsonStringEnumMemberName("https")]
    Https
}

/// <summary>HttpGet: The Http Get settings to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGet
{
    /// <summary>HttpHeaders: The HTTP headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: The path to probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port: The port number to probe.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Scheme: The scheme.</summary>
    [JsonPropertyName("scheme")]
    public V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGetSchemeEnum? Scheme { get; set; }
}

/// <summary>LivenessProbe: The liveness probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersLivenessProbe
{
    /// <summary>Exec: The execution command to probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001ContainerGroupSpecContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>FailureThreshold: The failure threshold.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: The Http Get settings to probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001ContainerGroupSpecContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>InitialDelaySeconds: The initial delay seconds.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>PeriodSeconds: The period seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>SuccessThreshold: The success threshold.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TimeoutSeconds: The timeout seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Protocol: The protocol associated with the port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecContainersPortsProtocolEnum>))]
public enum V1api20211001ContainerGroupSpecContainersPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port exposed on the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersPorts
{
    /// <summary>Port: The port number exposed within the container group.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Protocol: The protocol associated with the port.</summary>
    [JsonPropertyName("protocol")]
    public V1api20211001ContainerGroupSpecContainersPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>Exec: The execution command to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersReadinessProbeExec
{
    /// <summary>Command: The commands to execute within the container.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>The HTTP header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>Name: The header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Scheme: The scheme.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGetSchemeEnum>))]
public enum V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGetSchemeEnum
{
    [EnumMember(Value = "http"), JsonStringEnumMemberName("http")]
    Http,
    [EnumMember(Value = "https"), JsonStringEnumMemberName("https")]
    Https
}

/// <summary>HttpGet: The Http Get settings to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGet
{
    /// <summary>HttpHeaders: The HTTP headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: The path to probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port: The port number to probe.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Scheme: The scheme.</summary>
    [JsonPropertyName("scheme")]
    public V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGetSchemeEnum? Scheme { get; set; }
}

/// <summary>ReadinessProbe: The readiness probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersReadinessProbe
{
    /// <summary>Exec: The execution command to probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001ContainerGroupSpecContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>FailureThreshold: The failure threshold.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: The Http Get settings to probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001ContainerGroupSpecContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>InitialDelaySeconds: The initial delay seconds.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>PeriodSeconds: The period seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>SuccessThreshold: The success threshold.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TimeoutSeconds: The timeout seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Sku: The SKU of the GPU resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecContainersResourcesLimitsGpuSkuEnum>))]
public enum V1api20211001ContainerGroupSpecContainersResourcesLimitsGpuSkuEnum
{
    [EnumMember(Value = "K80"), JsonStringEnumMemberName("K80")]
    K80,
    [EnumMember(Value = "P100"), JsonStringEnumMemberName("P100")]
    P100,
    [EnumMember(Value = "V100"), JsonStringEnumMemberName("V100")]
    V100
}

/// <summary>Gpu: The GPU limit of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersResourcesLimitsGpu
{
    /// <summary>Count: The count of the GPU resource.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>Sku: The SKU of the GPU resource.</summary>
    [JsonPropertyName("sku")]
    public required V1api20211001ContainerGroupSpecContainersResourcesLimitsGpuSkuEnum Sku { get; set; }
}

/// <summary>Limits: The resource limits of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersResourcesLimits
{
    /// <summary>Cpu: The CPU limit of this container instance.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Gpu: The GPU limit of this container instance.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001ContainerGroupSpecContainersResourcesLimitsGpu? Gpu { get; set; }

    /// <summary>MemoryInGB: The memory limit in GB of this container instance.</summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

/// <summary>Sku: The SKU of the GPU resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecContainersResourcesRequestsGpuSkuEnum>))]
public enum V1api20211001ContainerGroupSpecContainersResourcesRequestsGpuSkuEnum
{
    [EnumMember(Value = "K80"), JsonStringEnumMemberName("K80")]
    K80,
    [EnumMember(Value = "P100"), JsonStringEnumMemberName("P100")]
    P100,
    [EnumMember(Value = "V100"), JsonStringEnumMemberName("V100")]
    V100
}

/// <summary>Gpu: The GPU request of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersResourcesRequestsGpu
{
    /// <summary>Count: The count of the GPU resource.</summary>
    [JsonPropertyName("count")]
    public required int Count { get; set; }

    /// <summary>Sku: The SKU of the GPU resource.</summary>
    [JsonPropertyName("sku")]
    public required V1api20211001ContainerGroupSpecContainersResourcesRequestsGpuSkuEnum Sku { get; set; }
}

/// <summary>Requests: The resource requests of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersResourcesRequests
{
    /// <summary>Cpu: The CPU request of this container instance.</summary>
    [JsonPropertyName("cpu")]
    public required double Cpu { get; set; }

    /// <summary>Gpu: The GPU request of this container instance.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001ContainerGroupSpecContainersResourcesRequestsGpu? Gpu { get; set; }

    /// <summary>MemoryInGB: The memory request in GB of this container instance.</summary>
    [JsonPropertyName("memoryInGB")]
    public required double MemoryInGB { get; set; }
}

/// <summary>Resources: The resource requirements of the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersResources
{
    /// <summary>Limits: The resource limits of this container instance.</summary>
    [JsonPropertyName("limits")]
    public V1api20211001ContainerGroupSpecContainersResourcesLimits? Limits { get; set; }

    /// <summary>Requests: The resource requests of this container instance.</summary>
    [JsonPropertyName("requests")]
    public required V1api20211001ContainerGroupSpecContainersResourcesRequests Requests { get; set; }
}

/// <summary>The properties of the volume mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainersVolumeMounts
{
    /// <summary>MountPath: The path within the container where the volume should be mounted. Must not contain colon (:).</summary>
    [JsonPropertyName("mountPath")]
    public required string MountPath { get; set; }

    /// <summary>Name: The name of the volume mount.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>ReadOnly: The flag indicating whether the volume mount is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>A container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecContainers
{
    /// <summary>Command: The commands to execute within the container instance in exec form.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>EnvironmentVariables: The environment variables to set in the container instance.</summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001ContainerGroupSpecContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Image: The name of the image used to create the container instance.</summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }

    /// <summary>LivenessProbe: The liveness probe.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1api20211001ContainerGroupSpecContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name: The user-provided name of the container instance.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Ports: The exposed ports on the container instance.</summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001ContainerGroupSpecContainersPorts>? Ports { get; set; }

    /// <summary>ReadinessProbe: The readiness probe.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1api20211001ContainerGroupSpecContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Resources: The resource requirements of the container instance.</summary>
    [JsonPropertyName("resources")]
    public required V1api20211001ContainerGroupSpecContainersResources Resources { get; set; }

    /// <summary>VolumeMounts: The volume mounts available to the container instance.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001ContainerGroupSpecContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>LogType: The log type to be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsLogTypeEnum>))]
public enum V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsLogTypeEnum
{
    [EnumMember(Value = "ContainerInsights"), JsonStringEnumMemberName("ContainerInsights")]
    ContainerInsights,
    [EnumMember(Value = "ContainerInstanceLogs"), JsonStringEnumMemberName("ContainerInstanceLogs")]
    ContainerInstanceLogs
}

/// <summary>WorkspaceKey: The workspace key for log analytics</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceKey
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WorkspaceResourceReference: The workspace resource id for log analytics</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceResourceReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>LogAnalytics: Container group log analytics information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecDiagnosticsLogAnalytics
{
    /// <summary>LogType: The log type to be used.</summary>
    [JsonPropertyName("logType")]
    public V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsLogTypeEnum? LogType { get; set; }

    /// <summary>Metadata: Metadata for log analytics.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>WorkspaceId: The workspace id for log analytics</summary>
    [JsonPropertyName("workspaceId")]
    public required string WorkspaceId { get; set; }

    /// <summary>WorkspaceKey: The workspace key for log analytics</summary>
    [JsonPropertyName("workspaceKey")]
    public required V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceKey WorkspaceKey { get; set; }

    /// <summary>WorkspaceResourceReference: The workspace resource id for log analytics</summary>
    [JsonPropertyName("workspaceResourceReference")]
    public V1api20211001ContainerGroupSpecDiagnosticsLogAnalyticsWorkspaceResourceReference? WorkspaceResourceReference { get; set; }
}

/// <summary>Diagnostics: The diagnostic information for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecDiagnostics
{
    /// <summary>LogAnalytics: Container group log analytics information.</summary>
    [JsonPropertyName("logAnalytics")]
    public V1api20211001ContainerGroupSpecDiagnosticsLogAnalytics? LogAnalytics { get; set; }
}

/// <summary>DnsConfig: The DNS config information for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecDnsConfig
{
    /// <summary>NameServers: The DNS servers for the container group.</summary>
    [JsonPropertyName("nameServers")]
    public required IList<string> NameServers { get; set; }

    /// <summary>Options: The DNS options for the container group.</summary>
    [JsonPropertyName("options")]
    public string? Options { get; set; }

    /// <summary>SearchDomains: The DNS search domains for hostname lookup in the container group.</summary>
    [JsonPropertyName("searchDomains")]
    public string? SearchDomains { get; set; }
}

/// <summary>EncryptionProperties: The encryption properties for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecEncryptionProperties
{
    /// <summary>KeyName: The encryption key name.</summary>
    [JsonPropertyName("keyName")]
    public required string KeyName { get; set; }

    /// <summary>KeyVersion: The encryption key version.</summary>
    [JsonPropertyName("keyVersion")]
    public required string KeyVersion { get; set; }

    /// <summary>VaultBaseUrl: The keyvault base url.</summary>
    [JsonPropertyName("vaultBaseUrl")]
    public required string VaultBaseUrl { get; set; }
}

/// <summary>
/// Type: The type of identity used for the container group. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
/// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
/// container group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecIdentityTypeEnum>))]
public enum V1api20211001ContainerGroupSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned, UserAssigned"), JsonStringEnumMemberName("SystemAssigned, UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20211001ContainerGroupSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the container group, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecIdentity
{
    /// <summary>
    /// Type: The type of identity used for the container group. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
    /// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
    /// container group.
    /// </summary>
    [JsonPropertyName("type")]
    public V1api20211001ContainerGroupSpecIdentityTypeEnum? Type { get; set; }

    /// <summary>UserAssignedIdentities: The list of user identities associated with the container group.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20211001ContainerGroupSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Password: The password for the private registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecImageRegistryCredentialsPassword
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Image registry credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecImageRegistryCredentials
{
    /// <summary>Identity: The identity for the private registry.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>IdentityUrl: The identity URL for the private registry.</summary>
    [JsonPropertyName("identityUrl")]
    public string? IdentityUrl { get; set; }

    /// <summary>Password: The password for the private registry.</summary>
    [JsonPropertyName("password")]
    public V1api20211001ContainerGroupSpecImageRegistryCredentialsPassword? Password { get; set; }

    /// <summary>Server: The Docker image registry server without a protocol such as &quot;http&quot; and &quot;https&quot;.</summary>
    [JsonPropertyName("server")]
    public required string Server { get; set; }

    /// <summary>Username: The username for the private registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>SecureValue: The value of the secure environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecInitContainersEnvironmentVariablesSecureValue
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>The environment variable to set within the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecInitContainersEnvironmentVariables
{
    /// <summary>Name: The name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>SecureValue: The value of the secure environment variable.</summary>
    [JsonPropertyName("secureValue")]
    public V1api20211001ContainerGroupSpecInitContainersEnvironmentVariablesSecureValue? SecureValue { get; set; }

    /// <summary>Value: The value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The properties of the volume mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecInitContainersVolumeMounts
{
    /// <summary>MountPath: The path within the container where the volume should be mounted. Must not contain colon (:).</summary>
    [JsonPropertyName("mountPath")]
    public required string MountPath { get; set; }

    /// <summary>Name: The name of the volume mount.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>ReadOnly: The flag indicating whether the volume mount is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>The init container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecInitContainers
{
    /// <summary>Command: The command to execute within the init container in exec form.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>EnvironmentVariables: The environment variables to set in the init container.</summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001ContainerGroupSpecInitContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Image: The image of the init container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: The name for the init container.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>VolumeMounts: The volume mounts available to the init container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001ContainerGroupSpecInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>
/// AutoGeneratedDomainNameLabelScope: The value representing the security enum. The &apos;Unsecure&apos; value is the default value
/// if not selected and means the object&apos;s domain name label is not secured against subdomain takeover. The &apos;TenantReuse&apos;
/// value is the default value if selected and means the object&apos;s domain name label can be reused within the same tenant.
/// The &apos;SubscriptionReuse&apos; value means the object&apos;s domain name label can be reused within the same subscription. The
/// &apos;ResourceGroupReuse&apos; value means the object&apos;s domain name label can be reused within the same resource group. The
/// &apos;NoReuse&apos; value means the object&apos;s domain name label cannot be reused within the same resource group, subscription, or
/// tenant.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecIpAddressAutoGeneratedDomainNameLabelScopeEnum>))]
public enum V1api20211001ContainerGroupSpecIpAddressAutoGeneratedDomainNameLabelScopeEnum
{
    [EnumMember(Value = "Noreuse"), JsonStringEnumMemberName("Noreuse")]
    Noreuse,
    [EnumMember(Value = "ResourceGroupReuse"), JsonStringEnumMemberName("ResourceGroupReuse")]
    ResourceGroupReuse,
    [EnumMember(Value = "SubscriptionReuse"), JsonStringEnumMemberName("SubscriptionReuse")]
    SubscriptionReuse,
    [EnumMember(Value = "TenantReuse"), JsonStringEnumMemberName("TenantReuse")]
    TenantReuse,
    [EnumMember(Value = "Unsecure"), JsonStringEnumMemberName("Unsecure")]
    Unsecure
}

/// <summary>Protocol: The protocol associated with the port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecIpAddressPortsProtocolEnum>))]
public enum V1api20211001ContainerGroupSpecIpAddressPortsProtocolEnum
{
    [EnumMember(Value = "TCP"), JsonStringEnumMemberName("TCP")]
    TCP,
    [EnumMember(Value = "UDP"), JsonStringEnumMemberName("UDP")]
    UDP
}

/// <summary>The port exposed on the container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecIpAddressPorts
{
    /// <summary>Port: The port number.</summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Protocol: The protocol associated with the port.</summary>
    [JsonPropertyName("protocol")]
    public V1api20211001ContainerGroupSpecIpAddressPortsProtocolEnum? Protocol { get; set; }
}

/// <summary>Type: Specifies if the IP is exposed to the public internet or private VNET.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecIpAddressTypeEnum>))]
public enum V1api20211001ContainerGroupSpecIpAddressTypeEnum
{
    [EnumMember(Value = "Private"), JsonStringEnumMemberName("Private")]
    Private,
    [EnumMember(Value = "Public"), JsonStringEnumMemberName("Public")]
    Public
}

/// <summary>IpAddress: The IP address type of the container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecIpAddress
{
    /// <summary>
    /// AutoGeneratedDomainNameLabelScope: The value representing the security enum. The &apos;Unsecure&apos; value is the default value
    /// if not selected and means the object&apos;s domain name label is not secured against subdomain takeover. The &apos;TenantReuse&apos;
    /// value is the default value if selected and means the object&apos;s domain name label can be reused within the same tenant.
    /// The &apos;SubscriptionReuse&apos; value means the object&apos;s domain name label can be reused within the same subscription. The
    /// &apos;ResourceGroupReuse&apos; value means the object&apos;s domain name label can be reused within the same resource group. The
    /// &apos;NoReuse&apos; value means the object&apos;s domain name label cannot be reused within the same resource group, subscription, or
    /// tenant.
    /// </summary>
    [JsonPropertyName("autoGeneratedDomainNameLabelScope")]
    public V1api20211001ContainerGroupSpecIpAddressAutoGeneratedDomainNameLabelScopeEnum? AutoGeneratedDomainNameLabelScope { get; set; }

    /// <summary>DnsNameLabel: The Dns name label for the IP.</summary>
    [JsonPropertyName("dnsNameLabel")]
    public string? DnsNameLabel { get; set; }

    /// <summary>Ip: The IP exposed to the public internet.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>Ports: The list of ports exposed on the container group.</summary>
    [JsonPropertyName("ports")]
    public required IList<V1api20211001ContainerGroupSpecIpAddressPorts> Ports { get; set; }

    /// <summary>Type: Specifies if the IP is exposed to the public internet or private VNET.</summary>
    [JsonPropertyName("type")]
    public required V1api20211001ContainerGroupSpecIpAddressTypeEnum Type { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20211001ContainerGroupSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20211001ContainerGroupSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OsType: The operating system type required by the containers in the container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecOsTypeEnum>))]
public enum V1api20211001ContainerGroupSpecOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// RestartPolicy: Restart policy for all containers within the container group.
/// - `Always` Always restart
/// - `OnFailure` Restart on failure
/// - `Never` Never restart
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecRestartPolicyEnum>))]
public enum V1api20211001ContainerGroupSpecRestartPolicyEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "OnFailure"), JsonStringEnumMemberName("OnFailure")]
    OnFailure
}

/// <summary>Sku: The SKU for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20211001ContainerGroupSpecSkuEnum>))]
public enum V1api20211001ContainerGroupSpecSkuEnum
{
    [EnumMember(Value = "Dedicated"), JsonStringEnumMemberName("Dedicated")]
    Dedicated,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Reference: Resource ID of virtual network and subnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecSubnetIdsReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Container group subnet information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecSubnetIds
{
    /// <summary>Name: Friendly name for the subnet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference: Resource ID of virtual network and subnet.</summary>
    [JsonPropertyName("reference")]
    public required V1api20211001ContainerGroupSpecSubnetIdsReference Reference { get; set; }
}

/// <summary>AzureFile: The Azure File volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecVolumesAzureFile
{
    /// <summary>ReadOnly: The flag indicating whether the Azure File shared mounted as a volume is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>ShareName: The name of the Azure File share to be mounted as a volume.</summary>
    [JsonPropertyName("shareName")]
    public required string ShareName { get; set; }

    /// <summary>StorageAccountKey: The storage account access key used to access the Azure File share.</summary>
    [JsonPropertyName("storageAccountKey")]
    public string? StorageAccountKey { get; set; }

    /// <summary>StorageAccountName: The name of the storage account that contains the Azure File share.</summary>
    [JsonPropertyName("storageAccountName")]
    public required string StorageAccountName { get; set; }
}

/// <summary>GitRepo: The git repo volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecVolumesGitRepo
{
    /// <summary>
    /// Directory: Target directory name. Must not contain or start with &apos;..&apos;.  If &apos;.&apos; is supplied, the volume directory will be
    /// the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the
    /// given name.
    /// </summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>Repository: Repository URL</summary>
    [JsonPropertyName("repository")]
    public required string Repository { get; set; }

    /// <summary>Revision: Commit hash for the specified revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>The properties of the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpecVolumes
{
    /// <summary>AzureFile: The Azure File volume.</summary>
    [JsonPropertyName("azureFile")]
    public V1api20211001ContainerGroupSpecVolumesAzureFile? AzureFile { get; set; }

    /// <summary>EmptyDir: The empty directory volume.</summary>
    [JsonPropertyName("emptyDir")]
    public IDictionary<string, JsonNode>? EmptyDir { get; set; }

    /// <summary>GitRepo: The git repo volume.</summary>
    [JsonPropertyName("gitRepo")]
    public V1api20211001ContainerGroupSpecVolumesGitRepo? GitRepo { get; set; }

    /// <summary>Name: The name of the volume.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Secret: The secret volume.</summary>
    [JsonPropertyName("secret")]
    public IDictionary<string, string>? Secret { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Containers: The containers within the container group.</summary>
    [JsonPropertyName("containers")]
    public required IList<V1api20211001ContainerGroupSpecContainers> Containers { get; set; }

    /// <summary>Diagnostics: The diagnostic information for a container group.</summary>
    [JsonPropertyName("diagnostics")]
    public V1api20211001ContainerGroupSpecDiagnostics? Diagnostics { get; set; }

    /// <summary>DnsConfig: The DNS config information for a container group.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20211001ContainerGroupSpecDnsConfig? DnsConfig { get; set; }

    /// <summary>EncryptionProperties: The encryption properties for a container group.</summary>
    [JsonPropertyName("encryptionProperties")]
    public V1api20211001ContainerGroupSpecEncryptionProperties? EncryptionProperties { get; set; }

    /// <summary>Identity: The identity of the container group, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20211001ContainerGroupSpecIdentity? Identity { get; set; }

    /// <summary>ImageRegistryCredentials: The image registry credentials by which the container group is created from.</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public IList<V1api20211001ContainerGroupSpecImageRegistryCredentials>? ImageRegistryCredentials { get; set; }

    /// <summary>InitContainers: The init containers for a container group.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V1api20211001ContainerGroupSpecInitContainers>? InitContainers { get; set; }

    /// <summary>IpAddress: The IP address type of the container group.</summary>
    [JsonPropertyName("ipAddress")]
    public V1api20211001ContainerGroupSpecIpAddress? IpAddress { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20211001ContainerGroupSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OsType: The operating system type required by the containers in the container group.</summary>
    [JsonPropertyName("osType")]
    public required V1api20211001ContainerGroupSpecOsTypeEnum OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20211001ContainerGroupSpecOwner Owner { get; set; }

    /// <summary>
    /// RestartPolicy: Restart policy for all containers within the container group.
    /// - `Always` Always restart
    /// - `OnFailure` Restart on failure
    /// - `Never` Never restart
    /// </summary>
    [JsonPropertyName("restartPolicy")]
    public V1api20211001ContainerGroupSpecRestartPolicyEnum? RestartPolicy { get; set; }

    /// <summary>Sku: The SKU for a container group.</summary>
    [JsonPropertyName("sku")]
    public V1api20211001ContainerGroupSpecSkuEnum? Sku { get; set; }

    /// <summary>SubnetIds: The subnet resource IDs for a container group.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<V1api20211001ContainerGroupSpecSubnetIds>? SubnetIds { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Volumes: The list of volumes that can be mounted by containers in this container group.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20211001ContainerGroupSpecVolumes>? Volumes { get; set; }

    /// <summary>Zones: The zones for the container group.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusConditions
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

/// <summary>The environment variable to set within the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersEnvironmentVariables
{
    /// <summary>Name: The name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>CurrentState: Current container instance state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersInstanceViewCurrentState
{
    /// <summary>DetailStatus: The human-readable status of the container instance state.</summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary>ExitCode: The container instance exit codes correspond to those from the `docker run` command.</summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary>FinishTime: The date-time when the container instance state finished.</summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary>StartTime: The date-time when the container instance state started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The state of the container instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A container group or container instance event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersInstanceViewEvents
{
    /// <summary>Count: The count of the event.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>FirstTimestamp: The date-time of the earliest logged event.</summary>
    [JsonPropertyName("firstTimestamp")]
    public string? FirstTimestamp { get; set; }

    /// <summary>LastTimestamp: The date-time of the latest logged event.</summary>
    [JsonPropertyName("lastTimestamp")]
    public string? LastTimestamp { get; set; }

    /// <summary>Message: The event message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Name: The event name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The event type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PreviousState: Previous container instance state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersInstanceViewPreviousState
{
    /// <summary>DetailStatus: The human-readable status of the container instance state.</summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary>ExitCode: The container instance exit codes correspond to those from the `docker run` command.</summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary>FinishTime: The date-time when the container instance state finished.</summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary>StartTime: The date-time when the container instance state started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The state of the container instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>InstanceView: The instance view of the container instance. Only valid in response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersInstanceView
{
    /// <summary>CurrentState: Current container instance state.</summary>
    [JsonPropertyName("currentState")]
    public V1api20211001ContainerGroupStatusContainersInstanceViewCurrentState? CurrentState { get; set; }

    /// <summary>Events: The events of the container instance.</summary>
    [JsonPropertyName("events")]
    public IList<V1api20211001ContainerGroupStatusContainersInstanceViewEvents>? Events { get; set; }

    /// <summary>PreviousState: Previous container instance state.</summary>
    [JsonPropertyName("previousState")]
    public V1api20211001ContainerGroupStatusContainersInstanceViewPreviousState? PreviousState { get; set; }

    /// <summary>RestartCount: The number of times that the container instance has been restarted.</summary>
    [JsonPropertyName("restartCount")]
    public int? RestartCount { get; set; }
}

/// <summary>Exec: The execution command to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersLivenessProbeExec
{
    /// <summary>Command: The commands to execute within the container.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>The HTTP header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Name: The header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet: The Http Get settings to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersLivenessProbeHttpGet
{
    /// <summary>HttpHeaders: The HTTP headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001ContainerGroupStatusContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: The path to probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port: The port number to probe.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme: The scheme.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>LivenessProbe: The liveness probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersLivenessProbe
{
    /// <summary>Exec: The execution command to probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001ContainerGroupStatusContainersLivenessProbeExec? Exec { get; set; }

    /// <summary>FailureThreshold: The failure threshold.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: The Http Get settings to probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001ContainerGroupStatusContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>InitialDelaySeconds: The initial delay seconds.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>PeriodSeconds: The period seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>SuccessThreshold: The success threshold.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TimeoutSeconds: The timeout seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>The port exposed on the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersPorts
{
    /// <summary>Port: The port number exposed within the container group.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Protocol: The protocol associated with the port.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Exec: The execution command to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersReadinessProbeExec
{
    /// <summary>Command: The commands to execute within the container.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }
}

/// <summary>The HTTP header.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersReadinessProbeHttpGetHttpHeaders
{
    /// <summary>Name: The header name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The header value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet: The Http Get settings to probe</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersReadinessProbeHttpGet
{
    /// <summary>HttpHeaders: The HTTP headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1api20211001ContainerGroupStatusContainersReadinessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: The path to probe.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port: The port number to probe.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme: The scheme.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>ReadinessProbe: The readiness probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersReadinessProbe
{
    /// <summary>Exec: The execution command to probe</summary>
    [JsonPropertyName("exec")]
    public V1api20211001ContainerGroupStatusContainersReadinessProbeExec? Exec { get; set; }

    /// <summary>FailureThreshold: The failure threshold.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: The Http Get settings to probe</summary>
    [JsonPropertyName("httpGet")]
    public V1api20211001ContainerGroupStatusContainersReadinessProbeHttpGet? HttpGet { get; set; }

    /// <summary>InitialDelaySeconds: The initial delay seconds.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>PeriodSeconds: The period seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>SuccessThreshold: The success threshold.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TimeoutSeconds: The timeout seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>Gpu: The GPU limit of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersResourcesLimitsGpu
{
    /// <summary>Count: The count of the GPU resource.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Sku: The SKU of the GPU resource.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

/// <summary>Limits: The resource limits of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersResourcesLimits
{
    /// <summary>Cpu: The CPU limit of this container instance.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Gpu: The GPU limit of this container instance.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001ContainerGroupStatusContainersResourcesLimitsGpu? Gpu { get; set; }

    /// <summary>MemoryInGB: The memory limit in GB of this container instance.</summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

/// <summary>Gpu: The GPU request of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersResourcesRequestsGpu
{
    /// <summary>Count: The count of the GPU resource.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>Sku: The SKU of the GPU resource.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

/// <summary>Requests: The resource requests of this container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersResourcesRequests
{
    /// <summary>Cpu: The CPU request of this container instance.</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Gpu: The GPU request of this container instance.</summary>
    [JsonPropertyName("gpu")]
    public V1api20211001ContainerGroupStatusContainersResourcesRequestsGpu? Gpu { get; set; }

    /// <summary>MemoryInGB: The memory request in GB of this container instance.</summary>
    [JsonPropertyName("memoryInGB")]
    public double? MemoryInGB { get; set; }
}

/// <summary>Resources: The resource requirements of the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersResources
{
    /// <summary>Limits: The resource limits of this container instance.</summary>
    [JsonPropertyName("limits")]
    public V1api20211001ContainerGroupStatusContainersResourcesLimits? Limits { get; set; }

    /// <summary>Requests: The resource requests of this container instance.</summary>
    [JsonPropertyName("requests")]
    public V1api20211001ContainerGroupStatusContainersResourcesRequests? Requests { get; set; }
}

/// <summary>The properties of the volume mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainersVolumeMounts
{
    /// <summary>MountPath: The path within the container where the volume should be mounted. Must not contain colon (:).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name: The name of the volume mount.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ReadOnly: The flag indicating whether the volume mount is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>A container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusContainers
{
    /// <summary>Command: The commands to execute within the container instance in exec form.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>EnvironmentVariables: The environment variables to set in the container instance.</summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001ContainerGroupStatusContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Image: The name of the image used to create the container instance.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>InstanceView: The instance view of the container instance. Only valid in response.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20211001ContainerGroupStatusContainersInstanceView? InstanceView { get; set; }

    /// <summary>LivenessProbe: The liveness probe.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1api20211001ContainerGroupStatusContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name: The user-provided name of the container instance.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Ports: The exposed ports on the container instance.</summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001ContainerGroupStatusContainersPorts>? Ports { get; set; }

    /// <summary>ReadinessProbe: The readiness probe.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1api20211001ContainerGroupStatusContainersReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Resources: The resource requirements of the container instance.</summary>
    [JsonPropertyName("resources")]
    public V1api20211001ContainerGroupStatusContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: The volume mounts available to the container instance.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001ContainerGroupStatusContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>LogAnalytics: Container group log analytics information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusDiagnosticsLogAnalytics
{
    /// <summary>LogType: The log type to be used.</summary>
    [JsonPropertyName("logType")]
    public string? LogType { get; set; }

    /// <summary>Metadata: Metadata for log analytics.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>WorkspaceId: The workspace id for log analytics</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>Diagnostics: The diagnostic information for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusDiagnostics
{
    /// <summary>LogAnalytics: Container group log analytics information.</summary>
    [JsonPropertyName("logAnalytics")]
    public V1api20211001ContainerGroupStatusDiagnosticsLogAnalytics? LogAnalytics { get; set; }
}

/// <summary>DnsConfig: The DNS config information for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusDnsConfig
{
    /// <summary>NameServers: The DNS servers for the container group.</summary>
    [JsonPropertyName("nameServers")]
    public IList<string>? NameServers { get; set; }

    /// <summary>Options: The DNS options for the container group.</summary>
    [JsonPropertyName("options")]
    public string? Options { get; set; }

    /// <summary>SearchDomains: The DNS search domains for hostname lookup in the container group.</summary>
    [JsonPropertyName("searchDomains")]
    public string? SearchDomains { get; set; }
}

/// <summary>EncryptionProperties: The encryption properties for a container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusEncryptionProperties
{
    /// <summary>KeyName: The encryption key name.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>KeyVersion: The encryption key version.</summary>
    [JsonPropertyName("keyVersion")]
    public string? KeyVersion { get; set; }

    /// <summary>VaultBaseUrl: The keyvault base url.</summary>
    [JsonPropertyName("vaultBaseUrl")]
    public string? VaultBaseUrl { get; set; }
}

/// <summary>
/// The list of user identities associated with the container group. The user identity dictionary key references will be ARM
/// resource ids in the form:
/// &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client id of user assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal id of user assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the container group, if configured.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusIdentity
{
    /// <summary>
    /// PrincipalId: The principal id of the container group identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant id associated with the container group. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>
    /// Type: The type of identity used for the container group. The type &apos;SystemAssigned, UserAssigned&apos; includes both an
    /// implicitly created identity and a set of user assigned identities. The type &apos;None&apos; will remove any identities from the
    /// container group.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UserAssignedIdentities: The list of user identities associated with the container group.</summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V1api20211001ContainerGroupStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>Image registry credential.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusImageRegistryCredentials
{
    /// <summary>Identity: The identity for the private registry.</summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>IdentityUrl: The identity URL for the private registry.</summary>
    [JsonPropertyName("identityUrl")]
    public string? IdentityUrl { get; set; }

    /// <summary>Server: The Docker image registry server without a protocol such as &quot;http&quot; and &quot;https&quot;.</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Username: The username for the private registry.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The environment variable to set within the container instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainersEnvironmentVariables
{
    /// <summary>Name: The name of the environment variable.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>CurrentState: The current state of the init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainersInstanceViewCurrentState
{
    /// <summary>DetailStatus: The human-readable status of the container instance state.</summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary>ExitCode: The container instance exit codes correspond to those from the `docker run` command.</summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary>FinishTime: The date-time when the container instance state finished.</summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary>StartTime: The date-time when the container instance state started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The state of the container instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>A container group or container instance event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainersInstanceViewEvents
{
    /// <summary>Count: The count of the event.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>FirstTimestamp: The date-time of the earliest logged event.</summary>
    [JsonPropertyName("firstTimestamp")]
    public string? FirstTimestamp { get; set; }

    /// <summary>LastTimestamp: The date-time of the latest logged event.</summary>
    [JsonPropertyName("lastTimestamp")]
    public string? LastTimestamp { get; set; }

    /// <summary>Message: The event message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Name: The event name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The event type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PreviousState: The previous state of the init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainersInstanceViewPreviousState
{
    /// <summary>DetailStatus: The human-readable status of the container instance state.</summary>
    [JsonPropertyName("detailStatus")]
    public string? DetailStatus { get; set; }

    /// <summary>ExitCode: The container instance exit codes correspond to those from the `docker run` command.</summary>
    [JsonPropertyName("exitCode")]
    public int? ExitCode { get; set; }

    /// <summary>FinishTime: The date-time when the container instance state finished.</summary>
    [JsonPropertyName("finishTime")]
    public string? FinishTime { get; set; }

    /// <summary>StartTime: The date-time when the container instance state started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The state of the container instance.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>InstanceView: The instance view of the init container. Only valid in response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainersInstanceView
{
    /// <summary>CurrentState: The current state of the init container.</summary>
    [JsonPropertyName("currentState")]
    public V1api20211001ContainerGroupStatusInitContainersInstanceViewCurrentState? CurrentState { get; set; }

    /// <summary>Events: The events of the init container.</summary>
    [JsonPropertyName("events")]
    public IList<V1api20211001ContainerGroupStatusInitContainersInstanceViewEvents>? Events { get; set; }

    /// <summary>PreviousState: The previous state of the init container.</summary>
    [JsonPropertyName("previousState")]
    public V1api20211001ContainerGroupStatusInitContainersInstanceViewPreviousState? PreviousState { get; set; }

    /// <summary>RestartCount: The number of times that the init container has been restarted.</summary>
    [JsonPropertyName("restartCount")]
    public int? RestartCount { get; set; }
}

/// <summary>The properties of the volume mount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainersVolumeMounts
{
    /// <summary>MountPath: The path within the container where the volume should be mounted. Must not contain colon (:).</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name: The name of the volume mount.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ReadOnly: The flag indicating whether the volume mount is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>The init container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInitContainers
{
    /// <summary>Command: The command to execute within the init container in exec form.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>EnvironmentVariables: The environment variables to set in the init container.</summary>
    [JsonPropertyName("environmentVariables")]
    public IList<V1api20211001ContainerGroupStatusInitContainersEnvironmentVariables>? EnvironmentVariables { get; set; }

    /// <summary>Image: The image of the init container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>InstanceView: The instance view of the init container. Only valid in response.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20211001ContainerGroupStatusInitContainersInstanceView? InstanceView { get; set; }

    /// <summary>Name: The name for the init container.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>VolumeMounts: The volume mounts available to the init container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1api20211001ContainerGroupStatusInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>A container group or container instance event.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInstanceViewEvents
{
    /// <summary>Count: The count of the event.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>FirstTimestamp: The date-time of the earliest logged event.</summary>
    [JsonPropertyName("firstTimestamp")]
    public string? FirstTimestamp { get; set; }

    /// <summary>LastTimestamp: The date-time of the latest logged event.</summary>
    [JsonPropertyName("lastTimestamp")]
    public string? LastTimestamp { get; set; }

    /// <summary>Message: The event message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Name: The event name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The event type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>InstanceView: The instance view of the container group. Only valid in response.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusInstanceView
{
    /// <summary>Events: The events of this container group.</summary>
    [JsonPropertyName("events")]
    public IList<V1api20211001ContainerGroupStatusInstanceViewEvents>? Events { get; set; }

    /// <summary>State: The state of the container group. Only valid in response.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The port exposed on the container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusIpAddressPorts
{
    /// <summary>Port: The port number.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Protocol: The protocol associated with the port.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>IpAddress: The IP address type of the container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusIpAddress
{
    /// <summary>
    /// AutoGeneratedDomainNameLabelScope: The value representing the security enum. The &apos;Unsecure&apos; value is the default value
    /// if not selected and means the object&apos;s domain name label is not secured against subdomain takeover. The &apos;TenantReuse&apos;
    /// value is the default value if selected and means the object&apos;s domain name label can be reused within the same tenant.
    /// The &apos;SubscriptionReuse&apos; value means the object&apos;s domain name label can be reused within the same subscription. The
    /// &apos;ResourceGroupReuse&apos; value means the object&apos;s domain name label can be reused within the same resource group. The
    /// &apos;NoReuse&apos; value means the object&apos;s domain name label cannot be reused within the same resource group, subscription, or
    /// tenant.
    /// </summary>
    [JsonPropertyName("autoGeneratedDomainNameLabelScope")]
    public string? AutoGeneratedDomainNameLabelScope { get; set; }

    /// <summary>DnsNameLabel: The Dns name label for the IP.</summary>
    [JsonPropertyName("dnsNameLabel")]
    public string? DnsNameLabel { get; set; }

    /// <summary>Fqdn: The FQDN for the IP.</summary>
    [JsonPropertyName("fqdn")]
    public string? Fqdn { get; set; }

    /// <summary>Ip: The IP exposed to the public internet.</summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>Ports: The list of ports exposed on the container group.</summary>
    [JsonPropertyName("ports")]
    public IList<V1api20211001ContainerGroupStatusIpAddressPorts>? Ports { get; set; }

    /// <summary>Type: Specifies if the IP is exposed to the public internet or private VNET.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Container group subnet information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusSubnetIds
{
    /// <summary>Id: Resource ID of virtual network and subnet.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name: Friendly name for the subnet.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>AzureFile: The Azure File volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusVolumesAzureFile
{
    /// <summary>ReadOnly: The flag indicating whether the Azure File shared mounted as a volume is read-only.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>ShareName: The name of the Azure File share to be mounted as a volume.</summary>
    [JsonPropertyName("shareName")]
    public string? ShareName { get; set; }

    /// <summary>StorageAccountKey: The storage account access key used to access the Azure File share.</summary>
    [JsonPropertyName("storageAccountKey")]
    public string? StorageAccountKey { get; set; }

    /// <summary>StorageAccountName: The name of the storage account that contains the Azure File share.</summary>
    [JsonPropertyName("storageAccountName")]
    public string? StorageAccountName { get; set; }
}

/// <summary>GitRepo: The git repo volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusVolumesGitRepo
{
    /// <summary>
    /// Directory: Target directory name. Must not contain or start with &apos;..&apos;.  If &apos;.&apos; is supplied, the volume directory will be
    /// the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the
    /// given name.
    /// </summary>
    [JsonPropertyName("directory")]
    public string? Directory { get; set; }

    /// <summary>Repository: Repository URL</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>Revision: Commit hash for the specified revision.</summary>
    [JsonPropertyName("revision")]
    public string? Revision { get; set; }
}

/// <summary>The properties of the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatusVolumes
{
    /// <summary>AzureFile: The Azure File volume.</summary>
    [JsonPropertyName("azureFile")]
    public V1api20211001ContainerGroupStatusVolumesAzureFile? AzureFile { get; set; }

    /// <summary>EmptyDir: The empty directory volume.</summary>
    [JsonPropertyName("emptyDir")]
    public IDictionary<string, JsonNode>? EmptyDir { get; set; }

    /// <summary>GitRepo: The git repo volume.</summary>
    [JsonPropertyName("gitRepo")]
    public V1api20211001ContainerGroupStatusVolumesGitRepo? GitRepo { get; set; }

    /// <summary>Name: The name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret: The secret volume.</summary>
    [JsonPropertyName("secret")]
    public IDictionary<string, string>? Secret { get; set; }
}

/// <summary>A container group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20211001ContainerGroupStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20211001ContainerGroupStatusConditions>? Conditions { get; set; }

    /// <summary>Containers: The containers within the container group.</summary>
    [JsonPropertyName("containers")]
    public IList<V1api20211001ContainerGroupStatusContainers>? Containers { get; set; }

    /// <summary>Diagnostics: The diagnostic information for a container group.</summary>
    [JsonPropertyName("diagnostics")]
    public V1api20211001ContainerGroupStatusDiagnostics? Diagnostics { get; set; }

    /// <summary>DnsConfig: The DNS config information for a container group.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1api20211001ContainerGroupStatusDnsConfig? DnsConfig { get; set; }

    /// <summary>EncryptionProperties: The encryption properties for a container group.</summary>
    [JsonPropertyName("encryptionProperties")]
    public V1api20211001ContainerGroupStatusEncryptionProperties? EncryptionProperties { get; set; }

    /// <summary>Id: The resource id.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the container group, if configured.</summary>
    [JsonPropertyName("identity")]
    public V1api20211001ContainerGroupStatusIdentity? Identity { get; set; }

    /// <summary>ImageRegistryCredentials: The image registry credentials by which the container group is created from.</summary>
    [JsonPropertyName("imageRegistryCredentials")]
    public IList<V1api20211001ContainerGroupStatusImageRegistryCredentials>? ImageRegistryCredentials { get; set; }

    /// <summary>InitContainers: The init containers for a container group.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V1api20211001ContainerGroupStatusInitContainers>? InitContainers { get; set; }

    /// <summary>InstanceView: The instance view of the container group. Only valid in response.</summary>
    [JsonPropertyName("instanceView")]
    public V1api20211001ContainerGroupStatusInstanceView? InstanceView { get; set; }

    /// <summary>IpAddress: The IP address type of the container group.</summary>
    [JsonPropertyName("ipAddress")]
    public V1api20211001ContainerGroupStatusIpAddress? IpAddress { get; set; }

    /// <summary>Location: The resource location.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The resource name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OsType: The operating system type required by the containers in the container group.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the container group. This only appears in the response.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// RestartPolicy: Restart policy for all containers within the container group.
    /// - `Always` Always restart
    /// - `OnFailure` Restart on failure
    /// - `Never` Never restart
    /// </summary>
    [JsonPropertyName("restartPolicy")]
    public string? RestartPolicy { get; set; }

    /// <summary>Sku: The SKU for a container group.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    /// <summary>SubnetIds: The subnet resource IDs for a container group.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<V1api20211001ContainerGroupStatusSubnetIds>? SubnetIds { get; set; }

    /// <summary>Tags: The resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The resource type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Volumes: The list of volumes that can be mounted by containers in this container group.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1api20211001ContainerGroupStatusVolumes>? Volumes { get; set; }

    /// <summary>Zones: The zones for the container group.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerinstance/resource-manager/Microsoft.ContainerInstance/ContainerInstance/stable/2021-10-01/containerInstance.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20211001ContainerGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20211001ContainerGroupSpec?>, IStatus<V1api20211001ContainerGroupStatus?>
{
    public const string KubeApiVersion = "v1api20211001";
    public const string KubeKind = "ContainerGroup";
    public const string KubeGroup = "containerinstance.azure.com";
    public const string KubePluralName = "containergroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerinstance.azure.com/v1api20211001";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20211001ContainerGroupSpec? Spec { get; set; }

    /// <summary>A container group.</summary>
    [JsonPropertyName("status")]
    public V1api20211001ContainerGroupStatus? Status { get; set; }
}