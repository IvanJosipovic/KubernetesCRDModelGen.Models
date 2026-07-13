#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.aws.m.upbound.io;
/// <summary>CapacityProvider is the Schema for the CapacityProviders API. Provides an ECS cluster capacity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CapacityProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CapacityProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CapacityProviderList";
    public const string KubeGroup = "ecs.aws.m.upbound.io";
    public const string KubePluralName = "capacityproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CapacityProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CapacityProvider> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolutionEnum>))]
public enum V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolveEnum>))]
public enum V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelector
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
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderManagedScaling
{
    /// <summary>Period of time, in seconds, after a newly launched Amazon EC2 instance can contribute to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value of 300 seconds is used.</summary>
    [JsonPropertyName("instanceWarmupPeriod")]
    public double? InstanceWarmupPeriod { get; set; }

    /// <summary>Maximum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("maximumScalingStepSize")]
    public double? MaximumScalingStepSize { get; set; }

    /// <summary>Minimum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("minimumScalingStepSize")]
    public double? MinimumScalingStepSize { get; set; }

    /// <summary>Whether auto scaling is managed by ECS. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target utilization for the capacity provider. A number between 1 and 100.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }
}

/// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderAutoScalingGroupProvider
{
    /// <summary>- ARN of the associated auto scaling group.</summary>
    [JsonPropertyName("autoScalingGroupArn")]
    public string? AutoScalingGroupArn { get; set; }

    /// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnRef")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnRef? AutoScalingGroupArnRef { get; set; }

    /// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnSelector")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderAutoScalingGroupArnSelector? AutoScalingGroupArnSelector { get; set; }

    /// <summary>- Enables or disables a graceful shutdown of instances without disturbing workloads. Valid values are ENABLED and DISABLED. The default value is ENABLED when a capacity provider is created.</summary>
    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
    [JsonPropertyName("managedScaling")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    /// <summary>- Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}

/// <summary>Defines how Amazon ECS Managed Instances optimizes the infrastructure in your capacity provider. Configure it to turn on or off the infrastructure optimization in your capacity provider, and to control the idle EC2 instances optimization delay.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInfrastructureOptimization
{
    /// <summary>This parameter defines the number of seconds Amazon ECS Managed Instances waits before optimizing EC2 instances that have become idle or underutilized. A longer delay increases the likelihood of placing new tasks on idle instances, reducing startup time. A shorter delay helps reduce infrastructure costs by optimizing idle instances more quickly. Valid values are:</summary>
    [JsonPropertyName("scaleInAfter")]
    public double? ScaleInAfter { get; set; }
}

/// <summary>The minimum and maximum number of accelerators for the instance types. This is used when you need instances with specific numbers of GPUs or other accelerators.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum total accelerator memory in mebibytes (MiB). This is important for GPU workloads that require specific amounts of video memory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps). This is important for workloads with high storage I/O requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure that instance types have the appropriate memory-to-CPU ratio for your workloads.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory in mebibytes (MiB) for the instance types. Amazon ECS selects instance types that have memory within this range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial for network-intensive workloads that require high throughput.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of network interfaces for the instance types. This is useful for workloads that require multiple network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum total local storage in gigabytes (GB) for instance types with local storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects instance types that have vCPU counts within this range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The instance requirements. You can specify the instance types and instance requirements such as vCPU count, memory, network performance, and accelerator specifications. Amazon ECS automatically selects the instances that match the specified criteria. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements
{
    /// <summary>The minimum and maximum number of accelerators for the instance types. This is used when you need instances with specific numbers of GPUs or other accelerators.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>The accelerator manufacturers to include. You can specify nvidia, amd, amazon-web-services, xilinx, or habana depending on your accelerator requirements. Valid values are amazon-web-services, amd, nvidia, xilinx, habana.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>The specific accelerator names to include. For example, you can specify a100, v100, k80, or other specific accelerator models. Valid values are a100, inferentia, k520, k80, m60, radeon-pro-v520, t4, vu9p, v100, a10g, h100, t4g.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>The minimum and maximum total accelerator memory in mebibytes (MiB). This is important for GPU workloads that require specific amounts of video memory.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>The accelerator types to include. You can specify gpu for graphics processing units, fpga for field programmable gate arrays, or inference for machine learning inference accelerators. Valid values are gpu, fpga, inference.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>The instance types to include in the selection. When specified, Amazon ECS only considers these instance types, subject to the other requirements specified. Maximum of 400 instance types. You can specify instance type patterns using wildcards (e.g., m5.*).</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicates whether to include bare metal instance types. Set to included to allow bare metal instances, excluded to exclude them, or required to use only bare metal instances. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps). This is important for workloads with high storage I/O requirements.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicates whether to include burstable performance instance types (T2, T3, T3a, T4g). Set to included to allow burstable instances, excluded to exclude them, or required to use only burstable instances. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>The CPU manufacturers to include or exclude. You can specify intel, amd, or amazon-web-services to control which CPU types are used for your workloads. Valid values are intel, amd, amazon-web-services.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>The instance types to exclude from selection. Use this to prevent Amazon ECS from selecting specific instance types that may not be suitable for your workloads. Maximum of 400 instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>The instance generations to include. You can specify current to use the latest generation instances, or previous to include previous generation instances for cost optimization. Valid values are current, previous.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicates whether to include instance types with local storage. Set to included to allow local storage, excluded to exclude it, or required to use only instances with local storage. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>The local storage types to include. You can specify hdd for hard disk drives, ssd for solid state drives, or both. Valid values are hdd, ssd.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The maximum price for Spot instances as a percentage of the optimal On-Demand price. This provides more precise cost control for Spot instance selection.</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure that instance types have the appropriate memory-to-CPU ratio for your workloads.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>The minimum and maximum amount of memory in mebibytes (MiB) for the instance types. Amazon ECS selects instance types that have memory within this range.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial for network-intensive workloads that require high throughput.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>The minimum and maximum number of network interfaces for the instance types. This is useful for workloads that require multiple network interfaces.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances, as a percentage higher than an identified On-Demand price. The identified On-Demand price is the price of the lowest priced current generation C, M, or R instance type with your specified attributes. When Amazon ECS selects instance types with your attributes, it will exclude instance types whose price exceeds your specified threshold.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicates whether the instance types must support hibernation. When set to true, only instance types that support hibernation are selected.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The maximum price for Spot instances as a percentage over the lowest priced On-Demand instance. This helps control Spot instance costs while maintaining access to capacity.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>The minimum and maximum total local storage in gigabytes (GB) for instance types with local storage.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects instance types that have vCPU counts within this range.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

/// <summary>The network configuration for Amazon ECS Managed Instances. This specifies the subnets and security groups that instances use for network connectivity. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration
{
    /// <summary>The list of security group IDs to apply to Amazon ECS Managed Instances. These security groups control the network traffic allowed to and from the instances.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The list of subnet IDs where Amazon ECS can launch Amazon ECS Managed Instances. Instances are distributed across the specified subnets for high availability. All subnets must be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The storage configuration for Amazon ECS Managed Instances. This defines the root volume size and type for the instances. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration
{
    /// <summary>The size of the tasks volume in GiB. Must be at least 1.</summary>
    [JsonPropertyName("storageSizeGib")]
    public double? StorageSizeGib { get; set; }
}

/// <summary>The launch template configuration that specifies how Amazon ECS should launch Amazon EC2 instances. This includes the instance profile, network configuration, storage settings, and instance requirements for attribute-based instance type selection. For more information, see Store instance launch parameters in Amazon EC2 launch templates in the Amazon EC2 User Guide. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplate
{
    /// <summary>The purchasing option for the EC2 instances used in the capacity provider. Determines whether to use On-Demand or Spot instances. Valid values are ON_DEMAND and SPOT. Defaults to ON_DEMAND when not specified. Changing this value will trigger replacement of the capacity provider. For more information, see Amazon EC2 billing and purchasing options in the Amazon EC2 User Guide.</summary>
    [JsonPropertyName("capacityOptionType")]
    public string? CapacityOptionType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the instance profile that Amazon ECS applies to Amazon ECS Managed Instances. This instance profile must include the necessary permissions for your tasks to access AWS services and resources. For more information, see Amazon ECS instance profile for Managed Instances in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("ec2InstanceProfileArn")]
    public string? Ec2InstanceProfileArn { get; set; }

    /// <summary>The instance requirements. You can specify the instance types and instance requirements such as vCPU count, memory, network performance, and accelerator specifications. Amazon ECS automatically selects the instances that match the specified criteria. Detailed below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>CloudWatch provides two categories of monitoring: basic monitoring and detailed monitoring. By default, your managed instance is configured for basic monitoring. You can optionally enable detailed monitoring to help you more quickly identify and act on operational issues. You can enable or turn off detailed monitoring at launch or when the managed instance is running or stopped. For more information, see Detailed monitoring for Amazon ECS Managed Instances in the Amazon ECS Developer Guide. Valid values are BASIC and DETAILED.</summary>
    [JsonPropertyName("monitoring")]
    public string? Monitoring { get; set; }

    /// <summary>The network configuration for Amazon ECS Managed Instances. This specifies the subnets and security groups that instances use for network connectivity. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The storage configuration for Amazon ECS Managed Instances. This defines the root volume size and type for the instances. Detailed below.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>Configuration block for the managed instances provider. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProviderManagedInstancesProvider
{
    /// <summary>Defines how Amazon ECS Managed Instances optimizes the infrastructure in your capacity provider. Configure it to turn on or off the infrastructure optimization in your capacity provider, and to control the idle EC2 instances optimization delay.</summary>
    [JsonPropertyName("infrastructureOptimization")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimization { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the infrastructure role that Amazon ECS uses to manage instances on your behalf. This role must have permissions to launch, terminate, and manage Amazon EC2 instances, as well as access to other AWS services required for Amazon ECS Managed Instances functionality. For more information, see Amazon ECS infrastructure IAM role in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("infrastructureRoleArn")]
    public string? InfrastructureRoleArn { get; set; }

    /// <summary>The launch template configuration that specifies how Amazon ECS should launch Amazon EC2 instances. This includes the instance profile, network configuration, storage settings, and instance requirements for attribute-based instance type selection. For more information, see Store instance launch parameters in Amazon EC2 launch templates in the Amazon EC2 User Guide. Detailed below.</summary>
    [JsonPropertyName("instanceLaunchTemplate")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProviderInstanceLaunchTemplate? InstanceLaunchTemplate { get; set; }

    /// <summary>Specifies whether to propagate tags from the capacity provider to the Amazon ECS Managed Instances. When enabled, tags applied to the capacity provider are automatically applied to all instances launched by this provider. Valid values are CAPACITY_PROVIDER and NONE.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecForProvider
{
    /// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1beta1CapacityProviderSpecForProviderAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary>Name of the ECS cluster. Required when using managed_instances_provider. Must not be set when using auto_scaling_group_provider.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Configuration block for the managed instances provider. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
    [JsonPropertyName("managedInstancesProvider")]
    public V1beta1CapacityProviderSpecForProviderManagedInstancesProvider? ManagedInstancesProvider { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolutionEnum>))]
public enum V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolveEnum>))]
public enum V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelector
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
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelectorPolicy? Policy { get; set; }
}

/// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderManagedScaling
{
    /// <summary>Period of time, in seconds, after a newly launched Amazon EC2 instance can contribute to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value of 300 seconds is used.</summary>
    [JsonPropertyName("instanceWarmupPeriod")]
    public double? InstanceWarmupPeriod { get; set; }

    /// <summary>Maximum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("maximumScalingStepSize")]
    public double? MaximumScalingStepSize { get; set; }

    /// <summary>Minimum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("minimumScalingStepSize")]
    public double? MinimumScalingStepSize { get; set; }

    /// <summary>Whether auto scaling is managed by ECS. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target utilization for the capacity provider. A number between 1 and 100.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }
}

/// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProvider
{
    /// <summary>- ARN of the associated auto scaling group.</summary>
    [JsonPropertyName("autoScalingGroupArn")]
    public string? AutoScalingGroupArn { get; set; }

    /// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnRef")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnRef? AutoScalingGroupArnRef { get; set; }

    /// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoScalingGroupArn.</summary>
    [JsonPropertyName("autoScalingGroupArnSelector")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderAutoScalingGroupArnSelector? AutoScalingGroupArnSelector { get; set; }

    /// <summary>- Enables or disables a graceful shutdown of instances without disturbing workloads. Valid values are ENABLED and DISABLED. The default value is ENABLED when a capacity provider is created.</summary>
    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
    [JsonPropertyName("managedScaling")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    /// <summary>- Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}

/// <summary>Defines how Amazon ECS Managed Instances optimizes the infrastructure in your capacity provider. Configure it to turn on or off the infrastructure optimization in your capacity provider, and to control the idle EC2 instances optimization delay.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInfrastructureOptimization
{
    /// <summary>This parameter defines the number of seconds Amazon ECS Managed Instances waits before optimizing EC2 instances that have become idle or underutilized. A longer delay increases the likelihood of placing new tasks on idle instances, reducing startup time. A shorter delay helps reduce infrastructure costs by optimizing idle instances more quickly. Valid values are:</summary>
    [JsonPropertyName("scaleInAfter")]
    public double? ScaleInAfter { get; set; }
}

/// <summary>The minimum and maximum number of accelerators for the instance types. This is used when you need instances with specific numbers of GPUs or other accelerators.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum total accelerator memory in mebibytes (MiB). This is important for GPU workloads that require specific amounts of video memory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps). This is important for workloads with high storage I/O requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure that instance types have the appropriate memory-to-CPU ratio for your workloads.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory in mebibytes (MiB) for the instance types. Amazon ECS selects instance types that have memory within this range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial for network-intensive workloads that require high throughput.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of network interfaces for the instance types. This is useful for workloads that require multiple network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum total local storage in gigabytes (GB) for instance types with local storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects instance types that have vCPU counts within this range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The instance requirements. You can specify the instance types and instance requirements such as vCPU count, memory, network performance, and accelerator specifications. Amazon ECS automatically selects the instances that match the specified criteria. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements
{
    /// <summary>The minimum and maximum number of accelerators for the instance types. This is used when you need instances with specific numbers of GPUs or other accelerators.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>The accelerator manufacturers to include. You can specify nvidia, amd, amazon-web-services, xilinx, or habana depending on your accelerator requirements. Valid values are amazon-web-services, amd, nvidia, xilinx, habana.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>The specific accelerator names to include. For example, you can specify a100, v100, k80, or other specific accelerator models. Valid values are a100, inferentia, k520, k80, m60, radeon-pro-v520, t4, vu9p, v100, a10g, h100, t4g.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>The minimum and maximum total accelerator memory in mebibytes (MiB). This is important for GPU workloads that require specific amounts of video memory.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>The accelerator types to include. You can specify gpu for graphics processing units, fpga for field programmable gate arrays, or inference for machine learning inference accelerators. Valid values are gpu, fpga, inference.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>The instance types to include in the selection. When specified, Amazon ECS only considers these instance types, subject to the other requirements specified. Maximum of 400 instance types. You can specify instance type patterns using wildcards (e.g., m5.*).</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicates whether to include bare metal instance types. Set to included to allow bare metal instances, excluded to exclude them, or required to use only bare metal instances. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps). This is important for workloads with high storage I/O requirements.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicates whether to include burstable performance instance types (T2, T3, T3a, T4g). Set to included to allow burstable instances, excluded to exclude them, or required to use only burstable instances. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>The CPU manufacturers to include or exclude. You can specify intel, amd, or amazon-web-services to control which CPU types are used for your workloads. Valid values are intel, amd, amazon-web-services.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>The instance types to exclude from selection. Use this to prevent Amazon ECS from selecting specific instance types that may not be suitable for your workloads. Maximum of 400 instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>The instance generations to include. You can specify current to use the latest generation instances, or previous to include previous generation instances for cost optimization. Valid values are current, previous.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicates whether to include instance types with local storage. Set to included to allow local storage, excluded to exclude it, or required to use only instances with local storage. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>The local storage types to include. You can specify hdd for hard disk drives, ssd for solid state drives, or both. Valid values are hdd, ssd.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The maximum price for Spot instances as a percentage of the optimal On-Demand price. This provides more precise cost control for Spot instance selection.</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure that instance types have the appropriate memory-to-CPU ratio for your workloads.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>The minimum and maximum amount of memory in mebibytes (MiB) for the instance types. Amazon ECS selects instance types that have memory within this range.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial for network-intensive workloads that require high throughput.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>The minimum and maximum number of network interfaces for the instance types. This is useful for workloads that require multiple network interfaces.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances, as a percentage higher than an identified On-Demand price. The identified On-Demand price is the price of the lowest priced current generation C, M, or R instance type with your specified attributes. When Amazon ECS selects instance types with your attributes, it will exclude instance types whose price exceeds your specified threshold.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicates whether the instance types must support hibernation. When set to true, only instance types that support hibernation are selected.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The maximum price for Spot instances as a percentage over the lowest priced On-Demand instance. This helps control Spot instance costs while maintaining access to capacity.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>The minimum and maximum total local storage in gigabytes (GB) for instance types with local storage.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects instance types that have vCPU counts within this range.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

/// <summary>The network configuration for Amazon ECS Managed Instances. This specifies the subnets and security groups that instances use for network connectivity. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration
{
    /// <summary>The list of security group IDs to apply to Amazon ECS Managed Instances. These security groups control the network traffic allowed to and from the instances.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The list of subnet IDs where Amazon ECS can launch Amazon ECS Managed Instances. Instances are distributed across the specified subnets for high availability. All subnets must be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The storage configuration for Amazon ECS Managed Instances. This defines the root volume size and type for the instances. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration
{
    /// <summary>The size of the tasks volume in GiB. Must be at least 1.</summary>
    [JsonPropertyName("storageSizeGib")]
    public double? StorageSizeGib { get; set; }
}

/// <summary>The launch template configuration that specifies how Amazon ECS should launch Amazon EC2 instances. This includes the instance profile, network configuration, storage settings, and instance requirements for attribute-based instance type selection. For more information, see Store instance launch parameters in Amazon EC2 launch templates in the Amazon EC2 User Guide. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplate
{
    /// <summary>The purchasing option for the EC2 instances used in the capacity provider. Determines whether to use On-Demand or Spot instances. Valid values are ON_DEMAND and SPOT. Defaults to ON_DEMAND when not specified. Changing this value will trigger replacement of the capacity provider. For more information, see Amazon EC2 billing and purchasing options in the Amazon EC2 User Guide.</summary>
    [JsonPropertyName("capacityOptionType")]
    public string? CapacityOptionType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the instance profile that Amazon ECS applies to Amazon ECS Managed Instances. This instance profile must include the necessary permissions for your tasks to access AWS services and resources. For more information, see Amazon ECS instance profile for Managed Instances in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("ec2InstanceProfileArn")]
    public string? Ec2InstanceProfileArn { get; set; }

    /// <summary>The instance requirements. You can specify the instance types and instance requirements such as vCPU count, memory, network performance, and accelerator specifications. Amazon ECS automatically selects the instances that match the specified criteria. Detailed below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>CloudWatch provides two categories of monitoring: basic monitoring and detailed monitoring. By default, your managed instance is configured for basic monitoring. You can optionally enable detailed monitoring to help you more quickly identify and act on operational issues. You can enable or turn off detailed monitoring at launch or when the managed instance is running or stopped. For more information, see Detailed monitoring for Amazon ECS Managed Instances in the Amazon ECS Developer Guide. Valid values are BASIC and DETAILED.</summary>
    [JsonPropertyName("monitoring")]
    public string? Monitoring { get; set; }

    /// <summary>The network configuration for Amazon ECS Managed Instances. This specifies the subnets and security groups that instances use for network connectivity. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The storage configuration for Amazon ECS Managed Instances. This defines the root volume size and type for the instances. Detailed below.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>Configuration block for the managed instances provider. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpecInitProviderManagedInstancesProvider
{
    /// <summary>Defines how Amazon ECS Managed Instances optimizes the infrastructure in your capacity provider. Configure it to turn on or off the infrastructure optimization in your capacity provider, and to control the idle EC2 instances optimization delay.</summary>
    [JsonPropertyName("infrastructureOptimization")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimization { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the infrastructure role that Amazon ECS uses to manage instances on your behalf. This role must have permissions to launch, terminate, and manage Amazon EC2 instances, as well as access to other AWS services required for Amazon ECS Managed Instances functionality. For more information, see Amazon ECS infrastructure IAM role in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("infrastructureRoleArn")]
    public string? InfrastructureRoleArn { get; set; }

    /// <summary>The launch template configuration that specifies how Amazon ECS should launch Amazon EC2 instances. This includes the instance profile, network configuration, storage settings, and instance requirements for attribute-based instance type selection. For more information, see Store instance launch parameters in Amazon EC2 launch templates in the Amazon EC2 User Guide. Detailed below.</summary>
    [JsonPropertyName("instanceLaunchTemplate")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProviderInstanceLaunchTemplate? InstanceLaunchTemplate { get; set; }

    /// <summary>Specifies whether to propagate tags from the capacity provider to the Amazon ECS Managed Instances. When enabled, tags applied to the capacity provider are automatically applied to all instances launched by this provider. Valid values are CAPACITY_PROVIDER and NONE.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }
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
public partial class V1beta1CapacityProviderSpecInitProvider
{
    /// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1beta1CapacityProviderSpecInitProviderAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary>Name of the ECS cluster. Required when using managed_instances_provider. Must not be set when using auto_scaling_group_provider.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Configuration block for the managed instances provider. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
    [JsonPropertyName("managedInstancesProvider")]
    public V1beta1CapacityProviderSpecInitProviderManagedInstancesProvider? ManagedInstancesProvider { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CapacityProviderSpecManagementPoliciesEnum>))]
public enum V1beta1CapacityProviderSpecManagementPoliciesEnum
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
public partial class V1beta1CapacityProviderSpecProviderConfigRef
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
public partial class V1beta1CapacityProviderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>CapacityProviderSpec defines the desired state of CapacityProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1CapacityProviderSpecForProvider ForProvider { get; set; }

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
    public V1beta1CapacityProviderSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1CapacityProviderSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CapacityProviderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CapacityProviderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProviderManagedScaling
{
    /// <summary>Period of time, in seconds, after a newly launched Amazon EC2 instance can contribute to CloudWatch metrics for Auto Scaling group. If this parameter is omitted, the default value of 300 seconds is used.</summary>
    [JsonPropertyName("instanceWarmupPeriod")]
    public double? InstanceWarmupPeriod { get; set; }

    /// <summary>Maximum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("maximumScalingStepSize")]
    public double? MaximumScalingStepSize { get; set; }

    /// <summary>Minimum step adjustment size. A number between 1 and 10,000.</summary>
    [JsonPropertyName("minimumScalingStepSize")]
    public double? MinimumScalingStepSize { get; set; }

    /// <summary>Whether auto scaling is managed by ECS. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Target utilization for the capacity provider. A number between 1 and 100.</summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }
}

/// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProvider
{
    /// <summary>- ARN of the associated auto scaling group.</summary>
    [JsonPropertyName("autoScalingGroupArn")]
    public string? AutoScalingGroupArn { get; set; }

    /// <summary>- Enables or disables a graceful shutdown of instances without disturbing workloads. Valid values are ENABLED and DISABLED. The default value is ENABLED when a capacity provider is created.</summary>
    [JsonPropertyName("managedDraining")]
    public string? ManagedDraining { get; set; }

    /// <summary>- Configuration block defining the parameters of the auto scaling. Detailed below.</summary>
    [JsonPropertyName("managedScaling")]
    public V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProviderManagedScaling? ManagedScaling { get; set; }

    /// <summary>- Enables or disables container-aware termination of instances in the auto scaling group when scale-in happens. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("managedTerminationProtection")]
    public string? ManagedTerminationProtection { get; set; }
}

/// <summary>Defines how Amazon ECS Managed Instances optimizes the infrastructure in your capacity provider. Configure it to turn on or off the infrastructure optimization in your capacity provider, and to control the idle EC2 instances optimization delay.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInfrastructureOptimization
{
    /// <summary>This parameter defines the number of seconds Amazon ECS Managed Instances waits before optimizing EC2 instances that have become idle or underutilized. A longer delay increases the likelihood of placing new tasks on idle instances, reducing startup time. A shorter delay helps reduce infrastructure costs by optimizing idle instances more quickly. Valid values are:</summary>
    [JsonPropertyName("scaleInAfter")]
    public double? ScaleInAfter { get; set; }
}

/// <summary>The minimum and maximum number of accelerators for the instance types. This is used when you need instances with specific numbers of GPUs or other accelerators.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum total accelerator memory in mebibytes (MiB). This is important for GPU workloads that require specific amounts of video memory.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps). This is important for workloads with high storage I/O requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure that instance types have the appropriate memory-to-CPU ratio for your workloads.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum amount of memory in mebibytes (MiB) for the instance types. Amazon ECS selects instance types that have memory within this range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial for network-intensive workloads that require high throughput.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of network interfaces for the instance types. This is useful for workloads that require multiple network interfaces.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum total local storage in gigabytes (GB) for instance types with local storage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects instance types that have vCPU counts within this range.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount
{
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The instance requirements. You can specify the instance types and instance requirements such as vCPU count, memory, network performance, and accelerator specifications. Amazon ECS automatically selects the instances that match the specified criteria. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements
{
    /// <summary>The minimum and maximum number of accelerators for the instance types. This is used when you need instances with specific numbers of GPUs or other accelerators.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>The accelerator manufacturers to include. You can specify nvidia, amd, amazon-web-services, xilinx, or habana depending on your accelerator requirements. Valid values are amazon-web-services, amd, nvidia, xilinx, habana.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>The specific accelerator names to include. For example, you can specify a100, v100, k80, or other specific accelerator models. Valid values are a100, inferentia, k520, k80, m60, radeon-pro-v520, t4, vu9p, v100, a10g, h100, t4g.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>The minimum and maximum total accelerator memory in mebibytes (MiB). This is important for GPU workloads that require specific amounts of video memory.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>The accelerator types to include. You can specify gpu for graphics processing units, fpga for field programmable gate arrays, or inference for machine learning inference accelerators. Valid values are gpu, fpga, inference.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>The instance types to include in the selection. When specified, Amazon ECS only considers these instance types, subject to the other requirements specified. Maximum of 400 instance types. You can specify instance type patterns using wildcards (e.g., m5.*).</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicates whether to include bare metal instance types. Set to included to allow bare metal instances, excluded to exclude them, or required to use only bare metal instances. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>The minimum and maximum baseline Amazon EBS bandwidth in megabits per second (Mbps). This is important for workloads with high storage I/O requirements.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicates whether to include burstable performance instance types (T2, T3, T3a, T4g). Set to included to allow burstable instances, excluded to exclude them, or required to use only burstable instances. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>The CPU manufacturers to include or exclude. You can specify intel, amd, or amazon-web-services to control which CPU types are used for your workloads. Valid values are intel, amd, amazon-web-services.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>The instance types to exclude from selection. Use this to prevent Amazon ECS from selecting specific instance types that may not be suitable for your workloads. Maximum of 400 instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>The instance generations to include. You can specify current to use the latest generation instances, or previous to include previous generation instances for cost optimization. Valid values are current, previous.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicates whether to include instance types with local storage. Set to included to allow local storage, excluded to exclude it, or required to use only instances with local storage. Valid values are included, excluded, required.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>The local storage types to include. You can specify hdd for hard disk drives, ssd for solid state drives, or both. Valid values are hdd, ssd.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The maximum price for Spot instances as a percentage of the optimal On-Demand price. This provides more precise cost control for Spot instance selection.</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>The minimum and maximum amount of memory per vCPU in gibibytes (GiB). This helps ensure that instance types have the appropriate memory-to-CPU ratio for your workloads.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>The minimum and maximum amount of memory in mebibytes (MiB) for the instance types. Amazon ECS selects instance types that have memory within this range.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>The minimum and maximum network bandwidth in gigabits per second (Gbps). This is crucial for network-intensive workloads that require high throughput.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>The minimum and maximum number of network interfaces for the instance types. This is useful for workloads that require multiple network interfaces.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances, as a percentage higher than an identified On-Demand price. The identified On-Demand price is the price of the lowest priced current generation C, M, or R instance type with your specified attributes. When Amazon ECS selects instance types with your attributes, it will exclude instance types whose price exceeds your specified threshold.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicates whether the instance types must support hibernation. When set to true, only instance types that support hibernation are selected.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The maximum price for Spot instances as a percentage over the lowest priced On-Demand instance. This helps control Spot instance costs while maintaining access to capacity.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>The minimum and maximum total local storage in gigabytes (GB) for instance types with local storage.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>The minimum and maximum number of vCPUs for the instance types. Amazon ECS selects instance types that have vCPU counts within this range.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

/// <summary>The network configuration for Amazon ECS Managed Instances. This specifies the subnets and security groups that instances use for network connectivity. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration
{
    /// <summary>The list of security group IDs to apply to Amazon ECS Managed Instances. These security groups control the network traffic allowed to and from the instances.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The list of subnet IDs where Amazon ECS can launch Amazon ECS Managed Instances. Instances are distributed across the specified subnets for high availability. All subnets must be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>The storage configuration for Amazon ECS Managed Instances. This defines the root volume size and type for the instances. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration
{
    /// <summary>The size of the tasks volume in GiB. Must be at least 1.</summary>
    [JsonPropertyName("storageSizeGib")]
    public double? StorageSizeGib { get; set; }
}

/// <summary>The launch template configuration that specifies how Amazon ECS should launch Amazon EC2 instances. This includes the instance profile, network configuration, storage settings, and instance requirements for attribute-based instance type selection. For more information, see Store instance launch parameters in Amazon EC2 launch templates in the Amazon EC2 User Guide. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplate
{
    /// <summary>The purchasing option for the EC2 instances used in the capacity provider. Determines whether to use On-Demand or Spot instances. Valid values are ON_DEMAND and SPOT. Defaults to ON_DEMAND when not specified. Changing this value will trigger replacement of the capacity provider. For more information, see Amazon EC2 billing and purchasing options in the Amazon EC2 User Guide.</summary>
    [JsonPropertyName("capacityOptionType")]
    public string? CapacityOptionType { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the instance profile that Amazon ECS applies to Amazon ECS Managed Instances. This instance profile must include the necessary permissions for your tasks to access AWS services and resources. For more information, see Amazon ECS instance profile for Managed Instances in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("ec2InstanceProfileArn")]
    public string? Ec2InstanceProfileArn { get; set; }

    /// <summary>The instance requirements. You can specify the instance types and instance requirements such as vCPU count, memory, network performance, and accelerator specifications. Amazon ECS automatically selects the instances that match the specified criteria. Detailed below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>CloudWatch provides two categories of monitoring: basic monitoring and detailed monitoring. By default, your managed instance is configured for basic monitoring. You can optionally enable detailed monitoring to help you more quickly identify and act on operational issues. You can enable or turn off detailed monitoring at launch or when the managed instance is running or stopped. For more information, see Detailed monitoring for Amazon ECS Managed Instances in the Amazon ECS Developer Guide. Valid values are BASIC and DETAILED.</summary>
    [JsonPropertyName("monitoring")]
    public string? Monitoring { get; set; }

    /// <summary>The network configuration for Amazon ECS Managed Instances. This specifies the subnets and security groups that instances use for network connectivity. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>The storage configuration for Amazon ECS Managed Instances. This defines the root volume size and type for the instances. Detailed below.</summary>
    [JsonPropertyName("storageConfiguration")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplateStorageConfiguration? StorageConfiguration { get; set; }
}

/// <summary>Configuration block for the managed instances provider. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProviderManagedInstancesProvider
{
    /// <summary>Defines how Amazon ECS Managed Instances optimizes the infrastructure in your capacity provider. Configure it to turn on or off the infrastructure optimization in your capacity provider, and to control the idle EC2 instances optimization delay.</summary>
    [JsonPropertyName("infrastructureOptimization")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInfrastructureOptimization? InfrastructureOptimization { get; set; }

    /// <summary>The Amazon Resource Name (ARN) of the infrastructure role that Amazon ECS uses to manage instances on your behalf. This role must have permissions to launch, terminate, and manage Amazon EC2 instances, as well as access to other AWS services required for Amazon ECS Managed Instances functionality. For more information, see Amazon ECS infrastructure IAM role in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("infrastructureRoleArn")]
    public string? InfrastructureRoleArn { get; set; }

    /// <summary>The launch template configuration that specifies how Amazon ECS should launch Amazon EC2 instances. This includes the instance profile, network configuration, storage settings, and instance requirements for attribute-based instance type selection. For more information, see Store instance launch parameters in Amazon EC2 launch templates in the Amazon EC2 User Guide. Detailed below.</summary>
    [JsonPropertyName("instanceLaunchTemplate")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProviderInstanceLaunchTemplate? InstanceLaunchTemplate { get; set; }

    /// <summary>Specifies whether to propagate tags from the capacity provider to the Amazon ECS Managed Instances. When enabled, tags applied to the capacity provider are automatically applied to all instances launched by this provider. Valid values are CAPACITY_PROVIDER and NONE.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusAtProvider
{
    /// <summary>ARN that identifies the capacity provider.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block for the provider for the ECS auto scaling group. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
    [JsonPropertyName("autoScalingGroupProvider")]
    public V1beta1CapacityProviderStatusAtProviderAutoScalingGroupProvider? AutoScalingGroupProvider { get; set; }

    /// <summary>Name of the ECS cluster. Required when using managed_instances_provider. Must not be set when using auto_scaling_group_provider.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Configuration block for the managed instances provider. Detailed below. Exactly one of auto_scaling_group_provider or managed_instances_provider must be specified.</summary>
    [JsonPropertyName("managedInstancesProvider")]
    public V1beta1CapacityProviderStatusAtProviderManagedInstancesProvider? ManagedInstancesProvider { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatusConditions
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

/// <summary>CapacityProviderStatus defines the observed state of CapacityProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CapacityProviderStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CapacityProviderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CapacityProviderStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CapacityProvider is the Schema for the CapacityProviders API. Provides an ECS cluster capacity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CapacityProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CapacityProviderSpec>, IStatus<V1beta1CapacityProviderStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CapacityProvider";
    public const string KubeGroup = "ecs.aws.m.upbound.io";
    public const string KubePluralName = "capacityproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CapacityProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CapacityProviderSpec defines the desired state of CapacityProvider</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CapacityProviderSpec Spec { get; set; }

    /// <summary>CapacityProviderStatus defines the observed state of CapacityProvider.</summary>
    [JsonPropertyName("status")]
    public V1beta1CapacityProviderStatus? Status { get; set; }
}