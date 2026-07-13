#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.crd.projectcalico.org;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KubeControllersConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1KubeControllersConfiguration>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KubeControllersConfigurationList";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "kubecontrollersconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KubeControllersConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KubeControllersConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KubeControllersConfiguration> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersLoadBalancerAssignIPsEnum>))]
public enum V1KubeControllersConfigurationSpecControllersLoadBalancerAssignIPsEnum
{
    [EnumMember(Value = "AllServices"), JsonStringEnumMemberName("AllServices")]
    AllServices,
    [EnumMember(Value = "RequestedServicesOnly"), JsonStringEnumMemberName("RequestedServicesOnly")]
    RequestedServicesOnly
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersLoadBalancer
{
    [JsonPropertyName("assignIPs")]
    public V1KubeControllersConfigurationSpecControllersLoadBalancerAssignIPsEnum? AssignIPs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNamespace
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersNodeHostEndpointAutoCreateEnum>))]
public enum V1KubeControllersConfigurationSpecControllersNodeHostEndpointAutoCreateEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNodeHostEndpointTemplates
{
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    [JsonPropertyName("interfaceCIDRs")]
    public IList<string>? InterfaceCIDRs { get; set; }

    [JsonPropertyName("interfacePattern")]
    public string? InterfacePattern { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNodeHostEndpoint
{
    [JsonPropertyName("autoCreate")]
    public V1KubeControllersConfigurationSpecControllersNodeHostEndpointAutoCreateEnum? AutoCreate { get; set; }

    [JsonPropertyName("createDefaultHostEndpoint")]
    public string? CreateDefaultHostEndpoint { get; set; }

    [JsonPropertyName("templates")]
    public IList<V1KubeControllersConfigurationSpecControllersNodeHostEndpointTemplates>? Templates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersNodeSyncLabelsEnum>))]
public enum V1KubeControllersConfigurationSpecControllersNodeSyncLabelsEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNode
{
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationSpecControllersNodeHostEndpoint? HostEndpoint { get; set; }

    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    [JsonPropertyName("syncLabels")]
    public V1KubeControllersConfigurationSpecControllersNodeSyncLabelsEnum? SyncLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersPolicy
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersPolicyMigrationEnabledEnum>))]
public enum V1KubeControllersConfigurationSpecControllersPolicyMigrationEnabledEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersPolicyMigration
{
    [JsonPropertyName("enabled")]
    public V1KubeControllersConfigurationSpecControllersPolicyMigrationEnabledEnum? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersServiceAccount
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersWorkloadEndpoint
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllers
{
    [JsonPropertyName("loadBalancer")]
    public V1KubeControllersConfigurationSpecControllersLoadBalancer? LoadBalancer { get; set; }

    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationSpecControllersNamespace? Namespace { get; set; }

    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationSpecControllersNode? Node { get; set; }

    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationSpecControllersPolicy? Policy { get; set; }

    [JsonPropertyName("policyMigration")]
    public V1KubeControllersConfigurationSpecControllersPolicyMigration? PolicyMigration { get; set; }

    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationSpecControllersServiceAccount? ServiceAccount { get; set; }

    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationSpecControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecHealthChecksEnum>))]
public enum V1KubeControllersConfigurationSpecHealthChecksEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecLogSeverityScreenEnum>))]
public enum V1KubeControllersConfigurationSpecLogSeverityScreenEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Debug"), JsonStringEnumMemberName("Debug")]
    Debug,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Warning"), JsonStringEnumMemberName("Warning")]
    Warning,
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Fatal"), JsonStringEnumMemberName("Fatal")]
    Fatal,
    [EnumMember(Value = "Panic"), JsonStringEnumMemberName("Panic")]
    Panic
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpec
{
    [JsonPropertyName("controllers")]
    public required V1KubeControllersConfigurationSpecControllers Controllers { get; set; }

    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    [JsonPropertyName("healthChecks")]
    public V1KubeControllersConfigurationSpecHealthChecksEnum? HealthChecks { get; set; }

    [JsonPropertyName("logSeverityScreen")]
    public V1KubeControllersConfigurationSpecLogSeverityScreenEnum? LogSeverityScreen { get; set; }

    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancerAssignIPsEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancerAssignIPsEnum
{
    [EnumMember(Value = "AllServices"), JsonStringEnumMemberName("AllServices")]
    AllServices,
    [EnumMember(Value = "RequestedServicesOnly"), JsonStringEnumMemberName("RequestedServicesOnly")]
    RequestedServicesOnly
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancer
{
    [JsonPropertyName("assignIPs")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancerAssignIPsEnum? AssignIPs { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNamespace
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointAutoCreateEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointAutoCreateEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointTemplates
{
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    [JsonPropertyName("interfaceCIDRs")]
    public IList<string>? InterfaceCIDRs { get; set; }

    [JsonPropertyName("interfacePattern")]
    public string? InterfacePattern { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint
{
    [JsonPropertyName("autoCreate")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointAutoCreateEnum? AutoCreate { get; set; }

    [JsonPropertyName("createDefaultHostEndpoint")]
    public string? CreateDefaultHostEndpoint { get; set; }

    [JsonPropertyName("templates")]
    public IList<V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointTemplates>? Templates { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersNodeSyncLabelsEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersNodeSyncLabelsEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNode
{
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint? HostEndpoint { get; set; }

    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    [JsonPropertyName("syncLabels")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeSyncLabelsEnum? SyncLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersPolicy
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersPolicyMigrationEnabledEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersPolicyMigrationEnabledEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersPolicyMigration
{
    [JsonPropertyName("enabled")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersPolicyMigrationEnabledEnum? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint
{
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllers
{
    [JsonPropertyName("loadBalancer")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancer? LoadBalancer { get; set; }

    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNamespace? Namespace { get; set; }

    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNode? Node { get; set; }

    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersPolicy? Policy { get; set; }

    [JsonPropertyName("policyMigration")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersPolicyMigration? PolicyMigration { get; set; }

    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount? ServiceAccount { get; set; }

    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigHealthChecksEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigHealthChecksEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigLogSeverityScreenEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigLogSeverityScreenEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Debug"), JsonStringEnumMemberName("Debug")]
    Debug,
    [EnumMember(Value = "Info"), JsonStringEnumMemberName("Info")]
    Info,
    [EnumMember(Value = "Warning"), JsonStringEnumMemberName("Warning")]
    Warning,
    [EnumMember(Value = "Error"), JsonStringEnumMemberName("Error")]
    Error,
    [EnumMember(Value = "Fatal"), JsonStringEnumMemberName("Fatal")]
    Fatal,
    [EnumMember(Value = "Panic"), JsonStringEnumMemberName("Panic")]
    Panic
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfig
{
    [JsonPropertyName("controllers")]
    public required V1KubeControllersConfigurationStatusRunningConfigControllers Controllers { get; set; }

    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    [JsonPropertyName("healthChecks")]
    public V1KubeControllersConfigurationStatusRunningConfigHealthChecksEnum? HealthChecks { get; set; }

    [JsonPropertyName("logSeverityScreen")]
    public V1KubeControllersConfigurationStatusRunningConfigLogSeverityScreenEnum? LogSeverityScreen { get; set; }

    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatus
{
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    [JsonPropertyName("runningConfig")]
    public V1KubeControllersConfigurationStatusRunningConfig? RunningConfig { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KubeControllersConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1KubeControllersConfigurationSpec?>, IStatus<V1KubeControllersConfigurationStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KubeControllersConfiguration";
    public const string KubeGroup = "crd.projectcalico.org";
    public const string KubePluralName = "kubecontrollersconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "crd.projectcalico.org/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KubeControllersConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1KubeControllersConfigurationSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1KubeControllersConfigurationStatus? Status { get; set; }
}