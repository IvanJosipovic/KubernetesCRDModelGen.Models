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

/// <summary>AssignIPs controls which LoadBalancer Service gets IP assigned from Calico IPAM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersLoadBalancerAssignIPsEnum>))]
public enum V1KubeControllersConfigurationSpecControllersLoadBalancerAssignIPsEnum
{
    [EnumMember(Value = "AllServices"), JsonStringEnumMemberName("AllServices")]
    AllServices,
    [EnumMember(Value = "RequestedServicesOnly"), JsonStringEnumMemberName("RequestedServicesOnly")]
    RequestedServicesOnly
}

/// <summary>LoadBalancer enables and configures the LoadBalancer controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersLoadBalancer
{
    /// <summary>AssignIPs controls which LoadBalancer Service gets IP assigned from Calico IPAM.</summary>
    [JsonPropertyName("assignIPs")]
    public V1KubeControllersConfigurationSpecControllersLoadBalancerAssignIPsEnum? AssignIPs { get; set; }
}

/// <summary>
/// PolicyNameMigrator enables or disables the Policy Name Migrator, which migrates
/// old-style Calico backend policy names to use v3 style names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersMigrationPolicyNameMigratorEnum>))]
public enum V1KubeControllersConfigurationSpecControllersMigrationPolicyNameMigratorEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Migration enables and configures migration controllers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersMigration
{
    /// <summary>
    /// PolicyNameMigrator enables or disables the Policy Name Migrator, which migrates
    /// old-style Calico backend policy names to use v3 style names.
    /// </summary>
    [JsonPropertyName("policyNameMigrator")]
    public V1KubeControllersConfigurationSpecControllersMigrationPolicyNameMigratorEnum? PolicyNameMigrator { get; set; }
}

/// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNamespace
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>
/// AutoCreate enables automatic creation of host endpoints for every node. [Default: Disabled]
/// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
/// </summary>
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
    /// <summary>Annotations adds the specified annotations to the generated AutoHostEndpoint.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>GenerateName is appended to the end of the generated AutoHostEndpoint name</summary>
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    /// <summary>
    /// InterfaceCIDRs contains a list of CIDRs used for matching nodeIPs to the AutoHostEndpoint.
    /// If specified, only addresses within these CIDRs will be included in the expected IPs.
    /// At least one of InterfaceCIDRs and InterfacePattern must be specified.
    /// </summary>
    [JsonPropertyName("interfaceCIDRs")]
    public IList<string>? InterfaceCIDRs { get; set; }

    /// <summary>
    /// InterfacePattern contains a regex string to match Node interface names. If specified, a HostEndpoint will be created for each matching interface on each selected node.
    /// At least one of InterfaceCIDRs and InterfacePattern must be specified.
    /// </summary>
    [JsonPropertyName("interfacePattern")]
    public string? InterfacePattern { get; set; }

    /// <summary>Labels adds the specified labels to the generated AutoHostEndpoint, labels from node with the same name will be overwritten by values from the template label</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>NodeSelector allows the AutoHostEndpoint to be created only for specific nodes</summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }
}

/// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNodeHostEndpoint
{
    /// <summary>
    /// AutoCreate enables automatic creation of host endpoints for every node. [Default: Disabled]
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("autoCreate")]
    public V1KubeControllersConfigurationSpecControllersNodeHostEndpointAutoCreateEnum? AutoCreate { get; set; }

    /// <summary>
    /// DefaultHostEndpointMode controls whether a default host endpoint is created for each node.
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("createDefaultHostEndpoint")]
    public string? CreateDefaultHostEndpoint { get; set; }

    /// <summary>Templates contains definition for creating AutoHostEndpoints</summary>
    [JsonPropertyName("templates")]
    public IList<V1KubeControllersConfigurationSpecControllersNodeHostEndpointTemplates>? Templates { get; set; }
}

/// <summary>
/// SyncLabels controls whether to copy Kubernetes node labels to Calico nodes. [Default: Enabled]
/// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecControllersNodeSyncLabelsEnum>))]
public enum V1KubeControllersConfigurationSpecControllersNodeSyncLabelsEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersNode
{
    /// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationSpecControllersNodeHostEndpoint? HostEndpoint { get; set; }

    /// <summary>
    /// LeakGracePeriod is the period used by the controller to determine if an IP address has been leaked.
    /// Set to 0 to disable IP garbage collection. [Default: 15m]
    /// </summary>
    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    /// <summary>
    /// SyncLabels controls whether to copy Kubernetes node labels to Calico nodes. [Default: Enabled]
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("syncLabels")]
    public V1KubeControllersConfigurationSpecControllersNodeSyncLabelsEnum? SyncLabels { get; set; }
}

/// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersPolicy
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersServiceAccount
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllersWorkloadEndpoint
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpecControllers
{
    /// <summary>LoadBalancer enables and configures the LoadBalancer controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1KubeControllersConfigurationSpecControllersLoadBalancer? LoadBalancer { get; set; }

    /// <summary>Migration enables and configures migration controllers.</summary>
    [JsonPropertyName("migration")]
    public V1KubeControllersConfigurationSpecControllersMigration? Migration { get; set; }

    /// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationSpecControllersNamespace? Namespace { get; set; }

    /// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationSpecControllersNode? Node { get; set; }

    /// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationSpecControllersPolicy? Policy { get; set; }

    /// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationSpecControllersServiceAccount? ServiceAccount { get; set; }

    /// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationSpecControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

/// <summary>
/// HealthChecks enables or disables support for health checks [Default: Enabled]
/// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationSpecHealthChecksEnum>))]
public enum V1KubeControllersConfigurationSpecHealthChecksEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>
/// LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]
/// Valid values are: &quot;None&quot;, &quot;Debug&quot;, &quot;Info&quot;, &quot;Warning&quot;, &quot;Error&quot;, &quot;Fatal&quot;, &quot;Panic&quot;.
/// </summary>
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

/// <summary>KubeControllersConfigurationSpec contains the values of the Kubernetes controllers configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationSpec
{
    /// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
    [JsonPropertyName("controllers")]
    public required V1KubeControllersConfigurationSpecControllers Controllers { get; set; }

    /// <summary>
    /// DebugProfileHost is the host IP or hostname to bind the profiling port to. Set to &quot;0.0.0.0&quot;
    /// for all interfaces to make profiles reachable from off-host. The profiling endpoints are
    /// unauthenticated and expose heap dumps, goroutine stacks and CPU profiles, so prefer the
    /// default and use kubectl port-forward for remote access. Only used if DebugProfilePort is set.
    /// [Default: localhost]
    /// </summary>
    [JsonPropertyName("debugProfileHost")]
    public string? DebugProfileHost { get; set; }

    /// <summary>
    /// DebugProfilePort configures the port to serve memory and cpu profiles on. If not specified, profiling
    /// is disabled.
    /// Valid values are: 0-65535.
    /// </summary>
    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    /// <summary>EtcdV3CompactionPeriod is the period between etcdv3 compaction requests. Set to 0 to disable. [Default: 10m]</summary>
    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    /// <summary>
    /// HealthChecks enables or disables support for health checks [Default: Enabled]
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public V1KubeControllersConfigurationSpecHealthChecksEnum? HealthChecks { get; set; }

    /// <summary>
    /// LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]
    /// Valid values are: &quot;None&quot;, &quot;Debug&quot;, &quot;Info&quot;, &quot;Warning&quot;, &quot;Error&quot;, &quot;Fatal&quot;, &quot;Panic&quot;.
    /// </summary>
    [JsonPropertyName("logSeverityScreen")]
    public V1KubeControllersConfigurationSpecLogSeverityScreenEnum? LogSeverityScreen { get; set; }

    /// <summary>
    /// PrometheusMetricsPort is the TCP port that the Prometheus metrics server should bind to. Set to 0 to disable. [Default: 9094]
    /// Valid values are: 0-65535.
    /// </summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

/// <summary>AssignIPs controls which LoadBalancer Service gets IP assigned from Calico IPAM.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancerAssignIPsEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancerAssignIPsEnum
{
    [EnumMember(Value = "AllServices"), JsonStringEnumMemberName("AllServices")]
    AllServices,
    [EnumMember(Value = "RequestedServicesOnly"), JsonStringEnumMemberName("RequestedServicesOnly")]
    RequestedServicesOnly
}

/// <summary>LoadBalancer enables and configures the LoadBalancer controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancer
{
    /// <summary>AssignIPs controls which LoadBalancer Service gets IP assigned from Calico IPAM.</summary>
    [JsonPropertyName("assignIPs")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancerAssignIPsEnum? AssignIPs { get; set; }
}

/// <summary>
/// PolicyNameMigrator enables or disables the Policy Name Migrator, which migrates
/// old-style Calico backend policy names to use v3 style names.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersMigrationPolicyNameMigratorEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersMigrationPolicyNameMigratorEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>Migration enables and configures migration controllers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersMigration
{
    /// <summary>
    /// PolicyNameMigrator enables or disables the Policy Name Migrator, which migrates
    /// old-style Calico backend policy names to use v3 style names.
    /// </summary>
    [JsonPropertyName("policyNameMigrator")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersMigrationPolicyNameMigratorEnum? PolicyNameMigrator { get; set; }
}

/// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNamespace
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>
/// AutoCreate enables automatic creation of host endpoints for every node. [Default: Disabled]
/// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
/// </summary>
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
    /// <summary>Annotations adds the specified annotations to the generated AutoHostEndpoint.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>GenerateName is appended to the end of the generated AutoHostEndpoint name</summary>
    [JsonPropertyName("generateName")]
    public string? GenerateName { get; set; }

    /// <summary>
    /// InterfaceCIDRs contains a list of CIDRs used for matching nodeIPs to the AutoHostEndpoint.
    /// If specified, only addresses within these CIDRs will be included in the expected IPs.
    /// At least one of InterfaceCIDRs and InterfacePattern must be specified.
    /// </summary>
    [JsonPropertyName("interfaceCIDRs")]
    public IList<string>? InterfaceCIDRs { get; set; }

    /// <summary>
    /// InterfacePattern contains a regex string to match Node interface names. If specified, a HostEndpoint will be created for each matching interface on each selected node.
    /// At least one of InterfaceCIDRs and InterfacePattern must be specified.
    /// </summary>
    [JsonPropertyName("interfacePattern")]
    public string? InterfacePattern { get; set; }

    /// <summary>Labels adds the specified labels to the generated AutoHostEndpoint, labels from node with the same name will be overwritten by values from the template label</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>NodeSelector allows the AutoHostEndpoint to be created only for specific nodes</summary>
    [JsonPropertyName("nodeSelector")]
    public string? NodeSelector { get; set; }
}

/// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint
{
    /// <summary>
    /// AutoCreate enables automatic creation of host endpoints for every node. [Default: Disabled]
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("autoCreate")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointAutoCreateEnum? AutoCreate { get; set; }

    /// <summary>
    /// DefaultHostEndpointMode controls whether a default host endpoint is created for each node.
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("createDefaultHostEndpoint")]
    public string? CreateDefaultHostEndpoint { get; set; }

    /// <summary>Templates contains definition for creating AutoHostEndpoints</summary>
    [JsonPropertyName("templates")]
    public IList<V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpointTemplates>? Templates { get; set; }
}

/// <summary>
/// SyncLabels controls whether to copy Kubernetes node labels to Calico nodes. [Default: Enabled]
/// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigControllersNodeSyncLabelsEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigControllersNodeSyncLabelsEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersNode
{
    /// <summary>HostEndpoint controls syncing nodes to host endpoints. Disabled by default, set to nil to disable.</summary>
    [JsonPropertyName("hostEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeHostEndpoint? HostEndpoint { get; set; }

    /// <summary>
    /// LeakGracePeriod is the period used by the controller to determine if an IP address has been leaked.
    /// Set to 0 to disable IP garbage collection. [Default: 15m]
    /// </summary>
    [JsonPropertyName("leakGracePeriod")]
    public string? LeakGracePeriod { get; set; }

    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }

    /// <summary>
    /// SyncLabels controls whether to copy Kubernetes node labels to Calico nodes. [Default: Enabled]
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("syncLabels")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNodeSyncLabelsEnum? SyncLabels { get; set; }
}

/// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersPolicy
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint
{
    /// <summary>ReconcilerPeriod is the period to perform reconciliation with the Calico datastore. [Default: 5m]</summary>
    [JsonPropertyName("reconcilerPeriod")]
    public string? ReconcilerPeriod { get; set; }
}

/// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfigControllers
{
    /// <summary>LoadBalancer enables and configures the LoadBalancer controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("loadBalancer")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersLoadBalancer? LoadBalancer { get; set; }

    /// <summary>Migration enables and configures migration controllers.</summary>
    [JsonPropertyName("migration")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersMigration? Migration { get; set; }

    /// <summary>Namespace enables and configures the namespace controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("namespace")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNamespace? Namespace { get; set; }

    /// <summary>Node enables and configures the node controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("node")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersNode? Node { get; set; }

    /// <summary>Policy enables and configures the policy controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("policy")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersPolicy? Policy { get; set; }

    /// <summary>ServiceAccount enables and configures the service account controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersServiceAccount? ServiceAccount { get; set; }

    /// <summary>WorkloadEndpoint enables and configures the workload endpoint controller. Enabled by default, set to nil to disable.</summary>
    [JsonPropertyName("workloadEndpoint")]
    public V1KubeControllersConfigurationStatusRunningConfigControllersWorkloadEndpoint? WorkloadEndpoint { get; set; }
}

/// <summary>
/// HealthChecks enables or disables support for health checks [Default: Enabled]
/// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KubeControllersConfigurationStatusRunningConfigHealthChecksEnum>))]
public enum V1KubeControllersConfigurationStatusRunningConfigHealthChecksEnum
{
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>
/// LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]
/// Valid values are: &quot;None&quot;, &quot;Debug&quot;, &quot;Info&quot;, &quot;Warning&quot;, &quot;Error&quot;, &quot;Fatal&quot;, &quot;Panic&quot;.
/// </summary>
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

/// <summary>
/// RunningConfig contains the effective config that is running in the kube-controllers pod, after
/// merging the API resource with any environment variables.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatusRunningConfig
{
    /// <summary>Controllers enables and configures individual Kubernetes controllers</summary>
    [JsonPropertyName("controllers")]
    public required V1KubeControllersConfigurationStatusRunningConfigControllers Controllers { get; set; }

    /// <summary>
    /// DebugProfileHost is the host IP or hostname to bind the profiling port to. Set to &quot;0.0.0.0&quot;
    /// for all interfaces to make profiles reachable from off-host. The profiling endpoints are
    /// unauthenticated and expose heap dumps, goroutine stacks and CPU profiles, so prefer the
    /// default and use kubectl port-forward for remote access. Only used if DebugProfilePort is set.
    /// [Default: localhost]
    /// </summary>
    [JsonPropertyName("debugProfileHost")]
    public string? DebugProfileHost { get; set; }

    /// <summary>
    /// DebugProfilePort configures the port to serve memory and cpu profiles on. If not specified, profiling
    /// is disabled.
    /// Valid values are: 0-65535.
    /// </summary>
    [JsonPropertyName("debugProfilePort")]
    public int? DebugProfilePort { get; set; }

    /// <summary>EtcdV3CompactionPeriod is the period between etcdv3 compaction requests. Set to 0 to disable. [Default: 10m]</summary>
    [JsonPropertyName("etcdV3CompactionPeriod")]
    public string? EtcdV3CompactionPeriod { get; set; }

    /// <summary>
    /// HealthChecks enables or disables support for health checks [Default: Enabled]
    /// Valid values are: &quot;Enabled&quot;, &quot;Disabled&quot;.
    /// </summary>
    [JsonPropertyName("healthChecks")]
    public V1KubeControllersConfigurationStatusRunningConfigHealthChecksEnum? HealthChecks { get; set; }

    /// <summary>
    /// LogSeverityScreen is the log severity above which logs are sent to the stdout. [Default: Info]
    /// Valid values are: &quot;None&quot;, &quot;Debug&quot;, &quot;Info&quot;, &quot;Warning&quot;, &quot;Error&quot;, &quot;Fatal&quot;, &quot;Panic&quot;.
    /// </summary>
    [JsonPropertyName("logSeverityScreen")]
    public V1KubeControllersConfigurationStatusRunningConfigLogSeverityScreenEnum? LogSeverityScreen { get; set; }

    /// <summary>
    /// PrometheusMetricsPort is the TCP port that the Prometheus metrics server should bind to. Set to 0 to disable. [Default: 9094]
    /// Valid values are: 0-65535.
    /// </summary>
    [JsonPropertyName("prometheusMetricsPort")]
    public int? PrometheusMetricsPort { get; set; }
}

/// <summary>
/// KubeControllersConfigurationStatus represents the status of the configuration. It&apos;s useful for admins to
/// be able to see the actual config that was applied, which can be modified by environment variables on the
/// kube-controllers process.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KubeControllersConfigurationStatus
{
    /// <summary>
    /// EnvironmentVars contains the environment variables on the kube-controllers that influenced
    /// the RunningConfig.
    /// </summary>
    [JsonPropertyName("environmentVars")]
    public IDictionary<string, string>? EnvironmentVars { get; set; }

    /// <summary>
    /// RunningConfig contains the effective config that is running in the kube-controllers pod, after
    /// merging the API resource with any environment variables.
    /// </summary>
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

    /// <summary>KubeControllersConfigurationSpec contains the values of the Kubernetes controllers configuration.</summary>
    [JsonPropertyName("spec")]
    public V1KubeControllersConfigurationSpec? Spec { get; set; }

    /// <summary>
    /// KubeControllersConfigurationStatus represents the status of the configuration. It&apos;s useful for admins to
    /// be able to see the actual config that was applied, which can be modified by environment variables on the
    /// kube-controllers process.
    /// </summary>
    [JsonPropertyName("status")]
    public V1KubeControllersConfigurationStatus? Status { get; set; }
}