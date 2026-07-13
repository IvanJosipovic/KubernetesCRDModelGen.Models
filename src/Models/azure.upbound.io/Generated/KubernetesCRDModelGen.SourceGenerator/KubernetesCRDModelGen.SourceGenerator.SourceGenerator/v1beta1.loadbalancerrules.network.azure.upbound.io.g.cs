#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.upbound.io;
/// <summary>LoadBalancerRule is the Schema for the LoadBalancerRules API. Manages a Load Balancer Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoadBalancerRuleList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LoadBalancerRule>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoadBalancerRuleList";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "loadbalancerrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerRuleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1LoadBalancerRule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1LoadBalancerRule> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecDeletionPolicyEnum>))]
public enum V1beta1LoadBalancerRuleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicyResolutionEnum>))]
public enum V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicyResolveEnum>))]
public enum V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LoadBalancer in network to populate loadbalancerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicyResolutionEnum>))]
public enum V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicyResolveEnum>))]
public enum V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LoadBalancer in network to populate loadbalancerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecForProvider
{
    /// <summary>A list of reference to a Backend Address Pool over which this Load Balancing Rule operates.</summary>
    [JsonPropertyName("backendAddressPoolIds")]
    public IList<string>? BackendAddressPoolIds { get; set; }

    /// <summary>The port used for internal connections on the endpoint. Possible values range between 0 and 65535, inclusive. A port of 0 means &quot;Any Port&quot;.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>Is snat enabled for this Load Balancer Rule? Default false.</summary>
    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    [JsonPropertyName("enableFloatingIp")]
    public bool? EnableFloatingIp { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Are the Floating IPs enabled for this Load Balancer Rule? A &quot;floating&quot; IP is reassigned to a secondary server in case the primary server fails. Required to configure a SQL AlwaysOn Availability Group. Defaults to false.</summary>
    [JsonPropertyName("floatingIpEnabled")]
    public bool? FloatingIpEnabled { get; set; }

    /// <summary>The name of the frontend IP configuration to which the rule is associated.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The port for the external endpoint. Port numbers for each Rule must be unique within the Load Balancer. Possible values range between 0 and 65534, inclusive. A port of 0 means &quot;Any Port&quot;.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Specifies the idle timeout in minutes for TCP connections. Valid values are between 4 and 100 minutes. Defaults to 4 minutes.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Specifies the load balancing distribution type to be used by the Load Balancer. Possible values are: Default – The load balancer is configured to use a 5 tuple hash to map traffic to available servers. SourceIP – The load balancer is configured to use a 2 tuple hash to map traffic to available servers. SourceIPProtocol – The load balancer is configured to use a 3 tuple hash to map traffic to available servers. Also known as Session Persistence, where in the Azure portal the options are called None, Client IP and Client IP and Protocol respectively. Defaults to Default.</summary>
    [JsonPropertyName("loadDistribution")]
    public string? LoadDistribution { get; set; }

    /// <summary>The ID of the Load Balancer in which to create the Rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadbalancerId")]
    public string? LoadbalancerId { get; set; }

    /// <summary>Reference to a LoadBalancer in network to populate loadbalancerId.</summary>
    [JsonPropertyName("loadbalancerIdRef")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdRef? LoadbalancerIdRef { get; set; }

    /// <summary>Selector for a LoadBalancer in network to populate loadbalancerId.</summary>
    [JsonPropertyName("loadbalancerIdSelector")]
    public V1beta1LoadBalancerRuleSpecForProviderLoadbalancerIdSelector? LoadbalancerIdSelector { get; set; }

    /// <summary>A reference to a Probe used by this Load Balancing Rule.</summary>
    [JsonPropertyName("probeId")]
    public string? ProbeId { get; set; }

    /// <summary>The transport protocol for the external endpoint. Possible values are Tcp, Udp or All.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Is TCP Reset enabled for this Load Balancer Rule?</summary>
    [JsonPropertyName("tcpResetEnabled")]
    public bool? TcpResetEnabled { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecInitProvider
{
    /// <summary>A list of reference to a Backend Address Pool over which this Load Balancing Rule operates.</summary>
    [JsonPropertyName("backendAddressPoolIds")]
    public IList<string>? BackendAddressPoolIds { get; set; }

    /// <summary>The port used for internal connections on the endpoint. Possible values range between 0 and 65535, inclusive. A port of 0 means &quot;Any Port&quot;.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>Is snat enabled for this Load Balancer Rule? Default false.</summary>
    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    [JsonPropertyName("enableFloatingIp")]
    public bool? EnableFloatingIp { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Are the Floating IPs enabled for this Load Balancer Rule? A &quot;floating&quot; IP is reassigned to a secondary server in case the primary server fails. Required to configure a SQL AlwaysOn Availability Group. Defaults to false.</summary>
    [JsonPropertyName("floatingIpEnabled")]
    public bool? FloatingIpEnabled { get; set; }

    /// <summary>The name of the frontend IP configuration to which the rule is associated.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The port for the external endpoint. Port numbers for each Rule must be unique within the Load Balancer. Possible values range between 0 and 65534, inclusive. A port of 0 means &quot;Any Port&quot;.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>Specifies the idle timeout in minutes for TCP connections. Valid values are between 4 and 100 minutes. Defaults to 4 minutes.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Specifies the load balancing distribution type to be used by the Load Balancer. Possible values are: Default – The load balancer is configured to use a 5 tuple hash to map traffic to available servers. SourceIP – The load balancer is configured to use a 2 tuple hash to map traffic to available servers. SourceIPProtocol – The load balancer is configured to use a 3 tuple hash to map traffic to available servers. Also known as Session Persistence, where in the Azure portal the options are called None, Client IP and Client IP and Protocol respectively. Defaults to Default.</summary>
    [JsonPropertyName("loadDistribution")]
    public string? LoadDistribution { get; set; }

    /// <summary>A reference to a Probe used by this Load Balancing Rule.</summary>
    [JsonPropertyName("probeId")]
    public string? ProbeId { get; set; }

    /// <summary>The transport protocol for the external endpoint. Possible values are Tcp, Udp or All.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Is TCP Reset enabled for this Load Balancer Rule?</summary>
    [JsonPropertyName("tcpResetEnabled")]
    public bool? TcpResetEnabled { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecManagementPoliciesEnum>))]
public enum V1beta1LoadBalancerRuleSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1LoadBalancerRuleSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerRuleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1LoadBalancerRuleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1LoadBalancerRuleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1LoadBalancerRuleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoadBalancerRuleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LoadBalancerRuleSpec defines the desired state of LoadBalancerRule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta1LoadBalancerRuleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1LoadBalancerRuleSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1LoadBalancerRuleSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LoadBalancerRuleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LoadBalancerRuleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LoadBalancerRuleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleStatusAtProvider
{
    /// <summary>A list of reference to a Backend Address Pool over which this Load Balancing Rule operates.</summary>
    [JsonPropertyName("backendAddressPoolIds")]
    public IList<string>? BackendAddressPoolIds { get; set; }

    /// <summary>The port used for internal connections on the endpoint. Possible values range between 0 and 65535, inclusive. A port of 0 means &quot;Any Port&quot;.</summary>
    [JsonPropertyName("backendPort")]
    public double? BackendPort { get; set; }

    /// <summary>Is snat enabled for this Load Balancer Rule? Default false.</summary>
    [JsonPropertyName("disableOutboundSnat")]
    public bool? DisableOutboundSnat { get; set; }

    [JsonPropertyName("enableFloatingIp")]
    public bool? EnableFloatingIp { get; set; }

    [JsonPropertyName("enableTcpReset")]
    public bool? EnableTcpReset { get; set; }

    /// <summary>Are the Floating IPs enabled for this Load Balancer Rule? A &quot;floating&quot; IP is reassigned to a secondary server in case the primary server fails. Required to configure a SQL AlwaysOn Availability Group. Defaults to false.</summary>
    [JsonPropertyName("floatingIpEnabled")]
    public bool? FloatingIpEnabled { get; set; }

    /// <summary>The ID of the Load Balancer Rule.</summary>
    [JsonPropertyName("frontendIpConfigurationId")]
    public string? FrontendIpConfigurationId { get; set; }

    /// <summary>The name of the frontend IP configuration to which the rule is associated.</summary>
    [JsonPropertyName("frontendIpConfigurationName")]
    public string? FrontendIpConfigurationName { get; set; }

    /// <summary>The port for the external endpoint. Port numbers for each Rule must be unique within the Load Balancer. Possible values range between 0 and 65534, inclusive. A port of 0 means &quot;Any Port&quot;.</summary>
    [JsonPropertyName("frontendPort")]
    public double? FrontendPort { get; set; }

    /// <summary>The ID of the Load Balancer Rule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies the idle timeout in minutes for TCP connections. Valid values are between 4 and 100 minutes. Defaults to 4 minutes.</summary>
    [JsonPropertyName("idleTimeoutInMinutes")]
    public double? IdleTimeoutInMinutes { get; set; }

    /// <summary>Specifies the load balancing distribution type to be used by the Load Balancer. Possible values are: Default – The load balancer is configured to use a 5 tuple hash to map traffic to available servers. SourceIP – The load balancer is configured to use a 2 tuple hash to map traffic to available servers. SourceIPProtocol – The load balancer is configured to use a 3 tuple hash to map traffic to available servers. Also known as Session Persistence, where in the Azure portal the options are called None, Client IP and Client IP and Protocol respectively. Defaults to Default.</summary>
    [JsonPropertyName("loadDistribution")]
    public string? LoadDistribution { get; set; }

    /// <summary>The ID of the Load Balancer in which to create the Rule. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadbalancerId")]
    public string? LoadbalancerId { get; set; }

    /// <summary>A reference to a Probe used by this Load Balancing Rule.</summary>
    [JsonPropertyName("probeId")]
    public string? ProbeId { get; set; }

    /// <summary>The transport protocol for the external endpoint. Possible values are Tcp, Udp or All.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Is TCP Reset enabled for this Load Balancer Rule?</summary>
    [JsonPropertyName("tcpResetEnabled")]
    public bool? TcpResetEnabled { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>LoadBalancerRuleStatus defines the observed state of LoadBalancerRule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerRuleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1LoadBalancerRuleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoadBalancerRuleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LoadBalancerRule is the Schema for the LoadBalancerRules API. Manages a Load Balancer Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoadBalancerRule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoadBalancerRuleSpec>, IStatus<V1beta1LoadBalancerRuleStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoadBalancerRule";
    public const string KubeGroup = "network.azure.upbound.io";
    public const string KubePluralName = "loadbalancerrules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerRule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LoadBalancerRuleSpec defines the desired state of LoadBalancerRule</summary>
    [JsonPropertyName("spec")]
    public required V1beta1LoadBalancerRuleSpec Spec { get; set; }

    /// <summary>LoadBalancerRuleStatus defines the observed state of LoadBalancerRule.</summary>
    [JsonPropertyName("status")]
    public V1beta1LoadBalancerRuleStatus? Status { get; set; }
}