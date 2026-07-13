#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.network.azure.m.upbound.io;
/// <summary>LoadBalancerBackendAddressPool is the Schema for the LoadBalancerBackendAddressPools API. Manages a Load Balancer Backend Address Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoadBalancerBackendAddressPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1LoadBalancerBackendAddressPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoadBalancerBackendAddressPoolList";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "loadbalancerbackendaddresspools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerBackendAddressPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1LoadBalancerBackendAddressPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1LoadBalancerBackendAddressPool> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicyResolutionEnum>))]
public enum V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicyResolveEnum>))]
public enum V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LoadBalancer in network to populate loadbalancerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicyResolutionEnum>))]
public enum V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicyResolveEnum>))]
public enum V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LoadBalancer in network to populate loadbalancerId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecForProviderTunnelInterface
{
    /// <summary>The unique identifier of this Gateway Load Balancer Tunnel Interface.</summary>
    [JsonPropertyName("identifier")]
    public double? Identifier { get; set; }

    /// <summary>The port number that this Gateway Load Balancer Tunnel Interface listens to.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol used for this Gateway Load Balancer Tunnel Interface. Possible values are None, Native and VXLAN.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The traffic type of this Gateway Load Balancer Tunnel Interface. Possible values are None, Internal and External.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecForProvider
{
    /// <summary>The ID of the Load Balancer in which to create the Backend Address Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadbalancerId")]
    public string? LoadbalancerId { get; set; }

    /// <summary>Reference to a LoadBalancer in network to populate loadbalancerId.</summary>
    [JsonPropertyName("loadbalancerIdRef")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdRef? LoadbalancerIdRef { get; set; }

    /// <summary>Selector for a LoadBalancer in network to populate loadbalancerId.</summary>
    [JsonPropertyName("loadbalancerIdSelector")]
    public V1beta1LoadBalancerBackendAddressPoolSpecForProviderLoadbalancerIdSelector? LoadbalancerIdSelector { get; set; }

    /// <summary>The backend address synchronous mode for the Backend Address Pool. Possible values are Automatic and Manual. This is required with virtual_network_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("synchronousMode")]
    public string? SynchronousMode { get; set; }

    /// <summary>One or more tunnel_interface blocks as defined below.</summary>
    [JsonPropertyName("tunnelInterface")]
    public IList<V1beta1LoadBalancerBackendAddressPoolSpecForProviderTunnelInterface>? TunnelInterface { get; set; }

    /// <summary>The ID of the Virtual Network within which the Backend Address Pool should exist.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecInitProviderTunnelInterface
{
    /// <summary>The unique identifier of this Gateway Load Balancer Tunnel Interface.</summary>
    [JsonPropertyName("identifier")]
    public double? Identifier { get; set; }

    /// <summary>The port number that this Gateway Load Balancer Tunnel Interface listens to.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol used for this Gateway Load Balancer Tunnel Interface. Possible values are None, Native and VXLAN.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The traffic type of this Gateway Load Balancer Tunnel Interface. Possible values are None, Internal and External.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecInitProvider
{
    /// <summary>The backend address synchronous mode for the Backend Address Pool. Possible values are Automatic and Manual. This is required with virtual_network_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("synchronousMode")]
    public string? SynchronousMode { get; set; }

    /// <summary>One or more tunnel_interface blocks as defined below.</summary>
    [JsonPropertyName("tunnelInterface")]
    public IList<V1beta1LoadBalancerBackendAddressPoolSpecInitProviderTunnelInterface>? TunnelInterface { get; set; }

    /// <summary>The ID of the Virtual Network within which the Backend Address Pool should exist.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1LoadBalancerBackendAddressPoolSpecManagementPoliciesEnum>))]
public enum V1beta1LoadBalancerBackendAddressPoolSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>LoadBalancerBackendAddressPoolSpec defines the desired state of LoadBalancerBackendAddressPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1LoadBalancerBackendAddressPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta1LoadBalancerBackendAddressPoolSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1LoadBalancerBackendAddressPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1LoadBalancerBackendAddressPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1LoadBalancerBackendAddressPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolStatusAtProviderTunnelInterface
{
    /// <summary>The unique identifier of this Gateway Load Balancer Tunnel Interface.</summary>
    [JsonPropertyName("identifier")]
    public double? Identifier { get; set; }

    /// <summary>The port number that this Gateway Load Balancer Tunnel Interface listens to.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The protocol used for this Gateway Load Balancer Tunnel Interface. Possible values are None, Native and VXLAN.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>The traffic type of this Gateway Load Balancer Tunnel Interface. Possible values are None, Internal and External.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolStatusAtProvider
{
    /// <summary>The Backend IP Configurations associated with this Backend Address Pool.</summary>
    [JsonPropertyName("backendIpConfigurations")]
    public IList<string>? BackendIpConfigurations { get; set; }

    /// <summary>The ID of the Backend Address Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An array of the Load Balancing Inbound NAT Rules associated with this Backend Address Pool.</summary>
    [JsonPropertyName("inboundNatRules")]
    public IList<string>? InboundNatRules { get; set; }

    /// <summary>The Load Balancing Rules associated with this Backend Address Pool.</summary>
    [JsonPropertyName("loadBalancingRules")]
    public IList<string>? LoadBalancingRules { get; set; }

    /// <summary>The ID of the Load Balancer in which to create the Backend Address Pool. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("loadbalancerId")]
    public string? LoadbalancerId { get; set; }

    /// <summary>An array of the Load Balancing Outbound Rules associated with this Backend Address Pool.</summary>
    [JsonPropertyName("outboundRules")]
    public IList<string>? OutboundRules { get; set; }

    /// <summary>The backend address synchronous mode for the Backend Address Pool. Possible values are Automatic and Manual. This is required with virtual_network_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("synchronousMode")]
    public string? SynchronousMode { get; set; }

    /// <summary>One or more tunnel_interface blocks as defined below.</summary>
    [JsonPropertyName("tunnelInterface")]
    public IList<V1beta1LoadBalancerBackendAddressPoolStatusAtProviderTunnelInterface>? TunnelInterface { get; set; }

    /// <summary>The ID of the Virtual Network within which the Backend Address Pool should exist.</summary>
    [JsonPropertyName("virtualNetworkId")]
    public string? VirtualNetworkId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolStatusConditions
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

/// <summary>LoadBalancerBackendAddressPoolStatus defines the observed state of LoadBalancerBackendAddressPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1LoadBalancerBackendAddressPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1LoadBalancerBackendAddressPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1LoadBalancerBackendAddressPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LoadBalancerBackendAddressPool is the Schema for the LoadBalancerBackendAddressPools API. Manages a Load Balancer Backend Address Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1LoadBalancerBackendAddressPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1LoadBalancerBackendAddressPoolSpec>, IStatus<V1beta1LoadBalancerBackendAddressPoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "LoadBalancerBackendAddressPool";
    public const string KubeGroup = "network.azure.m.upbound.io";
    public const string KubePluralName = "loadbalancerbackendaddresspools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "network.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LoadBalancerBackendAddressPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LoadBalancerBackendAddressPoolSpec defines the desired state of LoadBalancerBackendAddressPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1LoadBalancerBackendAddressPoolSpec Spec { get; set; }

    /// <summary>LoadBalancerBackendAddressPoolStatus defines the observed state of LoadBalancerBackendAddressPool.</summary>
    [JsonPropertyName("status")]
    public V1beta1LoadBalancerBackendAddressPoolStatus? Status { get; set; }
}