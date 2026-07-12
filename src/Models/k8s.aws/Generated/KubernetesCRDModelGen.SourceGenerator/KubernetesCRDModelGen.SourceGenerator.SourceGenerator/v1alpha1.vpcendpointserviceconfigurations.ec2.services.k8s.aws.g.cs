#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.services.k8s.aws;
/// <summary>VPCEndpointServiceConfiguration is the Schema for the VPCEndpointServiceConfigurations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCEndpointServiceConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VPCEndpointServiceConfiguration>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCEndpointServiceConfigurationList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcendpointserviceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCEndpointServiceConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VPCEndpointServiceConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VPCEndpointServiceConfiguration> Items { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>VpcEndpointServiceConfigurationSpec defines the desired state of VpcEndpointServiceConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationSpec
{
    /// <summary>
    /// Indicates whether requests from service consumers to create an endpoint to
    /// your service must be accepted manually.
    /// </summary>
    [JsonPropertyName("acceptanceRequired")]
    public bool? AcceptanceRequired { get; set; }

    /// <summary>
    /// The Amazon Resource Names (ARN) of the principals. Permissions are granted
    /// to the principals in this list. To grant permissions to all principals, specify
    /// an asterisk (*).
    /// </summary>
    [JsonPropertyName("allowedPrincipals")]
    public IList<string>? AllowedPrincipals { get; set; }

    /// <summary>The Amazon Resource Names (ARNs) of the Gateway Load Balancers.</summary>
    [JsonPropertyName("gatewayLoadBalancerARNs")]
    public IList<string>? GatewayLoadBalancerARNs { get; set; }

    /// <summary>The Amazon Resource Names (ARNs) of the Network Load Balancers.</summary>
    [JsonPropertyName("networkLoadBalancerARNs")]
    public IList<string>? NetworkLoadBalancerARNs { get; set; }

    /// <summary>
    /// (Interface endpoint configuration) The private DNS name to assign to the
    /// VPC endpoint service.
    /// </summary>
    [JsonPropertyName("privateDNSName")]
    public string? PrivateDNSName { get; set; }

    /// <summary>The supported IP address types. The possible values are ipv4 and ipv6.</summary>
    [JsonPropertyName("supportedIPAddressTypes")]
    public IList<string>? SupportedIPAddressTypes { get; set; }

    /// <summary>The Regions from which service consumers can access the service.</summary>
    [JsonPropertyName("supportedRegions")]
    public IList<string>? SupportedRegions { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1VPCEndpointServiceConfigurationSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Information about the endpoint service private DNS name configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationStatusPrivateDNSNameConfiguration
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Describes the type of service for a VPC endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationStatusServiceType
{
    [JsonPropertyName("serviceType")]
    public string? ServiceType { get; set; }
}

/// <summary>VPCEndpointServiceConfigurationStatus defines the observed state of VPCEndpointServiceConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VPCEndpointServiceConfigurationStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1VPCEndpointServiceConfigurationStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The Availability Zones in which the service is available.
    /// 
    /// Either AvailabilityZone or AvailabilityZoneId can be specified, but not both
    /// </summary>
    [JsonPropertyName("availabilityZones")]
    public IList<string>? AvailabilityZones { get; set; }

    /// <summary>The DNS names for the service.</summary>
    [JsonPropertyName("baseEndpointDNSNames")]
    public IList<string>? BaseEndpointDNSNames { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VPCEndpointServiceConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Indicates whether the service manages its VPC endpoints. Management of the
    /// service VPC endpoints using the VPC endpoint API is restricted.
    /// </summary>
    [JsonPropertyName("managesVPCEndpoints")]
    public bool? ManagesVPCEndpoints { get; set; }

    /// <summary>The payer responsibility.</summary>
    [JsonPropertyName("payerResponsibility")]
    public string? PayerResponsibility { get; set; }

    /// <summary>Information about the endpoint service private DNS name configuration.</summary>
    [JsonPropertyName("privateDNSNameConfiguration")]
    public V1alpha1VPCEndpointServiceConfigurationStatusPrivateDNSNameConfiguration? PrivateDNSNameConfiguration { get; set; }

    /// <summary>The ID of the service.</summary>
    [JsonPropertyName("serviceID")]
    public string? ServiceID { get; set; }

    /// <summary>The name of the service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>The service state.</summary>
    [JsonPropertyName("serviceState")]
    public string? ServiceState { get; set; }

    /// <summary>The type of service.</summary>
    [JsonPropertyName("serviceType")]
    public IList<V1alpha1VPCEndpointServiceConfigurationStatusServiceType>? ServiceType { get; set; }
}

/// <summary>VPCEndpointServiceConfiguration is the Schema for the VPCEndpointServiceConfigurations API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VPCEndpointServiceConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VPCEndpointServiceConfigurationSpec?>, IStatus<V1alpha1VPCEndpointServiceConfigurationStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VPCEndpointServiceConfiguration";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "vpcendpointserviceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VPCEndpointServiceConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VpcEndpointServiceConfigurationSpec defines the desired state of VpcEndpointServiceConfiguration.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1VPCEndpointServiceConfigurationSpec? Spec { get; set; }

    /// <summary>VPCEndpointServiceConfigurationStatus defines the observed state of VPCEndpointServiceConfiguration</summary>
    [JsonPropertyName("status")]
    public V1alpha1VPCEndpointServiceConfigurationStatus? Status { get; set; }
}