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
/// <summary>Instance is the Schema for the Instances API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Instance>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Instance> Items { get; set; }
}

/// <summary>Describes a block device for an EBS volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecBlockDeviceMappingsEbs
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("outpostARN")]
    public string? OutpostARN { get; set; }

    [JsonPropertyName("snapshotID")]
    public string? SnapshotID { get; set; }

    [JsonPropertyName("throughput")]
    public long? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public long? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>
/// Describes a block device mapping, which defines the EBS volumes and instance
/// store volumes to attach to an instance at launch.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecBlockDeviceMappings
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Describes a block device for an EBS volume.</summary>
    [JsonPropertyName("ebs")]
    public V1alpha1InstanceSpecBlockDeviceMappingsEbs? Ebs { get; set; }

    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Describes a target Capacity Reservation or Capacity Reservation group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecCapacityReservationSpecificationCapacityReservationTarget
{
    [JsonPropertyName("capacityReservationID")]
    public string? CapacityReservationID { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupARN")]
    public string? CapacityReservationResourceGroupARN { get; set; }
}

/// <summary>
/// Information about the Capacity Reservation targeting option. If you do not
/// specify this parameter, the instance&apos;s Capacity Reservation preference defaults
/// to open, which enables it to run in any open Capacity Reservation that has
/// matching attributes (instance type, platform, Availability Zone, and tenancy).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Describes a target Capacity Reservation or Capacity Reservation group.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1alpha1InstanceSpecCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>
/// The CPU options for the instance. For more information, see Optimize CPU
/// options (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html)
/// in the Amazon EC2 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecCpuOptions
{
    [JsonPropertyName("coreCount")]
    public long? CoreCount { get; set; }

    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public long? ThreadsPerCore { get; set; }
}

/// <summary>
/// The credit option for CPU usage of the burstable performance instance. Valid
/// values are standard and unlimited. To change this attribute after launch,
/// use ModifyInstanceCreditSpecification (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyInstanceCreditSpecification.html).
/// For more information, see Burstable performance instances (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html)
/// in the Amazon EC2 User Guide.
/// 
/// Default: standard (T2 instances) or unlimited (T3/T3a/T4g instances)
/// 
/// For T3 instances with host tenancy, only standard is supported.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>
/// Amazon Elastic Graphics reached end of life on January 8, 2024.
/// 
/// A specification for an Elastic Graphics accelerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecElasticGPUSpecification
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Amazon Elastic Inference is no longer available.
/// 
/// Describes an elastic inference accelerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecElasticInferenceAccelerators
{
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
/// For more information, see Amazon Web Services Nitro Enclaves User Guide (https://docs.aws.amazon.com/enclaves/latest/user/).
/// 
/// You can&apos;t enable Amazon Web Services Nitro Enclaves and hibernation on the
/// same instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Indicates whether an instance is enabled for hibernation. This parameter
/// is valid only if the instance meets the hibernation prerequisites (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html).
/// For more information, see Hibernate your Amazon EC2 instance (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html)
/// in the Amazon EC2 User Guide.
/// 
/// You can&apos;t enable hibernation and Amazon Web Services Nitro Enclaves on the
/// same instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecHibernationOptions
{
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

/// <summary>The name or Amazon Resource Name (ARN) of an IAM instance profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecIamInstanceProfile
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The options for Spot Instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecInstanceMarketOptionsSpotOptions
{
    [JsonPropertyName("blockDurationMinutes")]
    public long? BlockDurationMinutes { get; set; }

    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    [JsonPropertyName("validUntil")]
    public DateTime? ValidUntil { get; set; }
}

/// <summary>
/// The market (purchasing) option for the instances.
/// 
/// For RunInstances, persistent Spot Instance requests are only supported when
/// InstanceInterruptionBehavior is set to either hibernate or stop.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecInstanceMarketOptions
{
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instances.</summary>
    [JsonPropertyName("spotOptions")]
    public V1alpha1InstanceSpecInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Describes an IPv6 address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecIpv6Addresses
{
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecLaunchTemplateLaunchTemplateRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for LaunchTemplateID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecLaunchTemplateLaunchTemplateRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1InstanceSpecLaunchTemplateLaunchTemplateRefFrom? From { get; set; }
}

/// <summary>
/// The launch template. Any additional parameters that you specify for the new
/// instance overwrite the corresponding parameters included in the launch template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecLaunchTemplate
{
    [JsonPropertyName("launchTemplateID")]
    public string? LaunchTemplateID { get; set; }

    [JsonPropertyName("launchTemplateName")]
    public string? LaunchTemplateName { get; set; }

    /// <summary>Reference field for LaunchTemplateID</summary>
    [JsonPropertyName("launchTemplateRef")]
    public V1alpha1InstanceSpecLaunchTemplateLaunchTemplateRef? LaunchTemplateRef { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Describes a license configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecLicenseSpecifications
{
    [JsonPropertyName("licenseConfigurationARN")]
    public string? LicenseConfigurationARN { get; set; }
}

/// <summary>The maintenance and recovery options for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>
/// The metadata options for the instance. For more information, see Configure
/// the Instance Metadata Service options (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecMetadataOptions
{
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    [JsonPropertyName("httpProtocolIPv6")]
    public string? HttpProtocolIPv6 { get; set; }

    [JsonPropertyName("httpPutResponseHopLimit")]
    public long? HttpPutResponseHopLimit { get; set; }

    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary>Specifies whether detailed monitoring is enabled for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecMonitoring
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Describes the IPv4 prefix option for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecNetworkInterfacesIpv4Prefixes
{
    [JsonPropertyName("ipv4Prefix")]
    public string? Ipv4Prefix { get; set; }
}

/// <summary>Describes an IPv6 address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecNetworkInterfacesIpv6Addresses
{
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>Describes the IPv6 prefix option for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecNetworkInterfacesIpv6Prefixes
{
    [JsonPropertyName("ipv6Prefix")]
    public string? Ipv6Prefix { get; set; }
}

/// <summary>Describes a secondary private IPv4 address for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecNetworkInterfacesPrivateIPAddresses
{
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }
}

/// <summary>Describes a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecNetworkInterfaces
{
    [JsonPropertyName("associateCarrierIPAddress")]
    public bool? AssociateCarrierIPAddress { get; set; }

    [JsonPropertyName("associatePublicIPAddress")]
    public bool? AssociatePublicIPAddress { get; set; }

    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("deviceIndex")]
    public long? DeviceIndex { get; set; }

    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    [JsonPropertyName("ipv4PrefixCount")]
    public long? Ipv4PrefixCount { get; set; }

    [JsonPropertyName("ipv4Prefixes")]
    public IList<V1alpha1InstanceSpecNetworkInterfacesIpv4Prefixes>? Ipv4Prefixes { get; set; }

    [JsonPropertyName("ipv6AddressCount")]
    public long? Ipv6AddressCount { get; set; }

    [JsonPropertyName("ipv6Addresses")]
    public IList<V1alpha1InstanceSpecNetworkInterfacesIpv6Addresses>? Ipv6Addresses { get; set; }

    [JsonPropertyName("ipv6PrefixCount")]
    public long? Ipv6PrefixCount { get; set; }

    [JsonPropertyName("ipv6Prefixes")]
    public IList<V1alpha1InstanceSpecNetworkInterfacesIpv6Prefixes>? Ipv6Prefixes { get; set; }

    [JsonPropertyName("networkCardIndex")]
    public long? NetworkCardIndex { get; set; }

    [JsonPropertyName("networkInterfaceID")]
    public string? NetworkInterfaceID { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    [JsonPropertyName("privateIPAddresses")]
    public IList<V1alpha1InstanceSpecNetworkInterfacesPrivateIPAddresses>? PrivateIPAddresses { get; set; }

    [JsonPropertyName("secondaryPrivateIPAddressCount")]
    public long? SecondaryPrivateIPAddressCount { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>The placement for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecPlacement
{
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    [JsonPropertyName("hostID")]
    public string? HostID { get; set; }

    [JsonPropertyName("hostResourceGroupARN")]
    public string? HostResourceGroupARN { get; set; }

    [JsonPropertyName("partitionNumber")]
    public long? PartitionNumber { get; set; }

    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary>
/// The options for the instance hostname. The default values are inherited from
/// the subnet. Applies only if creating a network interface, not attaching an
/// existing one.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecPrivateDNSNameOptions
{
    [JsonPropertyName("enableResourceNameDNSAAAARecord")]
    public bool? EnableResourceNameDNSAAAARecord { get; set; }

    [JsonPropertyName("enableResourceNameDNSARecord")]
    public bool? EnableResourceNameDNSARecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecSubnetRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecSubnetRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1InstanceSpecSubnetRefFrom? From { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// InstanceSpec defines the desired state of Instance.
/// 
/// Describes an instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceSpec
{
    /// <summary>
    /// The block device mapping, which defines the EBS volumes and instance store
    /// volumes to attach to the instance at launch. For more information, see Block
    /// device mappings (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1alpha1InstanceSpecBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>
    /// Information about the Capacity Reservation targeting option. If you do not
    /// specify this parameter, the instance&apos;s Capacity Reservation preference defaults
    /// to open, which enables it to run in any open Capacity Reservation that has
    /// matching attributes (instance type, platform, Availability Zone, and tenancy).
    /// </summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1alpha1InstanceSpecCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// The CPU options for the instance. For more information, see Optimize CPU
    /// options (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("cpuOptions")]
    public V1alpha1InstanceSpecCpuOptions? CpuOptions { get; set; }

    /// <summary>
    /// The credit option for CPU usage of the burstable performance instance. Valid
    /// values are standard and unlimited. To change this attribute after launch,
    /// use ModifyInstanceCreditSpecification (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyInstanceCreditSpecification.html).
    /// For more information, see Burstable performance instances (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html)
    /// in the Amazon EC2 User Guide.
    /// 
    /// Default: standard (T2 instances) or unlimited (T3/T3a/T4g instances)
    /// 
    /// For T3 instances with host tenancy, only standard is supported.
    /// </summary>
    [JsonPropertyName("creditSpecification")]
    public V1alpha1InstanceSpecCreditSpecification? CreditSpecification { get; set; }

    /// <summary>
    /// Indicates whether an instance is enabled for stop protection. For more information,
    /// see Enable stop protection for your EC2 instances (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-stop-protection.html).
    /// </summary>
    [JsonPropertyName("disableAPIStop")]
    public bool? DisableAPIStop { get; set; }

    /// <summary>
    /// Indicates whether termination protection is enabled for the instance. The
    /// default is false, which means that you can terminate the instance using the
    /// Amazon EC2 console, command line tools, or API. You can enable termination
    /// protection when you launch an instance, while the instance is running, or
    /// while the instance is stopped.
    /// </summary>
    [JsonPropertyName("disableAPITermination")]
    public bool? DisableAPITermination { get; set; }

    /// <summary>
    /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
    /// provides dedicated throughput to Amazon EBS and an optimized configuration
    /// stack to provide optimal Amazon EBS I/O performance. This optimization isn&apos;t
    /// available with all instance types. Additional usage charges apply when using
    /// an EBS-optimized instance.
    /// 
    /// Default: false
    /// </summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>
    /// An elastic GPU to associate with the instance.
    /// 
    /// Amazon Elastic Graphics reached end of life on January 8, 2024.
    /// </summary>
    [JsonPropertyName("elasticGPUSpecification")]
    public IList<V1alpha1InstanceSpecElasticGPUSpecification>? ElasticGPUSpecification { get; set; }

    /// <summary>
    /// An elastic inference accelerator to associate with the instance.
    /// 
    /// Amazon Elastic Inference is no longer available.
    /// </summary>
    [JsonPropertyName("elasticInferenceAccelerators")]
    public IList<V1alpha1InstanceSpecElasticInferenceAccelerators>? ElasticInferenceAccelerators { get; set; }

    /// <summary>
    /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
    /// For more information, see Amazon Web Services Nitro Enclaves User Guide (https://docs.aws.amazon.com/enclaves/latest/user/).
    /// 
    /// You can&apos;t enable Amazon Web Services Nitro Enclaves and hibernation on the
    /// same instance.
    /// </summary>
    [JsonPropertyName("enclaveOptions")]
    public V1alpha1InstanceSpecEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>
    /// Indicates whether an instance is enabled for hibernation. This parameter
    /// is valid only if the instance meets the hibernation prerequisites (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html).
    /// For more information, see Hibernate your Amazon EC2 instance (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html)
    /// in the Amazon EC2 User Guide.
    /// 
    /// You can&apos;t enable hibernation and Amazon Web Services Nitro Enclaves on the
    /// same instance.
    /// </summary>
    [JsonPropertyName("hibernationOptions")]
    public V1alpha1InstanceSpecHibernationOptions? HibernationOptions { get; set; }

    /// <summary>The name or Amazon Resource Name (ARN) of an IAM instance profile.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public V1alpha1InstanceSpecIamInstanceProfile? IamInstanceProfile { get; set; }

    /// <summary>
    /// The ID of the AMI. An AMI ID is required to launch an instance and must be
    /// specified here or in a launch template.
    /// </summary>
    [JsonPropertyName("imageID")]
    public string? ImageID { get; set; }

    /// <summary>
    /// Indicates whether an instance stops or terminates when you initiate shutdown
    /// from the instance (using the operating system command for system shutdown).
    /// 
    /// Default: stop
    /// </summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The market (purchasing) option for the instances.
    /// 
    /// For RunInstances, persistent Spot Instance requests are only supported when
    /// InstanceInterruptionBehavior is set to either hibernate or stop.
    /// </summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1alpha1InstanceSpecInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>
    /// The instance type. For more information, see Amazon EC2 Instance Types Guide
    /// (https://docs.aws.amazon.com/ec2/latest/instancetypes/instance-types.html).
    /// </summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// The number of IPv6 addresses to associate with the primary network interface.
    /// Amazon EC2 chooses the IPv6 addresses from the range of your subnet. You
    /// cannot specify this option and the option to assign specific IPv6 addresses
    /// in the same request. You can specify this option if you&apos;ve specified a minimum
    /// number of instances to launch.
    /// 
    /// You cannot specify this option and the network interfaces option in the same
    /// request.
    /// </summary>
    [JsonPropertyName("ipv6AddressCount")]
    public long? Ipv6AddressCount { get; set; }

    /// <summary>
    /// The IPv6 addresses from the range of the subnet to associate with the primary
    /// network interface. You cannot specify this option and the option to assign
    /// a number of IPv6 addresses in the same request. You cannot specify this option
    /// if you&apos;ve specified a minimum number of instances to launch.
    /// 
    /// You cannot specify this option and the network interfaces option in the same
    /// request.
    /// </summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<V1alpha1InstanceSpecIpv6Addresses>? Ipv6Addresses { get; set; }

    /// <summary>
    /// The ID of the kernel.
    /// 
    /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more
    /// information, see PV-GRUB (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("kernelID")]
    public string? KernelID { get; set; }

    /// <summary>
    /// The name of the key pair. For more information, see Create a key pair for
    /// your EC2 instance (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-key-pairs.html).
    /// 
    /// If you do not specify a key pair, you can&apos;t connect to the instance unless
    /// you choose an AMI that is configured to allow users another way to log in.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// The launch template. Any additional parameters that you specify for the new
    /// instance overwrite the corresponding parameters included in the launch template.
    /// </summary>
    [JsonPropertyName("launchTemplate")]
    public V1alpha1InstanceSpecLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>The license configurations.</summary>
    [JsonPropertyName("licenseSpecifications")]
    public IList<V1alpha1InstanceSpecLicenseSpecifications>? LicenseSpecifications { get; set; }

    /// <summary>The maintenance and recovery options for the instance.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1alpha1InstanceSpecMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>
    /// The maximum number of instances to launch. If you specify a value that is
    /// more capacity than Amazon EC2 can launch in the target Availability Zone,
    /// Amazon EC2 launches the largest possible number of instances above the specified
    /// minimum count.
    /// 
    /// Constraints: Between 1 and the quota for the specified instance type for
    /// your account for this Region. For more information, see Amazon EC2 instance
    /// type quotas (https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html).
    /// </summary>
    [JsonPropertyName("maxCount")]
    public long? MaxCount { get; set; }

    /// <summary>
    /// The metadata options for the instance. For more information, see Configure
    /// the Instance Metadata Service options (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html).
    /// </summary>
    [JsonPropertyName("metadataOptions")]
    public V1alpha1InstanceSpecMetadataOptions? MetadataOptions { get; set; }

    /// <summary>
    /// The minimum number of instances to launch. If you specify a value that is
    /// more capacity than Amazon EC2 can provide in the target Availability Zone,
    /// Amazon EC2 does not launch any instances.
    /// 
    /// Constraints: Between 1 and the quota for the specified instance type for
    /// your account for this Region. For more information, see Amazon EC2 instance
    /// type quotas (https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html).
    /// </summary>
    [JsonPropertyName("minCount")]
    public long? MinCount { get; set; }

    /// <summary>Specifies whether detailed monitoring is enabled for the instance.</summary>
    [JsonPropertyName("monitoring")]
    public V1alpha1InstanceSpecMonitoring? Monitoring { get; set; }

    /// <summary>The network interfaces to associate with the instance.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1alpha1InstanceSpecNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary>The placement for the instance.</summary>
    [JsonPropertyName("placement")]
    public V1alpha1InstanceSpecPlacement? Placement { get; set; }

    /// <summary>
    /// The options for the instance hostname. The default values are inherited from
    /// the subnet. Applies only if creating a network interface, not attaching an
    /// existing one.
    /// </summary>
    [JsonPropertyName("privateDNSNameOptions")]
    public V1alpha1InstanceSpecPrivateDNSNameOptions? PrivateDNSNameOptions { get; set; }

    /// <summary>
    /// The primary IPv4 address. You must specify a value from the IPv4 address
    /// range of the subnet.
    /// 
    /// Only one private IP address can be designated as primary. You can&apos;t specify
    /// this option if you&apos;ve specified the option to designate a private IP address
    /// as the primary IP address in a network interface specification. You cannot
    /// specify this option if you&apos;re launching more than one instance in the request.
    /// 
    /// You cannot specify this option and the network interfaces option in the same
    /// request.
    /// </summary>
    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    /// <summary>
    /// The ID of the RAM disk to select. Some kernels require additional drivers
    /// at launch. Check the kernel requirements for information about whether you
    /// need to specify a RAM disk. To find kernel requirements, go to the Amazon
    /// Web Services Resource Center and search for the kernel ID.
    /// 
    /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more
    /// information, see PV-GRUB (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("ramDiskID")]
    public string? RamDiskID { get; set; }

    /// <summary>
    /// The IDs of the security groups.
    /// 
    /// If you specify a network interface, you must specify any security groups
    /// as part of the network interface instead of using this parameter.
    /// </summary>
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    /// <summary>
    /// [Default VPC] The names of the security groups.
    /// 
    /// If you specify a network interface, you must specify any security groups
    /// as part of the network interface instead of using this parameter.
    /// 
    /// Default: Amazon EC2 uses the default security group.
    /// </summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("sourceDestCheckEnabled")]
    public bool? SourceDestCheckEnabled { get; set; }

    /// <summary>
    /// The ID of the subnet to launch the instance into.
    /// 
    /// If you specify a network interface, you must specify any subnets as part
    /// of the network interface instead of using this parameter.
    /// </summary>
    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("subnetRef")]
    public V1alpha1InstanceSpecSubnetRef? SubnetRef { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1InstanceSpecTags>? Tags { get; set; }

    /// <summary>
    /// The user data to make available to the instance. User data must be base64-encoded.
    /// Depending on the tool or SDK that you&apos;re using, the base64-encoding might
    /// be performed for you. For more information, see Run commands at launch using
    /// instance user data (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html).
    /// </summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusAckResourceMetadata
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
public partial class V1alpha1InstanceStatusConditions
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

/// <summary>
/// Amazon Elastic Graphics reached end of life on January 8, 2024.
/// 
/// Describes the association between an instance and an Elastic Graphics accelerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusElasticGPUAssociations
{
    [JsonPropertyName("elasticGPUAssociationID")]
    public string? ElasticGPUAssociationID { get; set; }

    [JsonPropertyName("elasticGPUAssociationState")]
    public string? ElasticGPUAssociationState { get; set; }

    [JsonPropertyName("elasticGPUAssociationTime")]
    public string? ElasticGPUAssociationTime { get; set; }

    [JsonPropertyName("elasticGPUID")]
    public string? ElasticGPUID { get; set; }
}

/// <summary>
/// Amazon Elastic Inference is no longer available.
/// 
/// Describes the association between an instance and an elastic inference accelerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusElasticInferenceAcceleratorAssociations
{
    [JsonPropertyName("elasticInferenceAcceleratorARN")]
    public string? ElasticInferenceAcceleratorARN { get; set; }

    [JsonPropertyName("elasticInferenceAcceleratorAssociationID")]
    public string? ElasticInferenceAcceleratorAssociationID { get; set; }

    [JsonPropertyName("elasticInferenceAcceleratorAssociationState")]
    public string? ElasticInferenceAcceleratorAssociationState { get; set; }

    [JsonPropertyName("elasticInferenceAcceleratorAssociationTime")]
    public DateTime? ElasticInferenceAcceleratorAssociationTime { get; set; }
}

/// <summary>Describes a license configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusLicenses
{
    [JsonPropertyName("licenseConfigurationARN")]
    public string? LicenseConfigurationARN { get; set; }
}

/// <summary>Describes a product code.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusProductCodes
{
    [JsonPropertyName("productCodeID")]
    public string? ProductCodeID { get; set; }

    [JsonPropertyName("productCodeType")]
    public string? ProductCodeType { get; set; }
}

/// <summary>The current state of the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusState
{
    [JsonPropertyName("code")]
    public long? Code { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The reason for the most recent state transition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatusStateReason
{
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>InstanceStatus defines the observed state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1InstanceStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1InstanceStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The AMI launch index, which can be used to find this instance in the launch
    /// group.
    /// </summary>
    [JsonPropertyName("amiLaunchIndex")]
    public long? AmiLaunchIndex { get; set; }

    /// <summary>The architecture of the image.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>
    /// The boot mode that was specified by the AMI. If the value is uefi-preferred,
    /// the AMI supports both UEFI and Legacy BIOS. The currentInstanceBootMode parameter
    /// is the boot mode that is used to boot the instance at launch or start.
    /// 
    /// The operating system contained in the AMI must be configured to support the
    /// specified boot mode.
    /// 
    /// For more information, see Boot modes (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("bootMode")]
    public string? BootMode { get; set; }

    /// <summary>The ID of the Capacity Reservation.</summary>
    [JsonPropertyName("capacityReservationID")]
    public string? CapacityReservationID { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Deprecated.
    /// 
    /// Amazon Elastic Graphics reached end of life on January 8, 2024.
    /// </summary>
    [JsonPropertyName("elasticGPUAssociations")]
    public IList<V1alpha1InstanceStatusElasticGPUAssociations>? ElasticGPUAssociations { get; set; }

    /// <summary>
    /// Deprecated
    /// 
    /// Amazon Elastic Inference is no longer available.
    /// </summary>
    [JsonPropertyName("elasticInferenceAcceleratorAssociations")]
    public IList<V1alpha1InstanceStatusElasticInferenceAcceleratorAssociations>? ElasticInferenceAcceleratorAssociations { get; set; }

    /// <summary>Specifies whether enhanced networking with ENA is enabled.</summary>
    [JsonPropertyName("enaSupport")]
    public bool? EnaSupport { get; set; }

    /// <summary>
    /// The hypervisor type of the instance. The value xen is used for both Xen and
    /// Nitro hypervisors.
    /// </summary>
    [JsonPropertyName("hypervisor")]
    public string? Hypervisor { get; set; }

    /// <summary>The ID of the instance.</summary>
    [JsonPropertyName("instanceID")]
    public string? InstanceID { get; set; }

    /// <summary>Indicates whether this is a Spot Instance or a Scheduled Instance.</summary>
    [JsonPropertyName("instanceLifecycle")]
    public string? InstanceLifecycle { get; set; }

    /// <summary>The IPv6 address assigned to the instance.</summary>
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>
    /// The time that the instance was last launched. To determine the time that
    /// instance was first launched, see the attachment time for the primary network
    /// interface.
    /// </summary>
    [JsonPropertyName("launchTime")]
    public DateTime? LaunchTime { get; set; }

    /// <summary>The license configurations for the instance.</summary>
    [JsonPropertyName("licenses")]
    public IList<V1alpha1InstanceStatusLicenses>? Licenses { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the Outpost.</summary>
    [JsonPropertyName("outpostARN")]
    public string? OutpostARN { get; set; }

    /// <summary>
    /// The platform. This value is windows for Windows instances; otherwise, it
    /// is empty.
    /// </summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// The platform details value for the instance. For more information, see AMI
    /// billing information fields (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/billing-info-fields.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("platformDetails")]
    public string? PlatformDetails { get; set; }

    /// <summary>
    /// [IPv4 only] The private DNS hostname name assigned to the instance. This
    /// DNS hostname can only be used inside the Amazon EC2 network. This name is
    /// not available until the instance enters the running state.
    /// 
    /// The Amazon-provided DNS server resolves Amazon-provided private DNS hostnames
    /// if you&apos;ve enabled DNS resolution and DNS hostnames in your VPC. If you are
    /// not using the Amazon-provided DNS server in your VPC, your custom domain
    /// name servers must resolve the hostname as appropriate.
    /// </summary>
    [JsonPropertyName("privateDNSName")]
    public string? PrivateDNSName { get; set; }

    /// <summary>The product codes attached to this instance, if applicable.</summary>
    [JsonPropertyName("productCodes")]
    public IList<V1alpha1InstanceStatusProductCodes>? ProductCodes { get; set; }

    /// <summary>
    /// The public DNS name assigned to the instance. This name is not available
    /// until the instance enters the running state. This name is only available
    /// if you&apos;ve enabled DNS hostnames for your VPC. The format of this name depends
    /// on the public hostname type (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hostname-types.html#public-hostnames).
    /// </summary>
    [JsonPropertyName("publicDNSName")]
    public string? PublicDNSName { get; set; }

    /// <summary>
    /// The public IPv4 address, or the Carrier IP address assigned to the instance,
    /// if applicable.
    /// 
    /// A Carrier IP address only applies to an instance launched in a subnet associated
    /// with a Wavelength Zone.
    /// </summary>
    [JsonPropertyName("publicIPAddress")]
    public string? PublicIPAddress { get; set; }

    /// <summary>The device name of the root device volume (for example, /dev/sda1).</summary>
    [JsonPropertyName("rootDeviceName")]
    public string? RootDeviceName { get; set; }

    /// <summary>
    /// The root device type used by the AMI. The AMI can use an EBS volume or an
    /// instance store volume.
    /// </summary>
    [JsonPropertyName("rootDeviceType")]
    public string? RootDeviceType { get; set; }

    /// <summary>Indicates whether source/destination checking is enabled.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>If the request is a Spot Instance request, the ID of the request.</summary>
    [JsonPropertyName("spotInstanceRequestID")]
    public string? SpotInstanceRequestID { get; set; }

    /// <summary>
    /// Specifies whether enhanced networking with the Intel 82599 Virtual Function
    /// interface is enabled.
    /// </summary>
    [JsonPropertyName("sriovNetSupport")]
    public string? SriovNetSupport { get; set; }

    /// <summary>The current state of the instance.</summary>
    [JsonPropertyName("state")]
    public V1alpha1InstanceStatusState? State { get; set; }

    /// <summary>The reason for the most recent state transition.</summary>
    [JsonPropertyName("stateReason")]
    public V1alpha1InstanceStatusStateReason? StateReason { get; set; }

    /// <summary>The reason for the most recent state transition. This might be an empty string.</summary>
    [JsonPropertyName("stateTransitionReason")]
    public string? StateTransitionReason { get; set; }

    /// <summary>
    /// If the instance is configured for NitroTPM support, the value is v2.0. For
    /// more information, see NitroTPM (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("tpmSupport")]
    public string? TpmSupport { get; set; }

    /// <summary>
    /// The usage operation value for the instance. For more information, see AMI
    /// billing information fields (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/billing-info-fields.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("usageOperation")]
    public string? UsageOperation { get; set; }

    /// <summary>The time that the usage operation was last updated.</summary>
    [JsonPropertyName("usageOperationUpdateTime")]
    public DateTime? UsageOperationUpdateTime { get; set; }

    /// <summary>The virtualization type of the instance.</summary>
    [JsonPropertyName("virtualizationType")]
    public string? VirtualizationType { get; set; }

    /// <summary>The ID of the VPC in which the instance is running.</summary>
    [JsonPropertyName("vpcID")]
    public string? VpcID { get; set; }
}

/// <summary>Instance is the Schema for the Instances API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1InstanceSpec?>, IStatus<V1alpha1InstanceStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// InstanceSpec defines the desired state of Instance.
    /// 
    /// Describes an instance.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1InstanceSpec? Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance</summary>
    [JsonPropertyName("status")]
    public V1alpha1InstanceStatus? Status { get; set; }
}