#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.cnrm.cloud.google.com;
/// <summary>ComputeSubnetwork is the Schema for the ComputeSubnetwork API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSubnetworkList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ComputeSubnetwork>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSubnetworkList";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesubnetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeSubnetworkList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ComputeSubnetwork objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ComputeSubnetwork> Items { get; set; }
}

/// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn&apos;t supported if the subnet &apos;purpose&apos; field is set to subnetwork is &apos;REGIONAL_MANAGED_PROXY&apos; or &apos;GLOBAL_MANAGED_PROXY&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpecLogConfig
{
    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. Toggles the aggregation interval for collecting flow logs. Increasing the interval time will reduce the amount of generated flow logs for long lasting connections. Default is an interval of 5 seconds per connection. Check the AggregationInterval enum for the list of possible values.</summary>
    [JsonPropertyName("aggregationInterval")]
    public string? AggregationInterval { get; set; }

    /// <summary>Can only be specified if VPC flow logs for this subnetwork is enabled. The filter expression is used to define which VPC flow logs should be exported to Cloud Logging.</summary>
    [JsonPropertyName("filterExpr")]
    public string? FilterExpr { get; set; }

    /// <summary>Can only be specified if VPC flow logging for this subnetwork is enabled. The value of the field must be in [0, 1]. Set the sampling rate of VPC flow logs within the subnetwork where 1.0 means all collected logs are reported and 0.0 means no logs are reported. Default is 0.5 unless otherwise specified by the org policy, which means half of all collected logs are reported.</summary>
    [JsonPropertyName("flowSampling")]
    public double? FlowSampling { get; set; }

    /// <summary>Can only be specified if VPC flow logs for this subnetwork is enabled. Configures whether all, none or a subset of metadata fields should be added to the reported VPC flow logs. Default is EXCLUDE_ALL_METADATA. Check the Metadata enum for the list of possible values.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>Can only be specified if VPC flow logs for this subnetwork is enabled and &quot;metadata&quot; was set to CUSTOM_METADATA.</summary>
    [JsonPropertyName("metadataFields")]
    public IList<string>? MetadataFields { get; set; }
}

/// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpecNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpecSecondaryIpRange
{
    /// <summary>The range of IP addresses belonging to this subnetwork secondary range. Provide this property when you create the subnetwork. Ranges must be unique and non-overlapping with all primary and secondary IP ranges within a network. Only IPv4 is supported. The range can be any range listed in the Valid ranges list.</summary>
    [JsonPropertyName("ipCidrRange")]
    public required string IpCidrRange { get; set; }

    /// <summary>The name associated with this subnetwork secondary range, used when adding an alias IP range to a VM instance. The name must be 1-63 characters long, and comply with RFC1035. The name must be unique within the subnetwork.</summary>
    [JsonPropertyName("rangeName")]
    public required string RangeName { get; set; }
}

/// <summary>ComputeSubnetworkSpec defines the desired state of ComputeSubnetwork</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkSpec
{
    /// <summary>Immutable. An optional description of this resource. Provide this property when you create the resource. This field can be set only at resource creation time.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The range of internal addresses that are owned by this subnetwork. Provide this property when you create the subnetwork. For example, 10.0.0.0/8 or 192.168.0.0/16. Ranges must be unique and non-overlapping within a network. Only IPv4 is supported.</summary>
    [JsonPropertyName("ipCidrRange")]
    public required string IpCidrRange { get; set; }

    /// <summary>The access type of IPv6 address this subnet holds. It&apos;s immutable and can only be specified during creation or the first time the subnet is updated into IPV4_IPV6 dual stack. If the ipv6_type is EXTERNAL then this subnet cannot enable direct path. Possible values: [&quot;EXTERNAL&quot;, &quot;INTERNAL&quot;].</summary>
    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    /// <summary>This field denotes the VPC flow logging options for this subnetwork. If logging is enabled, logs are exported to Cloud Logging. Flow logging isn&apos;t supported if the subnet &apos;purpose&apos; field is set to subnetwork is &apos;REGIONAL_MANAGED_PROXY&apos; or &apos;GLOBAL_MANAGED_PROXY&apos;.</summary>
    [JsonPropertyName("logConfig")]
    public V1beta1ComputeSubnetworkSpecLogConfig? LogConfig { get; set; }

    /// <summary>The network this subnet belongs to. Only networks that are in the distributed mode can have subnetworks.</summary>
    [JsonPropertyName("networkRef")]
    public required V1beta1ComputeSubnetworkSpecNetworkRef NetworkRef { get; set; }

    /// <summary>When enabled, VMs in this subnetwork without external IP addresses can access Google APIs and services by using Private Google Access.</summary>
    [JsonPropertyName("privateIpGoogleAccess")]
    public bool? PrivateIpGoogleAccess { get; set; }

    /// <summary>The private IPv6 google access type for the VMs in this subnet.</summary>
    [JsonPropertyName("privateIpv6GoogleAccess")]
    public string? PrivateIpv6GoogleAccess { get; set; }

    /// <summary>Immutable. The purpose of the resource. This field can be either &apos;PRIVATE_RFC_1918&apos;, &apos;REGIONAL_MANAGED_PROXY&apos;, &apos;GLOBAL_MANAGED_PROXY&apos;, or &apos;PRIVATE_SERVICE_CONNECT&apos;. A subnet with purpose set to &apos;REGIONAL_MANAGED_PROXY&apos; is a user-created subnetwork that is reserved for regional Envoy-based load balancers. A subnetwork in a given region with purpose set to &apos;GLOBAL_MANAGED_PROXY&apos; is a proxy-only subnet and is shared between all the cross-regional Envoy-based load balancers. A subnetwork with purpose set to &apos;PRIVATE_SERVICE_CONNECT&apos; reserves the subnet for hosting a Private Service Connect published service. Note that &apos;REGIONAL_MANAGED_PROXY&apos; is the preferred setting for all regional Envoy load balancers. If unspecified, the purpose defaults to &apos;PRIVATE_RFC_1918&apos;.</summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>Immutable. The GCP region for this subnetwork.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Immutable. Optional. The name of the resource. Used for creation and acquisition. When unset, the value of `metadata.name` is used as the default.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The role of subnetwork. Currently, this field is only used when &apos;purpose&apos; is &apos;REGIONAL_MANAGED_PROXY&apos;. The value can be set to &apos;ACTIVE&apos; or &apos;BACKUP&apos;. An &apos;ACTIVE&apos; subnetwork is one that is currently being used for Envoy-based load balancers in a region. A &apos;BACKUP&apos; subnetwork is one that is ready to be promoted to &apos;ACTIVE&apos; or is currently draining. Possible values: [&quot;ACTIVE&quot;, &quot;BACKUP&quot;].</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("secondaryIpRange")]
    public IList<V1beta1ComputeSubnetworkSpecSecondaryIpRange>? SecondaryIpRange { get; set; }

    /// <summary>The stack type for this subnet to identify whether the IPv6 feature is enabled or not. If not specified IPV4_ONLY will be used. Possible values: [&quot;IPV4_ONLY&quot;, &quot;IPV4_IPV6&quot;].</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkStatusConditions
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

/// <summary>ComputeSubnetworkStatus defines the config connector machine state of ComputeSubnetwork</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ComputeSubnetworkStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ComputeSubnetworkStatusConditions>? Conditions { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>The range of external IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("externalIpv6Prefix")]
    public string? ExternalIpv6Prefix { get; set; }

    /// <summary>DEPRECATED. This field is not useful for users, and has been removed as an output. Fingerprint of this resource. This field is used internally during updates of this resource.</summary>
    [JsonPropertyName("fingerprint")]
    public string? Fingerprint { get; set; }

    /// <summary>The gateway address for default routes to reach destination addresses outside this subnetwork.</summary>
    [JsonPropertyName("gatewayAddress")]
    public string? GatewayAddress { get; set; }

    /// <summary>The internal IPv6 address range that is assigned to this subnetwork.</summary>
    [JsonPropertyName("internalIpv6Prefix")]
    public string? InternalIpv6Prefix { get; set; }

    /// <summary>The range of internal IPv6 addresses that are owned by this subnetwork.</summary>
    [JsonPropertyName("ipv6CidrRange")]
    public string? Ipv6CidrRange { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>Server-defined URL for the resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }
}

/// <summary>ComputeSubnetwork is the Schema for the ComputeSubnetwork API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ComputeSubnetwork : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ComputeSubnetworkSpec>, IStatus<V1beta1ComputeSubnetworkStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ComputeSubnetwork";
    public const string KubeGroup = "compute.cnrm.cloud.google.com";
    public const string KubePluralName = "computesubnetworks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ComputeSubnetwork";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ComputeSubnetworkSpec defines the desired state of ComputeSubnetwork</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ComputeSubnetworkSpec Spec { get; set; }

    /// <summary>ComputeSubnetworkStatus defines the config connector machine state of ComputeSubnetwork</summary>
    [JsonPropertyName("status")]
    public V1beta1ComputeSubnetworkStatus? Status { get; set; }
}