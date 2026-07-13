#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.services.k8s.aws;
/// <summary>CapacityProvider is the Schema for the CapacityProviders API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CapacityProviderList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CapacityProvider>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CapacityProviderList";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "capacityproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CapacityProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CapacityProvider> Items { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecAutoScalingGroupProviderAutoScalingGroupRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for AutoScalingGroupARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecAutoScalingGroupProviderAutoScalingGroupRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapacityProviderSpecAutoScalingGroupProviderAutoScalingGroupRefFrom? From { get; set; }
}

/// <summary>
/// The managed scaling settings for the Auto Scaling group capacity provider.
/// 
/// When managed scaling is turned on, Amazon ECS manages the scale-in and scale-out
/// actions of the Auto Scaling group. Amazon ECS manages a target tracking scaling
/// policy using an Amazon ECS managed CloudWatch metric with the specified targetCapacity
/// value as the target value for the metric. For more information, see Using
/// managed scaling (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/asg-capacity-providers.html#asg-capacity-providers-managed-scaling)
/// in the Amazon Elastic Container Service Developer Guide.
/// 
/// If managed scaling is off, the user must manage the scaling of the Auto Scaling
/// group.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecAutoScalingGroupProviderManagedScaling
{
    [JsonPropertyName("instanceWarmupPeriod")]
    public long? InstanceWarmupPeriod { get; set; }

    [JsonPropertyName("maximumScalingStepSize")]
    public long? MaximumScalingStepSize { get; set; }

    [JsonPropertyName("minimumScalingStepSize")]
    public long? MinimumScalingStepSize { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("targetCapacity")]
    public long? TargetCapacity { get; set; }
}

/// <summary>The details of the Auto Scaling group for the capacity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecAutoScalingGroupProvider
{
    [JsonPropertyName("autoScalingGroupARN")]
    public string? AutoScalingGroupARN { get; set; }

    /// <summary>Reference field for AutoScalingGroupARN</summary>
    [JsonPropertyName("autoScalingGroupRef")]
    public V1alpha1CapacityProviderSpecAutoScalingGroupProviderAutoScalingGroupRef? AutoScalingGroupRef { get; set; }

    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>
    /// The managed scaling settings for the Auto Scaling group capacity provider.
    /// 
    /// When managed scaling is turned on, Amazon ECS manages the scale-in and scale-out
    /// actions of the Auto Scaling group. Amazon ECS manages a target tracking scaling
    /// policy using an Amazon ECS managed CloudWatch metric with the specified targetCapacity
    /// value as the target value for the metric. For more information, see Using
    /// managed scaling (https://docs.aws.amazon.com/AmazonECS/latest/developerguide/asg-capacity-providers.html#asg-capacity-providers-managed-scaling)
    /// in the Amazon Elastic Container Service Developer Guide.
    /// 
    /// If managed scaling is off, the user must manage the scaling of the Auto Scaling
    /// group.
    /// </summary>
    [JsonPropertyName("managedScaling")]
    public V1alpha1CapacityProviderSpecAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecClusterRefFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecClusterRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapacityProviderSpecClusterRefFrom? From { get; set; }
}

/// <summary>
/// The auto repair configuration for an Amazon ECS Managed Instances capacity
/// provider. When enabled, Amazon ECS automatically replaces container instances
/// that are detected as unhealthy based on container instance health checks,
/// including accelerated compute device and daemon health checks.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderAutoRepairConfiguration
{
    [JsonPropertyName("actionsStatus")]
    public string? ActionsStatus { get; set; }
}

/// <summary>The configuration that controls how Amazon ECS optimizes your infrastructure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInfrastructureOptimization
{
    [JsonPropertyName("scaleInAfter")]
    public long? ScaleInAfter { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInfrastructureRoleRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for InfrastructureRoleARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInfrastructureRoleRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInfrastructureRoleRefFrom? From { get; set; }
}

/// <summary>
/// The Capacity Reservation configurations to be used when using the RESERVED
/// capacity option type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateCapacityReservations
{
    [JsonPropertyName("reservationGroupARN")]
    public string? ReservationGroupARN { get; set; }

    [JsonPropertyName("reservationPreference")]
    public string? ReservationPreference { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateEc2InstanceProfileRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Reference field for EC2InstanceProfileARN</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateEc2InstanceProfileRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateEc2InstanceProfileRefFrom? From { get; set; }
}

/// <summary>
/// The minimum and maximum number of accelerators (such as GPUs) for instance
/// type selection. This is used for workloads that require specific numbers
/// of accelerators.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum total accelerator memory in mebibytes (MiB) for instance
/// type selection. This is important for GPU workloads that require specific
/// amounts of video memory.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMiB
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum baseline Amazon EBS bandwidth in megabits per second
/// (Mbps) for instance type selection. This is important for workloads with
/// high storage I/O requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEBSBandwidthMbps
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This
/// helps ensure that instance types have the appropriate memory-to-CPU ratio
/// for your workloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGiBPerVCPU
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// The minimum and maximum amount of memory in mebibytes (MiB) for instance
/// type selection. This ensures that selected instance types have adequate memory
/// for your workloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMiB
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum network bandwidth in gigabits per second (Gbps) for
/// instance type selection. This is important for network-intensive workloads.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// The minimum and maximum number of network interfaces for instance type selection.
/// This is useful for workloads that require multiple network interfaces.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The minimum and maximum total local storage in gigabytes (GB) for instance
/// types with local storage. This is useful for workloads that require local
/// storage for temporary data or caching.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGB
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>
/// The minimum and maximum number of vCPUs for instance type selection. This
/// allows you to specify a range of vCPU counts that meet your workload requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVCPUCount
{
    [JsonPropertyName("max")]
    public long? Max { get; set; }

    [JsonPropertyName("min")]
    public long? Min { get; set; }
}

/// <summary>
/// The instance requirements for attribute-based instance type selection. Instead
/// of specifying exact instance types, you define requirements such as vCPU
/// count, memory size, network performance, and accelerator specifications.
/// Amazon ECS automatically selects Amazon EC2 instance types that match these
/// requirements, providing flexibility and helping to mitigate capacity constraints.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements
{
    /// <summary>
    /// The minimum and maximum number of accelerators (such as GPUs) for instance
    /// type selection. This is used for workloads that require specific numbers
    /// of accelerators.
    /// </summary>
    [JsonPropertyName("acceleratorCount")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>
    /// The minimum and maximum total accelerator memory in mebibytes (MiB) for instance
    /// type selection. This is important for GPU workloads that require specific
    /// amounts of video memory.
    /// </summary>
    [JsonPropertyName("acceleratorTotalMemoryMiB")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMiB? AcceleratorTotalMemoryMiB { get; set; }

    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>
    /// The minimum and maximum baseline Amazon EBS bandwidth in megabits per second
    /// (Mbps) for instance type selection. This is important for workloads with
    /// high storage I/O requirements.
    /// </summary>
    [JsonPropertyName("baselineEBSBandwidthMbps")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEBSBandwidthMbps? BaselineEBSBandwidthMbps { get; set; }

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

    /// <summary>
    /// The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This
    /// helps ensure that instance types have the appropriate memory-to-CPU ratio
    /// for your workloads.
    /// </summary>
    [JsonPropertyName("memoryGiBPerVCPU")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGiBPerVCPU? MemoryGiBPerVCPU { get; set; }

    /// <summary>
    /// The minimum and maximum amount of memory in mebibytes (MiB) for instance
    /// type selection. This ensures that selected instance types have adequate memory
    /// for your workloads.
    /// </summary>
    [JsonPropertyName("memoryMiB")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMiB? MemoryMiB { get; set; }

    /// <summary>
    /// The minimum and maximum network bandwidth in gigabits per second (Gbps) for
    /// instance type selection. This is important for network-intensive workloads.
    /// </summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>
    /// The minimum and maximum number of network interfaces for instance type selection.
    /// This is useful for workloads that require multiple network interfaces.
    /// </summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public long? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public long? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>
    /// The minimum and maximum total local storage in gigabytes (GB) for instance
    /// types with local storage. This is useful for workloads that require local
    /// storage for temporary data or caching.
    /// </summary>
    [JsonPropertyName("totalLocalStorageGB")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGB? TotalLocalStorageGB { get; set; }

    /// <summary>
    /// The minimum and maximum number of vCPUs for instance type selection. This
    /// allows you to specify a range of vCPU counts that meet your workload requirements.
    /// </summary>
    [JsonPropertyName("vCPUCount")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVCPUCount? VCPUCount { get; set; }
}

/// <summary>
/// The local storage configuration for Amazon ECS Managed Instances. This defines
/// how ECS uses and configures instance store volumes available on container
/// instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateLocalStorageConfiguration
{
    [JsonPropertyName("useLocalStorage")]
    public bool? UseLocalStorage { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSecurityGroupRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSecurityGroupRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSecurityGroupRefsFrom? From { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSubnetRefsFrom
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSubnetRefs
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSubnetRefsFrom? From { get; set; }
}

/// <summary>
/// The network configuration for Amazon ECS Managed Instances. This specifies
/// the VPC subnets and security groups that instances use for network connectivity.
/// Amazon ECS Managed Instances support multiple network modes including awsvpc
/// (instances receive ENIs for task isolation), host (instances share network
/// namespace with tasks), and none (no external network connectivity), ensuring
/// backward compatibility for migrating workloads from Fargate or Amazon EC2.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration
{
    /// <summary>Reference field for SecurityGroups</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Reference field for Subnets</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfigurationSubnetRefs>? SubnetRefs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// The storage configuration for Amazon ECS Managed Instances. This defines
/// the data volume configuration for the instances.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration
{
    [JsonPropertyName("storageSizeGiB")]
    public long? StorageSizeGiB { get; set; }
}

/// <summary>
/// The launch template configuration for Amazon ECS Managed Instances. This
/// defines how Amazon ECS launches Amazon EC2 instances, including the instance
/// profile for your tasks, network and storage configuration, capacity options,
/// and instance requirements for flexible instance type selection.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplate
{
    [JsonPropertyName("capacityOptionType")]
    public string? CapacityOptionType { get; set; }

    /// <summary>
    /// The Capacity Reservation configurations to be used when using the RESERVED
    /// capacity option type.
    /// </summary>
    [JsonPropertyName("capacityReservations")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateCapacityReservations? CapacityReservations { get; set; }

    [JsonPropertyName("ec2InstanceProfileARN")]
    public string? Ec2InstanceProfileARN { get; set; }

    /// <summary>Reference field for EC2InstanceProfileARN</summary>
    [JsonPropertyName("ec2InstanceProfileRef")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateEc2InstanceProfileRef? Ec2InstanceProfileRef { get; set; }

    [JsonPropertyName("fipsEnabled")]
    public bool? FipsEnabled { get; set; }

    [JsonPropertyName("instanceMetadataTagsPropagation")]
    public bool? InstanceMetadataTagsPropagation { get; set; }

    /// <summary>
    /// The instance requirements for attribute-based instance type selection. Instead
    /// of specifying exact instance types, you define requirements such as vCPU
    /// count, memory size, network performance, and accelerator specifications.
    /// Amazon ECS automatically selects Amazon EC2 instance types that match these
    /// requirements, providing flexibility and helping to mitigate capacity constraints.
    /// </summary>
    [JsonPropertyName("instanceRequirements")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>
    /// The local storage configuration for Amazon ECS Managed Instances. This defines
    /// how ECS uses and configures instance store volumes available on container
    /// instance.
    /// </summary>
    [JsonPropertyName("localStorageConfiguration")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateLocalStorageConfiguration? LocalStorageConfiguration { get; set; }

    [JsonPropertyName("monitoring")]
    public string? Monitoring { get; set; }

    /// <summary>
    /// The network configuration for Amazon ECS Managed Instances. This specifies
    /// the VPC subnets and security groups that instances use for network connectivity.
    /// Amazon ECS Managed Instances support multiple network modes including awsvpc
    /// (instances receive ENIs for task isolation), host (instances share network
    /// namespace with tasks), and none (no external network connectivity), ensuring
    /// backward compatibility for migrating workloads from Fargate or Amazon EC2.
    /// </summary>
    [JsonPropertyName("networkConfiguration")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>
    /// The storage configuration for Amazon ECS Managed Instances. This defines
    /// the data volume configuration for the instances.
    /// </summary>
    [JsonPropertyName("storageConfiguration")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>
/// The configuration for the Amazon ECS Managed Instances provider. This configuration
/// specifies how Amazon ECS manages Amazon EC2 instances on your behalf, including
/// the infrastructure role, instance launch template, and tag propagation settings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecManagedInstancesProvider
{
    /// <summary>
    /// The auto repair configuration for an Amazon ECS Managed Instances capacity
    /// provider. When enabled, Amazon ECS automatically replaces container instances
    /// that are detected as unhealthy based on container instance health checks,
    /// including accelerated compute device and daemon health checks.
    /// </summary>
    [JsonPropertyName("autoRepairConfiguration")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderAutoRepairConfiguration? AutoRepairConfiguration { get; set; }

    /// <summary>The configuration that controls how Amazon ECS optimizes your infrastructure.</summary>
    [JsonPropertyName("infrastructureOptimization")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimization { get; set; }

    [JsonPropertyName("infrastructureRoleARN")]
    public string? InfrastructureRoleARN { get; set; }

    /// <summary>Reference field for InfrastructureRoleARN</summary>
    [JsonPropertyName("infrastructureRoleRef")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInfrastructureRoleRef? InfrastructureRoleRef { get; set; }

    /// <summary>
    /// The launch template configuration for Amazon ECS Managed Instances. This
    /// defines how Amazon ECS launches Amazon EC2 instances, including the instance
    /// profile for your tasks, network and storage configuration, capacity options,
    /// and instance requirements for flexible instance type selection.
    /// </summary>
    [JsonPropertyName("instanceLaunchTemplate")]
    public V1alpha1CapacityProviderSpecManagedInstancesProviderInstanceLaunchTemplate? InstanceLaunchTemplate { get; set; }

    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }
}

/// <summary>
/// The metadata that you apply to a resource to help you categorize and organize
/// them. Each tag consists of a key and an optional value. You define them.
/// 
/// The following basic restrictions apply to tags:
/// 
///   - Maximum number of tags per resource - 50
/// 
///   - For each resource, each tag key must be unique, and each tag key can
///     have only one value.
/// 
///   - Maximum key length - 128 Unicode characters in UTF-8
/// 
///   - Maximum value length - 256 Unicode characters in UTF-8
/// 
///   - If your tagging schema is used across multiple services and resources,
///     remember that other services may have restrictions on allowed characters.
///     Generally allowed characters are: letters, numbers, and spaces representable
///     in UTF-8, and the following characters: + - = . _ : / @.
/// 
///   - Tag keys and values are case-sensitive.
/// 
///   - Do not use aws:, AWS:, or any upper or lowercase combination of such
///     as a prefix for either keys or values as it is reserved for Amazon Web
///     Services use. You cannot edit or delete tag keys or values with this prefix.
///     Tags with this prefix do not count against your tags per resource limit.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CapacityProviderSpec defines the desired state of CapacityProvider.
/// 
/// The details for a capacity provider.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderSpec
{
    /// <summary>The details of the Auto Scaling group for the capacity provider.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1alpha1CapacityProviderSpecAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary>
    /// The name of the cluster to associate with the capacity provider. When you
    /// create a capacity provider with Amazon ECS Managed Instances, it becomes
    /// available only within the specified cluster.
    /// </summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("clusterRef")]
    public V1alpha1CapacityProviderSpecClusterRef? ClusterRef { get; set; }

    /// <summary>
    /// The configuration for the Amazon ECS Managed Instances provider. This configuration
    /// specifies how Amazon ECS manages Amazon EC2 instances on your behalf, including
    /// the infrastructure role, instance launch template, and tag propagation settings.
    /// </summary>
    [JsonPropertyName("managedInstancesProvider")]
    public V1alpha1CapacityProviderSpecManagedInstancesProvider? ManagedInstancesProvider { get; set; }

    /// <summary>
    /// The name of the capacity provider. Up to 255 characters are allowed. They
    /// include letters (both upper and lowercase letters), numbers, underscores
    /// (_), and hyphens (-). The name can&apos;t be prefixed with &quot;aws&quot;, &quot;ecs&quot;, or &quot;fargate&quot;.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The metadata that you apply to the capacity provider to categorize and organize
    /// them more conveniently. Each tag consists of a key and an optional value.
    /// You define both of them.
    /// 
    /// The following basic restrictions apply to tags:
    /// 
    ///   - Maximum number of tags per resource - 50
    /// 
    ///   - For each resource, each tag key must be unique, and each tag key can
    ///     have only one value.
    /// 
    ///   - Maximum key length - 128 Unicode characters in UTF-8
    /// 
    ///   - Maximum value length - 256 Unicode characters in UTF-8
    /// 
    ///   - If your tagging schema is used across multiple services and resources,
    ///     remember that other services may have restrictions on allowed characters.
    ///     Generally allowed characters are: letters, numbers, and spaces representable
    ///     in UTF-8, and the following characters: + - = . _ : / @.
    /// 
    ///   - Tag keys and values are case-sensitive.
    /// 
    ///   - Do not use aws:, AWS:, or any upper or lowercase combination of such
    ///     as a prefix for either keys or values as it is reserved for Amazon Web
    ///     Services use. You cannot edit or delete tag keys or values with this prefix.
    ///     Tags with this prefix do not count against your tags per resource limit.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CapacityProviderSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderStatusAckResourceMetadata
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
public partial class V1alpha1CapacityProviderStatusConditions
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

/// <summary>CapacityProviderStatus defines the observed state of CapacityProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CapacityProviderStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CapacityProviderStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CapacityProviderStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The current status of the capacity provider. Only capacity providers in an
    /// ACTIVE state can be used in a cluster. When a capacity provider is successfully
    /// deleted, it has an INACTIVE status.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The type of capacity provider. For Amazon ECS Managed Instances, this value
    /// is MANAGED_INSTANCES, indicating that Amazon ECS manages the underlying Amazon
    /// EC2 instances on your behalf.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The update status of the capacity provider. The following are the possible
    /// states that is returned.
    /// 
    /// DELETE_IN_PROGRESS
    /// 
    /// The capacity provider is in the process of being deleted.
    /// 
    /// DELETE_COMPLETE
    /// 
    /// The capacity provider was successfully deleted and has an INACTIVE status.
    /// 
    /// DELETE_FAILED
    /// 
    /// The capacity provider can&apos;t be deleted. The update status reason provides
    /// further details about why the delete failed.
    /// </summary>
    [JsonPropertyName("updateStatus")]
    public string? UpdateStatus { get; set; }

    /// <summary>
    /// The update status reason. This provides further details about the update
    /// status for the capacity provider.
    /// </summary>
    [JsonPropertyName("updateStatusReason")]
    public string? UpdateStatusReason { get; set; }
}

/// <summary>CapacityProvider is the Schema for the CapacityProviders API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CapacityProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CapacityProviderSpec?>, IStatus<V1alpha1CapacityProviderStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CapacityProvider";
    public const string KubeGroup = "ecs.services.k8s.aws";
    public const string KubePluralName = "capacityproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CapacityProviderSpec defines the desired state of CapacityProvider.
    /// 
    /// The details for a capacity provider.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CapacityProviderSpec? Spec { get; set; }

    /// <summary>CapacityProviderStatus defines the observed state of CapacityProvider</summary>
    [JsonPropertyName("status")]
    public V1alpha1CapacityProviderStatus? Status { get; set; }
}