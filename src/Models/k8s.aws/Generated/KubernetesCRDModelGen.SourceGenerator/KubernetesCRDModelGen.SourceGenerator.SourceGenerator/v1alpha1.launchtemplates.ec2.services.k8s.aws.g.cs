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
/// <summary>LaunchTemplate is the Schema for the LaunchTemplates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LaunchTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LaunchTemplate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LaunchTemplateList";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "launchtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LaunchTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1LaunchTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1LaunchTemplate> Items { get; set; }
}

/// <summary>The parameters for a block device for an EBS volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataBlockDeviceMappingsEbs
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public long? Iops { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("snapshotID")]
    public string? SnapshotID { get; set; }

    [JsonPropertyName("throughput")]
    public long? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public long? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Describes a block device mapping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataBlockDeviceMappings
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The parameters for a block device for an EBS volume.</summary>
    [JsonPropertyName("ebs")]
    public V1alpha1LaunchTemplateSpecDataBlockDeviceMappingsEbs? Ebs { get; set; }

    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Describes a target Capacity Reservation or Capacity Reservation group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataCapacityReservationSpecificationCapacityReservationTarget
{
    [JsonPropertyName("capacityReservationID")]
    public string? CapacityReservationID { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupARN")]
    public string? CapacityReservationResourceGroupARN { get; set; }
}

/// <summary>
/// Describes an instance&apos;s Capacity Reservation targeting option. You can specify
/// only one option at a time. Use the CapacityReservationPreference parameter
/// to configure the instance to run in On-Demand capacity or to run in any open
/// Capacity Reservation that has matching attributes (instance type, platform,
/// Availability Zone). Use the CapacityReservationTarget parameter to explicitly
/// target a specific Capacity Reservation or a Capacity Reservation group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Describes a target Capacity Reservation or Capacity Reservation group.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1alpha1LaunchTemplateSpecDataCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>
/// The CPU options for the instance. Both the core count and threads per core
/// must be specified in the request.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataCpuOptions
{
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    [JsonPropertyName("coreCount")]
    public long? CoreCount { get; set; }

    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public long? ThreadsPerCore { get; set; }
}

/// <summary>The credit option for CPU usage of a T instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>
/// Amazon Elastic Graphics reached end of life on January 8, 2024.
/// 
/// A specification for an Elastic Graphics accelerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataElasticGPUSpecifications
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Amazon Elastic Inference is no longer available.
/// 
/// Describes an elastic inference accelerator.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataElasticInferenceAccelerators
{
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
/// For more information, see What is Nitro Enclaves? (https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave.html)
/// in the Amazon Web Services Nitro Enclaves User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Indicates whether the instance is configured for hibernation. This parameter
/// is valid only if the instance meets the hibernation prerequisites (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataHibernationOptions
{
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

/// <summary>An IAM instance profile.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataIamInstanceProfile
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The options for Spot Instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceMarketOptionsSpotOptions
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

/// <summary>The market (purchasing) option for the instances.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceMarketOptions
{
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instances.</summary>
    [JsonPropertyName("spotOptions")]
    public V1alpha1LaunchTemplateSpecDataInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>
/// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web
/// Services Inferentia chips) on an instance. To exclude accelerator-enabled
/// instance types, set Max to 0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsAcceleratorCount
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>The minimum and maximum amount of total accelerator memory, in MiB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsAcceleratorTotalMemoryMiB
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum baseline bandwidth to Amazon EBS, in Mbps. For more
/// information, see Amazon EBS–optimized instances (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html)
/// in the Amazon EC2 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselineEBSBandwidthMbps
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// Specify an instance family to use as the baseline reference for CPU performance.
/// All instance types that match your specified attributes will be compared
/// against the CPU performance of the referenced instance family, regardless
/// of CPU manufacturer or architecture.
/// 
/// Currently, only one instance family can be specified in the list.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselinePerformanceFactorsCpuReferences
{
    [JsonPropertyName("instanceFamily")]
    public string? InstanceFamily { get; set; }
}

/// <summary>
/// The CPU performance to consider, using an instance family as the baseline
/// reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselinePerformanceFactorsCpu
{
    [JsonPropertyName("references")]
    public IList<V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselinePerformanceFactorsCpuReferences>? References { get; set; }
}

/// <summary>
/// The baseline performance to consider, using an instance family as a baseline
/// reference. The instance family establishes the lowest acceptable level of
/// performance. Amazon EC2 uses this baseline to guide instance type selection,
/// but there is no guarantee that the selected instance types will always exceed
/// the baseline for every application.
/// 
/// Currently, this parameter only supports CPU performance as a baseline performance
/// factor. For example, specifying c6i would use the CPU performance of the
/// c6i family as the baseline reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselinePerformanceFactors
{
    /// <summary>
    /// The CPU performance to consider, using an instance family as the baseline
    /// reference.
    /// </summary>
    [JsonPropertyName("cpu")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselinePerformanceFactorsCpu? Cpu { get; set; }
}

/// <summary>The minimum and maximum amount of memory per vCPU, in GiB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsMemoryGiBPerVCPU
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory, in MiB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsMemoryMiB
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum amount of network bandwidth, in gigabits per second
/// (Gbps).
/// 
/// Setting the minimum bandwidth does not guarantee that your instance will
/// achieve the minimum bandwidth. Amazon EC2 will identify instance types that
/// support the specified minimum bandwidth, but the actual bandwidth of your
/// instance might go below the specified minimum at times. For more information,
/// see Available instance bandwidth (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-network-bandwidth.html#available-instance-bandwidth)
/// in the Amazon EC2 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsNetworkBandwidthGbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsNetworkInterfaceCount
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>The minimum and maximum amount of total local storage, in GB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsTotalLocalStorageGB
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of vCPUs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirementsVCPUCount
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The attributes for the instance types. When you specify instance attributes,
/// Amazon EC2 will identify instance types with these attributes.
/// 
/// You must specify VCpuCount and MemoryMiB. All other attributes are optional.
/// Any unspecified optional attribute is set to its default.
/// 
/// When you specify multiple attributes, you get instance types that satisfy
/// all of the specified attributes. If you specify multiple values for an attribute,
/// you get instance types that satisfy any of the specified values.
/// 
/// To limit the list of instance types from which Amazon EC2 can identify matching
/// instance types, you can use one of the following parameters, but not both
/// in the same request:
/// 
///    * AllowedInstanceTypes - The instance types to include in the list. All
///    other instance types are ignored, even if they match your specified attributes.
/// 
///    * ExcludedInstanceTypes - The instance types to exclude from the list,
///    even if they match your specified attributes.
/// 
/// If you specify InstanceRequirements, you can&apos;t specify InstanceType.
/// 
/// Attribute-based instance type selection is only supported when using Auto
/// Scaling groups, EC2 Fleet, and Spot Fleet to launch instances. If you plan
/// to use the launch template in the launch instance wizard (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-instance-wizard.html),
/// or with the RunInstances (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html)
/// API or AWS::EC2::Instance (https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html)
/// Amazon Web Services CloudFormation resource, you can&apos;t specify InstanceRequirements.
/// 
/// For more information, see Specify attributes for instance type selection
/// for EC2 Fleet or Spot Fleet (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html)
/// and Spot placement score (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html)
/// in the Amazon EC2 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataInstanceRequirements
{
    /// <summary>
    /// The minimum and maximum number of accelerators (GPUs, FPGAs, or Amazon Web
    /// Services Inferentia chips) on an instance. To exclude accelerator-enabled
    /// instance types, set Max to 0.
    /// </summary>
    [JsonPropertyName("acceleratorCount")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>The minimum and maximum amount of total accelerator memory, in MiB.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMiB")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsAcceleratorTotalMemoryMiB? AcceleratorTotalMemoryMiB { get; set; }

    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>
    /// The minimum and maximum baseline bandwidth to Amazon EBS, in Mbps. For more
    /// information, see Amazon EBS–optimized instances (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("baselineEBSBandwidthMbps")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselineEBSBandwidthMbps? BaselineEBSBandwidthMbps { get; set; }

    /// <summary>
    /// The baseline performance to consider, using an instance family as a baseline
    /// reference. The instance family establishes the lowest acceptable level of
    /// performance. Amazon EC2 uses this baseline to guide instance type selection,
    /// but there is no guarantee that the selected instance types will always exceed
    /// the baseline for every application.
    /// 
    /// Currently, this parameter only supports CPU performance as a baseline performance
    /// factor. For example, specifying c6i would use the CPU performance of the
    /// c6i family as the baseline reference.
    /// </summary>
    [JsonPropertyName("baselinePerformanceFactors")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsBaselinePerformanceFactors? BaselinePerformanceFactors { get; set; }

    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public long? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU, in GiB.</summary>
    [JsonPropertyName("memoryGiBPerVCPU")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsMemoryGiBPerVCPU? MemoryGiBPerVCPU { get; set; }

    /// <summary>The minimum and maximum amount of memory, in MiB.</summary>
    [JsonPropertyName("memoryMiB")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsMemoryMiB? MemoryMiB { get; set; }

    /// <summary>
    /// The minimum and maximum amount of network bandwidth, in gigabits per second
    /// (Gbps).
    /// 
    /// Setting the minimum bandwidth does not guarantee that your instance will
    /// achieve the minimum bandwidth. Amazon EC2 will identify instance types that
    /// support the specified minimum bandwidth, but the actual bandwidth of your
    /// instance might go below the specified minimum at times. For more information,
    /// see Available instance bandwidth (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-network-bandwidth.html#available-instance-bandwidth)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>The minimum and maximum number of network interfaces.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public long? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public long? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>The minimum and maximum amount of total local storage, in GB.</summary>
    [JsonPropertyName("totalLocalStorageGB")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsTotalLocalStorageGB? TotalLocalStorageGB { get; set; }

    /// <summary>The minimum and maximum number of vCPUs.</summary>
    [JsonPropertyName("vCPUCount")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirementsVCPUCount? VCPUCount { get; set; }
}

/// <summary>Describes a license configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataLicenseSpecifications
{
    [JsonPropertyName("licenseConfigurationARN")]
    public string? LicenseConfigurationARN { get; set; }
}

/// <summary>The maintenance options of your instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>
/// The metadata options for the instance. For more information, see Use instance
/// metadata to manage your EC2 instance (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html)
/// in the Amazon EC2 User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataMetadataOptions
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

/// <summary>Describes the monitoring for the instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataMonitoring
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Describes the IPv4 prefix option for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataNetworkInterfacesIpv4Prefixes
{
    [JsonPropertyName("ipv4Prefix")]
    public string? Ipv4Prefix { get; set; }
}

/// <summary>Describes an IPv6 address.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataNetworkInterfacesIpv6Addresses
{
    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }
}

/// <summary>Describes the IPv6 prefix option for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataNetworkInterfacesIpv6Prefixes
{
    [JsonPropertyName("ipv6Prefix")]
    public string? Ipv6Prefix { get; set; }
}

/// <summary>Describes a secondary private IPv4 address for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataNetworkInterfacesPrivateIPAddresses
{
    [JsonPropertyName("primary")]
    public bool? Primary { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }
}

/// <summary>The parameters for a network interface.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataNetworkInterfaces
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

    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    [JsonPropertyName("ipv4PrefixCount")]
    public long? Ipv4PrefixCount { get; set; }

    [JsonPropertyName("ipv4Prefixes")]
    public IList<V1alpha1LaunchTemplateSpecDataNetworkInterfacesIpv4Prefixes>? Ipv4Prefixes { get; set; }

    [JsonPropertyName("ipv6AddressCount")]
    public long? Ipv6AddressCount { get; set; }

    [JsonPropertyName("ipv6Addresses")]
    public IList<V1alpha1LaunchTemplateSpecDataNetworkInterfacesIpv6Addresses>? Ipv6Addresses { get; set; }

    [JsonPropertyName("ipv6PrefixCount")]
    public long? Ipv6PrefixCount { get; set; }

    [JsonPropertyName("ipv6Prefixes")]
    public IList<V1alpha1LaunchTemplateSpecDataNetworkInterfacesIpv6Prefixes>? Ipv6Prefixes { get; set; }

    [JsonPropertyName("networkCardIndex")]
    public long? NetworkCardIndex { get; set; }

    [JsonPropertyName("networkInterfaceID")]
    public string? NetworkInterfaceID { get; set; }

    [JsonPropertyName("primaryIPv6")]
    public bool? PrimaryIPv6 { get; set; }

    [JsonPropertyName("privateIPAddress")]
    public string? PrivateIPAddress { get; set; }

    [JsonPropertyName("privateIPAddresses")]
    public IList<V1alpha1LaunchTemplateSpecDataNetworkInterfacesPrivateIPAddresses>? PrivateIPAddresses { get; set; }

    [JsonPropertyName("secondaryPrivateIPAddressCount")]
    public long? SecondaryPrivateIPAddressCount { get; set; }

    [JsonPropertyName("subnetID")]
    public string? SubnetID { get; set; }
}

/// <summary>Describes the placement of an instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataPlacement
{
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("groupID")]
    public string? GroupID { get; set; }

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

/// <summary>Describes the options for instance hostnames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataPrivateDNSNameOptions
{
    [JsonPropertyName("enableResourceNameDNSAAAARecord")]
    public bool? EnableResourceNameDNSAAAARecord { get; set; }

    [JsonPropertyName("enableResourceNameDNSARecord")]
    public bool? EnableResourceNameDNSARecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataTagSpecificationsTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// The tags specification for the resources that are created during instance
/// launch.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecDataTagSpecifications
{
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    [JsonPropertyName("tags")]
    public IList<V1alpha1LaunchTemplateSpecDataTagSpecificationsTags>? Tags { get; set; }
}

/// <summary>The information for the launch template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecData
{
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1alpha1LaunchTemplateSpecDataBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>
    /// Describes an instance&apos;s Capacity Reservation targeting option. You can specify
    /// only one option at a time. Use the CapacityReservationPreference parameter
    /// to configure the instance to run in On-Demand capacity or to run in any open
    /// Capacity Reservation that has matching attributes (instance type, platform,
    /// Availability Zone). Use the CapacityReservationTarget parameter to explicitly
    /// target a specific Capacity Reservation or a Capacity Reservation group.
    /// </summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1alpha1LaunchTemplateSpecDataCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>
    /// The CPU options for the instance. Both the core count and threads per core
    /// must be specified in the request.
    /// </summary>
    [JsonPropertyName("cpuOptions")]
    public V1alpha1LaunchTemplateSpecDataCpuOptions? CpuOptions { get; set; }

    /// <summary>The credit option for CPU usage of a T instance.</summary>
    [JsonPropertyName("creditSpecification")]
    public V1alpha1LaunchTemplateSpecDataCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableAPIStop")]
    public bool? DisableAPIStop { get; set; }

    [JsonPropertyName("disableAPITermination")]
    public bool? DisableAPITermination { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("elasticGPUSpecifications")]
    public IList<V1alpha1LaunchTemplateSpecDataElasticGPUSpecifications>? ElasticGPUSpecifications { get; set; }

    [JsonPropertyName("elasticInferenceAccelerators")]
    public IList<V1alpha1LaunchTemplateSpecDataElasticInferenceAccelerators>? ElasticInferenceAccelerators { get; set; }

    /// <summary>
    /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
    /// For more information, see What is Nitro Enclaves? (https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave.html)
    /// in the Amazon Web Services Nitro Enclaves User Guide.
    /// </summary>
    [JsonPropertyName("enclaveOptions")]
    public V1alpha1LaunchTemplateSpecDataEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>
    /// Indicates whether the instance is configured for hibernation. This parameter
    /// is valid only if the instance meets the hibernation prerequisites (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html).
    /// </summary>
    [JsonPropertyName("hibernationOptions")]
    public V1alpha1LaunchTemplateSpecDataHibernationOptions? HibernationOptions { get; set; }

    /// <summary>An IAM instance profile.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public V1alpha1LaunchTemplateSpecDataIamInstanceProfile? IamInstanceProfile { get; set; }

    [JsonPropertyName("imageID")]
    public string? ImageID { get; set; }

    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>The market (purchasing) option for the instances.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1alpha1LaunchTemplateSpecDataInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>
    /// The attributes for the instance types. When you specify instance attributes,
    /// Amazon EC2 will identify instance types with these attributes.
    /// 
    /// You must specify VCpuCount and MemoryMiB. All other attributes are optional.
    /// Any unspecified optional attribute is set to its default.
    /// 
    /// When you specify multiple attributes, you get instance types that satisfy
    /// all of the specified attributes. If you specify multiple values for an attribute,
    /// you get instance types that satisfy any of the specified values.
    /// 
    /// To limit the list of instance types from which Amazon EC2 can identify matching
    /// instance types, you can use one of the following parameters, but not both
    /// in the same request:
    /// 
    ///    * AllowedInstanceTypes - The instance types to include in the list. All
    ///    other instance types are ignored, even if they match your specified attributes.
    /// 
    ///    * ExcludedInstanceTypes - The instance types to exclude from the list,
    ///    even if they match your specified attributes.
    /// 
    /// If you specify InstanceRequirements, you can&apos;t specify InstanceType.
    /// 
    /// Attribute-based instance type selection is only supported when using Auto
    /// Scaling groups, EC2 Fleet, and Spot Fleet to launch instances. If you plan
    /// to use the launch template in the launch instance wizard (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-instance-wizard.html),
    /// or with the RunInstances (https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html)
    /// API or AWS::EC2::Instance (https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html)
    /// Amazon Web Services CloudFormation resource, you can&apos;t specify InstanceRequirements.
    /// 
    /// For more information, see Specify attributes for instance type selection
    /// for EC2 Fleet or Spot Fleet (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html)
    /// and Spot placement score (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("instanceRequirements")]
    public V1alpha1LaunchTemplateSpecDataInstanceRequirements? InstanceRequirements { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("kernelID")]
    public string? KernelID { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("licenseSpecifications")]
    public IList<V1alpha1LaunchTemplateSpecDataLicenseSpecifications>? LicenseSpecifications { get; set; }

    /// <summary>The maintenance options of your instance.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1alpha1LaunchTemplateSpecDataMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>
    /// The metadata options for the instance. For more information, see Use instance
    /// metadata to manage your EC2 instance (https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html)
    /// in the Amazon EC2 User Guide.
    /// </summary>
    [JsonPropertyName("metadataOptions")]
    public V1alpha1LaunchTemplateSpecDataMetadataOptions? MetadataOptions { get; set; }

    /// <summary>Describes the monitoring for the instance.</summary>
    [JsonPropertyName("monitoring")]
    public V1alpha1LaunchTemplateSpecDataMonitoring? Monitoring { get; set; }

    [JsonPropertyName("networkInterfaces")]
    public IList<V1alpha1LaunchTemplateSpecDataNetworkInterfaces>? NetworkInterfaces { get; set; }

    /// <summary>Describes the placement of an instance.</summary>
    [JsonPropertyName("placement")]
    public V1alpha1LaunchTemplateSpecDataPlacement? Placement { get; set; }

    /// <summary>Describes the options for instance hostnames.</summary>
    [JsonPropertyName("privateDNSNameOptions")]
    public V1alpha1LaunchTemplateSpecDataPrivateDNSNameOptions? PrivateDNSNameOptions { get; set; }

    [JsonPropertyName("ramDiskID")]
    public string? RamDiskID { get; set; }

    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("tagSpecifications")]
    public IList<V1alpha1LaunchTemplateSpecDataTagSpecifications>? TagSpecifications { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }
}

/// <summary>Describes a tag.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// LaunchTemplateSpec defines the desired state of LaunchTemplate.
/// 
/// Describes a launch template.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateSpec
{
    /// <summary>The information for the launch template.</summary>
    [JsonPropertyName("data")]
    public required V1alpha1LaunchTemplateSpecData Data { get; set; }

    /// <summary>The version number of the default version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public long? DefaultVersion { get; set; }

    /// <summary>
    /// A name for the launch template.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9\(\)\.\-/_]+$`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The tags. The value parameter is required, but if you don&apos;t want the tag
    /// to have a value, specify the parameter with no value, and we set the value
    /// to an empty string.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1LaunchTemplateSpecTags>? Tags { get; set; }

    /// <summary>A description for the first version of the launch template.</summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateStatusConditions
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

/// <summary>The entity that manages the launch template.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateStatusOperator
{
    [JsonPropertyName("managed")]
    public bool? Managed { get; set; }

    [JsonPropertyName("principal")]
    public string? Principal { get; set; }
}

/// <summary>LaunchTemplateStatus defines the observed state of LaunchTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LaunchTemplateStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1LaunchTemplateStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LaunchTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>The time launch template was created.</summary>
    [JsonPropertyName("createTime")]
    public DateTime? CreateTime { get; set; }

    /// <summary>The principal that created the launch template.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>The ID of the launch template.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The version number of the latest version of the launch template.</summary>
    [JsonPropertyName("latestVersion")]
    public long? LatestVersion { get; set; }

    /// <summary>The entity that manages the launch template.</summary>
    [JsonPropertyName("operator")]
    public V1alpha1LaunchTemplateStatusOperator? Operator { get; set; }
}

/// <summary>LaunchTemplate is the Schema for the LaunchTemplates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LaunchTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LaunchTemplateSpec?>, IStatus<V1alpha1LaunchTemplateStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LaunchTemplate";
    public const string KubeGroup = "ec2.services.k8s.aws";
    public const string KubePluralName = "launchtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LaunchTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// LaunchTemplateSpec defines the desired state of LaunchTemplate.
    /// 
    /// Describes a launch template.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1LaunchTemplateSpec? Spec { get; set; }

    /// <summary>LaunchTemplateStatus defines the observed state of LaunchTemplate</summary>
    [JsonPropertyName("status")]
    public V1alpha1LaunchTemplateStatus? Status { get; set; }
}