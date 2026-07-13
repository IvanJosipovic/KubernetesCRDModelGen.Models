#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.upbound.io;
/// <summary>Instance is the Schema for the Instances API. Provides an EC2 instance resource. This allows instances to be created, updated, and deleted. Instances also support provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Instance>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Instance objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Instance> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecDeletionPolicyEnum>))]
public enum V1beta2InstanceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary>Describes an instance&apos;s Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance&apos;s Capacity Reservation preferences. Can be &quot;open&quot; or &quot;none&quot;. (Default: &quot;open&quot;).</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2InstanceSpecForProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Indicates whether to enable the instance for nested virtualization. Nested virtualization is supported on 8th generation Intel-based instance types (C8i, M8i, R8i, and their flex variants) only. When nested virtualization is enabled, Virtual Secure Mode (VSM) is automatically disabled for the instance. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderCreditSpecification
{
    /// <summary>Credit option for CPU usage. Valid values include standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelector
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
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Enables EBS encryption on the volume. Defaults to false. Cannot be used with snapshot_id. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2InstanceSpecForProviderEbsBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Map of tags to assign to the device. Note: Tags specified here are applied after instance creation via a separate API call. This means they cannot be used with IAM policies that require tags during resource creation (e.g., ABAC policies with ec2:CreateAction conditions or SCPs requiring volume tags). For ABAC compliance, use volume_tags instead, which applies uniform tags to all volumes during instance creation.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to gp2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEnclaveOptions
{
    /// <summary>Whether Nitro Enclaves will be enabled on the instance. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Suppresses the specified device included in the AMI&apos;s block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The behavior when a Spot Instance is interrupted. Valid values include hibernate, stop, terminate . The default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price that you&apos;re willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Valid values include one-time, persistent. Persistent Spot Instance requests are only supported when the instance interruption behavior is either hibernate or stop. The default is one-time.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). Supported only for persistent requests.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderInstanceMarketOptions
{
    /// <summary>Type of market for the instance. Valid values are spot and capacity-block. Defaults to spot. Required if spot_options is specified.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta2InstanceSpecForProviderInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be a specific version number, $Latest or $Default. The default value is $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderMaintenanceOptions
{
    /// <summary>Automatic recovery behavior of the Instance. Can be &quot;default&quot; or &quot;disabled&quot;. See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Valid values include enabled or disabled. Defaults to enabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Whether the IPv6 endpoint for the instance metadata service is enabled. Defaults to disabled.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>Desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Valid values are integer from 1 to 64. Defaults to 1.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Valid values include optional or required.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Valid values include enabled or disabled. Defaults to disabled.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelector
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
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderNetworkInterface
{
    /// <summary>Whether or not to delete the network interface on instance termination. Defaults to false. Currently, the only valid value is false, as this is only supported when creating new network interfaces when launching an instance.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Integer index of the network interface attachment. Limited by instance type.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Integer index of the network card. Limited by instance type. The default index is 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2InstanceSpecForProviderNetworkInterfaceNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelector
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
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The primary network interface. See Primary Network Interface below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPrimaryNetworkInterface
{
    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }
}

/// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>Type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelector
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
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether to enable volume encryption. Defaults to false. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2InstanceSpecForProviderRootBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Map of tags to assign to the device. Note: Tags specified here are applied after instance creation via a separate API call. This means they cannot be used with IAM policies that require tags during resource creation (e.g., ABAC policies with ec2:CreateAction conditions or SCPs requiring volume tags). For ABAC compliance, use volume_tags instead, which applies uniform tags to all volumes during instance creation.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to the volume type that the AMI uses.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderSecondaryNetworkInterface
{
    /// <summary>Whether the network interface should be destroyed when the instance is terminated. Defaults to true. Forces replacement.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device index for the network interface attachment. Defaults to 0. Forces replacement.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Type of network interface. Currently only secondary is supported. Defaults to secondary. Forces replacement.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Network card index for the interface. Each network card can have one secondary interface. Forces replacement.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>Number of private IP addresses to assign to the network interface. Defaults to 1. Forces replacement.</summary>
    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>ID of the secondary subnet in which to create the network interface. Forces replacement.</summary>
    [JsonPropertyName("secondarySubnetId")]
    public string? SecondarySubnetId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderSubnetIdSelector
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
    public V1beta2InstanceSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelector
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
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecForProvider
{
    /// <summary>AMI to use for the instance. Required unless launch_template is specified and the Launch Template specifes an AMI. If an AMI is specified in the Launch Template, setting ami will override the AMI specified in the Launch Template.</summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary>Whether to associate a public IP address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>AZ to start the instance in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Describes an instance&apos;s Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2InstanceSpecForProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public V1beta2InstanceSpecForProviderCpuOptions? CpuOptions { get; set; }

    /// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
    [JsonPropertyName("creditSpecification")]
    public V1beta2InstanceSpecForProviderCreditSpecification? CreditSpecification { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection.</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>One or more configuration blocks with additional EBS block devices to attach to the instance. Block device configurations only apply on resource creation. See Block Devices below for details on attributes and drift detection. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2InstanceSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized. Note that if this is not set on an instance type that is optimized by default then this will show as disabled but if the instance type is optimized by default then there is no need to set this and there is no effect to disabling it. See the EBS Optimized section of the AWS User Guide for more information.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Whether to assign a primary IPv6 Global Unicast Address (GUA) to the instance when launched in a dual-stack or IPv6-only subnet. A primary IPv6 address ensures a consistent IPv6 address for the instance and is automatically assigned by AWS to the ENI. Once enabled, the first IPv6 GUA becomes the primary IPv6 address and cannot be disabled. The primary IPv6 address remains until the instance is terminated or the ENI is detached. Disabling enable_primary_ipv6 after it has been enabled forces recreation of the instance.</summary>
    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public V1beta2InstanceSpecForProviderEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>One or more configuration blocks to customize Ephemeral (also known as &quot;Instance Store&quot;) volumes on the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2InstanceSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Destroys instance even if disable_api_termination or disable_api_stop is set to true. Defaults to false. If setting this field in the same operation that would require replacing the instance or destroying the instance, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>If true, wait for password data to become available and retrieve it. Useful for getting the administrator password for instances running Microsoft Windows. The password data is exported to the password_data attribute. See GetPasswordData for more information.</summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary>If true, the launched EC2 instance will support hibernation.</summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>ID of a dedicated host that the instance will be assigned to. Use when an instance is to be launched on a specific dedicated host.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>ARN of the host resource group in which to launch the instances. If you specify an ARN, omit the tenancy parameter or set it to host.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>IAM Instance Profile to launch the instance with. Specified as the name of the Instance Profile. Ensure your credentials have the correct permission to assign the instance profile according to the EC2 documentation, notably iam:PassRole.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Shutdown behavior for the instance. Amazon defaults this to stop for EBS-backed instances and terminate for instance-store instances. Cannot be set on instance-store instances. See Shutdown Behavior for more information.</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1beta2InstanceSpecForProviderInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>Instance type to use for the instance. Required unless launch_template is specified and the Launch Template specifies an instance type. If an instance type is specified in the Launch Template, setting instance_type will override the instance type specified in the Launch Template. Updates to this field will trigger a stop/start of the EC2 instance.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of IPv6 addresses to associate with the primary network interface. Amazon EC2 chooses the IPv6 addresses from the range of your subnet.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>Specify one or more IPv6 addresses from the range of the subnet to associate with the primary network interface</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Key name of the Key Pair to use for the instance; which can be managed using the .</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta2InstanceSpecForProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1beta2InstanceSpecForProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public V1beta2InstanceSpecForProviderMetadataOptions? MetadataOptions { get; set; }

    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled. (Available since v0.6.0)</summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2InstanceSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>Placement Group to start the instance in. Conflicts with placement_group_id.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Placement Group ID to start the instance in. Conflicts with placement_group.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    /// <summary>Number of the partition the instance is in. Valid only if the  strategy argument is set to &quot;partition&quot;.</summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>The primary network interface. See Primary Network Interface below.</summary>
    [JsonPropertyName("primaryNetworkInterface")]
    public V1beta2InstanceSpecForProviderPrimaryNetworkInterface? PrimaryNetworkInterface { get; set; }

    /// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2InstanceSpecForProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>Private IP address to associate with the instance in a VPC.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public V1beta2InstanceSpecForProviderRootBlockDevice? RootBlockDevice { get; set; }

    /// <summary>One or more secondary network interfaces to attach to the instance at launch time. See Secondary Network Interface below for more details.</summary>
    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta2InstanceSpecForProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

    /// <summary>List of secondary private IPv4 addresses to assign to the instance&apos;s primary network interface (eth0) in a VPC. Can only be assigned to the primary network interface (eth0) attached at instance creation, not a pre-existing network interface i.e., referenced in a network_interface block. Refer to the Elastic network interfaces documentation to see the maximum number of private IP addresses allowed per instance type.</summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>VPC Subnet ID to launch in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2InstanceSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2InstanceSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of dedicated runs on single-tenant hardware. The host tenancy is not supported for the import-instance command. Valid values are default, dedicated, and host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>User data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate of the EC2 instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate of the EC2 instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>When used in combination with user_data or user_data_base64 will trigger a destroy and recreate of the EC2 instance when set to true. Defaults to false if not set.</summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>Map of tags to assign, at instance-creation time, to root and EBS volumes.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2InstanceSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2InstanceSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs to associate with.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary>Describes an instance&apos;s Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance&apos;s Capacity Reservation preferences. Can be &quot;open&quot; or &quot;none&quot;. (Default: &quot;open&quot;).</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2InstanceSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Indicates whether to enable the instance for nested virtualization. Nested virtualization is supported on 8th generation Intel-based instance types (C8i, M8i, R8i, and their flex variants) only. When nested virtualization is enabled, Virtual Secure Mode (VSM) is automatically disabled for the instance. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderCreditSpecification
{
    /// <summary>Credit option for CPU usage. Valid values include standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelector
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
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Enables EBS encryption on the volume. Defaults to false. Cannot be used with snapshot_id. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2InstanceSpecInitProviderEbsBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Map of tags to assign to the device. Note: Tags specified here are applied after instance creation via a separate API call. This means they cannot be used with IAM policies that require tags during resource creation (e.g., ABAC policies with ec2:CreateAction conditions or SCPs requiring volume tags). For ABAC compliance, use volume_tags instead, which applies uniform tags to all volumes during instance creation.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to gp2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEnclaveOptions
{
    /// <summary>Whether Nitro Enclaves will be enabled on the instance. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Suppresses the specified device included in the AMI&apos;s block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The behavior when a Spot Instance is interrupted. Valid values include hibernate, stop, terminate . The default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price that you&apos;re willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Valid values include one-time, persistent. Persistent Spot Instance requests are only supported when the instance interruption behavior is either hibernate or stop. The default is one-time.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). Supported only for persistent requests.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderInstanceMarketOptions
{
    /// <summary>Type of market for the instance. Valid values are spot and capacity-block. Defaults to spot. Required if spot_options is specified.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta2InstanceSpecInitProviderInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be a specific version number, $Latest or $Default. The default value is $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderMaintenanceOptions
{
    /// <summary>Automatic recovery behavior of the Instance. Can be &quot;default&quot; or &quot;disabled&quot;. See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Valid values include enabled or disabled. Defaults to enabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Whether the IPv6 endpoint for the instance metadata service is enabled. Defaults to disabled.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>Desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Valid values are integer from 1 to 64. Defaults to 1.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Valid values include optional or required.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Valid values include enabled or disabled. Defaults to disabled.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelector
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
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderNetworkInterface
{
    /// <summary>Whether or not to delete the network interface on instance termination. Defaults to false. Currently, the only valid value is false, as this is only supported when creating new network interfaces when launching an instance.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Integer index of the network interface attachment. Limited by instance type.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Integer index of the network card. Limited by instance type. The default index is 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2InstanceSpecInitProviderNetworkInterfaceNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelector
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
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The primary network interface. See Primary Network Interface below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPrimaryNetworkInterface
{
    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterfaceNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }
}

/// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>Type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelector
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
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Whether to enable volume encryption. Defaults to false. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2InstanceSpecInitProviderRootBlockDeviceKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>Map of tags to assign to the device. Note: Tags specified here are applied after instance creation via a separate API call. This means they cannot be used with IAM policies that require tags during resource creation (e.g., ABAC policies with ec2:CreateAction conditions or SCPs requiring volume tags). For ABAC compliance, use volume_tags instead, which applies uniform tags to all volumes during instance creation.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to the volume type that the AMI uses.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderSecondaryNetworkInterface
{
    /// <summary>Whether the network interface should be destroyed when the instance is terminated. Defaults to true. Forces replacement.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device index for the network interface attachment. Defaults to 0. Forces replacement.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Type of network interface. Currently only secondary is supported. Defaults to secondary. Forces replacement.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Network card index for the interface. Each network card can have one secondary interface. Forces replacement.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>Number of private IP addresses to assign to the network interface. Defaults to 1. Forces replacement.</summary>
    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>ID of the secondary subnet in which to create the network interface. Forces replacement.</summary>
    [JsonPropertyName("secondarySubnetId")]
    public string? SecondarySubnetId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderSubnetIdSelector
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
    public V1beta2InstanceSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelector
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
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2InstanceSpecInitProvider
{
    /// <summary>AMI to use for the instance. Required unless launch_template is specified and the Launch Template specifes an AMI. If an AMI is specified in the Launch Template, setting ami will override the AMI specified in the Launch Template.</summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary>Whether to associate a public IP address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>AZ to start the instance in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Describes an instance&apos;s Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2InstanceSpecInitProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public V1beta2InstanceSpecInitProviderCpuOptions? CpuOptions { get; set; }

    /// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
    [JsonPropertyName("creditSpecification")]
    public V1beta2InstanceSpecInitProviderCreditSpecification? CreditSpecification { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection.</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>One or more configuration blocks with additional EBS block devices to attach to the instance. Block device configurations only apply on resource creation. See Block Devices below for details on attributes and drift detection. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2InstanceSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized. Note that if this is not set on an instance type that is optimized by default then this will show as disabled but if the instance type is optimized by default then there is no need to set this and there is no effect to disabling it. See the EBS Optimized section of the AWS User Guide for more information.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Whether to assign a primary IPv6 Global Unicast Address (GUA) to the instance when launched in a dual-stack or IPv6-only subnet. A primary IPv6 address ensures a consistent IPv6 address for the instance and is automatically assigned by AWS to the ENI. Once enabled, the first IPv6 GUA becomes the primary IPv6 address and cannot be disabled. The primary IPv6 address remains until the instance is terminated or the ENI is detached. Disabling enable_primary_ipv6 after it has been enabled forces recreation of the instance.</summary>
    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public V1beta2InstanceSpecInitProviderEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>One or more configuration blocks to customize Ephemeral (also known as &quot;Instance Store&quot;) volumes on the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2InstanceSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Destroys instance even if disable_api_termination or disable_api_stop is set to true. Defaults to false. If setting this field in the same operation that would require replacing the instance or destroying the instance, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>If true, wait for password data to become available and retrieve it. Useful for getting the administrator password for instances running Microsoft Windows. The password data is exported to the password_data attribute. See GetPasswordData for more information.</summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary>If true, the launched EC2 instance will support hibernation.</summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>ID of a dedicated host that the instance will be assigned to. Use when an instance is to be launched on a specific dedicated host.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>ARN of the host resource group in which to launch the instances. If you specify an ARN, omit the tenancy parameter or set it to host.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>IAM Instance Profile to launch the instance with. Specified as the name of the Instance Profile. Ensure your credentials have the correct permission to assign the instance profile according to the EC2 documentation, notably iam:PassRole.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>Shutdown behavior for the instance. Amazon defaults this to stop for EBS-backed instances and terminate for instance-store instances. Cannot be set on instance-store instances. See Shutdown Behavior for more information.</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1beta2InstanceSpecInitProviderInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>Instance type to use for the instance. Required unless launch_template is specified and the Launch Template specifies an instance type. If an instance type is specified in the Launch Template, setting instance_type will override the instance type specified in the Launch Template. Updates to this field will trigger a stop/start of the EC2 instance.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of IPv6 addresses to associate with the primary network interface. Amazon EC2 chooses the IPv6 addresses from the range of your subnet.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>Specify one or more IPv6 addresses from the range of the subnet to associate with the primary network interface</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Key name of the Key Pair to use for the instance; which can be managed using the .</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta2InstanceSpecInitProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1beta2InstanceSpecInitProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public V1beta2InstanceSpecInitProviderMetadataOptions? MetadataOptions { get; set; }

    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled. (Available since v0.6.0)</summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2InstanceSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>Placement Group to start the instance in. Conflicts with placement_group_id.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Placement Group ID to start the instance in. Conflicts with placement_group.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    /// <summary>Number of the partition the instance is in. Valid only if the  strategy argument is set to &quot;partition&quot;.</summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>The primary network interface. See Primary Network Interface below.</summary>
    [JsonPropertyName("primaryNetworkInterface")]
    public V1beta2InstanceSpecInitProviderPrimaryNetworkInterface? PrimaryNetworkInterface { get; set; }

    /// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2InstanceSpecInitProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>Private IP address to associate with the instance in a VPC.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public V1beta2InstanceSpecInitProviderRootBlockDevice? RootBlockDevice { get; set; }

    /// <summary>One or more secondary network interfaces to attach to the instance at launch time. See Secondary Network Interface below for more details.</summary>
    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta2InstanceSpecInitProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

    /// <summary>List of secondary private IPv4 addresses to assign to the instance&apos;s primary network interface (eth0) in a VPC. Can only be assigned to the primary network interface (eth0) attached at instance creation, not a pre-existing network interface i.e., referenced in a network_interface block. Refer to the Elastic network interfaces documentation to see the maximum number of private IP addresses allowed per instance type.</summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>VPC Subnet ID to launch in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2InstanceSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2InstanceSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of dedicated runs on single-tenant hardware. The host tenancy is not supported for the import-instance command. Valid values are default, dedicated, and host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>User data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate of the EC2 instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate of the EC2 instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>When used in combination with user_data or user_data_base64 will trigger a destroy and recreate of the EC2 instance when set to true. Defaults to false if not set.</summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>Map of tags to assign, at instance-creation time, to root and EBS volumes.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2InstanceSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2InstanceSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>List of security group IDs to associate with.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecManagementPoliciesEnum>))]
public enum V1beta2InstanceSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceSpec defines the desired state of Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceSpec
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
    public V1beta2InstanceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InstanceSpecForProvider ForProvider { get; set; }

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
    public V1beta2InstanceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InstanceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InstanceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InstanceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary>Describes an instance&apos;s Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance&apos;s Capacity Reservation preferences. Can be &quot;open&quot; or &quot;none&quot;. (Default: &quot;open&quot;).</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Information about the target Capacity Reservation. See Capacity Reservation Target below for more details.</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2InstanceStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>Sets the number of CPU cores for an instance. This option is only supported on creation of instance type that support CPU Options CPU Cores and Threads Per CPU Core Per Instance Type - specifying this option for unsupported instance types will return an error from the EC2 API.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Indicates whether to enable the instance for nested virtualization. Nested virtualization is supported on 8th generation Intel-based instance types (C8i, M8i, R8i, and their flex variants) only. When nested virtualization is enabled, Virtual Secure Mode (VSM) is automatically disabled for the instance. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    /// <summary>If set to 1, hyperthreading is disabled on the launched instance. Defaults to 2 if not set. See Optimizing CPU Options for more information.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderCreditSpecification
{
    /// <summary>Credit option for CPU usage. Valid values include standard or unlimited. T3 instances are launched as unlimited by default. T2 instances are launched as standard by default.</summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderEbsBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Enables EBS encryption on the volume. Defaults to false. Cannot be used with snapshot_id. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Map of tags to assign to the device. Note: Tags specified here are applied after instance creation via a separate API call. This means they cannot be used with IAM policies that require tags during resource creation (e.g., ABAC policies with ec2:CreateAction conditions or SCPs requiring volume tags). For ABAC compliance, use volume_tags instead, which applies uniform tags to all volumes during instance creation.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>ID of the volume. For example, the ID can be accessed like this, aws_instance.web.ebs_block_device.2.volume_id.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to gp2.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderEnclaveOptions
{
    /// <summary>Whether Nitro Enclaves will be enabled on the instance. Defaults to false.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderEphemeralBlockDevice
{
    /// <summary>Name of the block device to mount on the instance.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Suppresses the specified device included in the AMI&apos;s block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    /// <summary>Instance Store Device Name (e.g., ephemeral0).</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The behavior when a Spot Instance is interrupted. Valid values include hibernate, stop, terminate . The default is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price that you&apos;re willing to pay for a Spot Instance.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Valid values include one-time, persistent. Persistent Spot Instance requests are only supported when the instance interruption behavior is either hibernate or stop. The default is one-time.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request, in UTC format (YYYY-MM-DDTHH:MM:SSZ). Supported only for persistent requests.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderInstanceMarketOptions
{
    /// <summary>Type of market for the instance. Valid values are spot and capacity-block. Defaults to spot. Required if spot_options is specified.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>Block to configure the options for Spot Instances. See Spot Options below for details on attributes.</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta2InstanceStatusAtProviderInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderLaunchTemplate
{
    /// <summary>ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Can be a specific version number, $Latest or $Default. The default value is $Default.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMaintenanceOptions
{
    /// <summary>Automatic recovery behavior of the Instance. Can be &quot;default&quot; or &quot;disabled&quot;. See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Valid values include enabled or disabled. Defaults to enabled.</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Whether the IPv6 endpoint for the instance metadata service is enabled. Defaults to disabled.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>Desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Valid values are integer from 1 to 64. Defaults to 1.</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Valid values include optional or required.</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Valid values include enabled or disabled. Defaults to disabled.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderNetworkInterface
{
    /// <summary>Whether or not to delete the network interface on instance termination. Defaults to false. Currently, the only valid value is false, as this is only supported when creating new network interfaces when launching an instance.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Integer index of the network interface attachment. Limited by instance type.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Integer index of the network card. Limited by instance type. The default index is 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

/// <summary>The primary network interface. See Primary Network Interface below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPrimaryNetworkInterface
{
    /// <summary>(Read-Only) Whether the network interface will be deleted when the instance terminates.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

/// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>Type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

/// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderRootBlockDevice
{
    /// <summary>Whether the volume should be destroyed on instance termination. Defaults to true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device name, e.g., /dev/sdh or xvdh.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Whether to enable volume encryption. Defaults to false. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Amount of provisioned IOPS. Only valid for volume_type of io1, io2 or gp3.</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the KMS Key to use when encrypting the volume. Must be configured to perform drift detection.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Map of tags to assign to the device. Note: Tags specified here are applied after instance creation via a separate API call. This means they cannot be used with IAM policies that require tags during resource creation (e.g., ABAC policies with ec2:CreateAction conditions or SCPs requiring volume tags). For ABAC compliance, use volume_tags instead, which applies uniform tags to all volumes during instance creation.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Throughput to provision for a volume in mebibytes per second (MiB/s). This is only valid for volume_type of gp3.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>ID of the volume. For example, the ID can be accessed like this, aws_instance.web.root_block_device.0.volume_id.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    /// <summary>Size of the volume in gibibytes (GiB).</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>Type of volume. Valid values include standard, gp2, gp3, io1, io2, sc1, or st1. Defaults to the volume type that the AMI uses.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProviderSecondaryNetworkInterface
{
    /// <summary>Whether the network interface should be destroyed when the instance is terminated. Defaults to true. Forces replacement.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device index for the network interface attachment. Defaults to 0. Forces replacement.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Type of network interface. Currently only secondary is supported. Defaults to secondary. Forces replacement.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    /// <summary>Network card index for the interface. Each network card can have one secondary interface. Forces replacement.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>Number of private IP addresses to assign to the network interface. Defaults to 1. Forces replacement.</summary>
    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>List of private IP addresses to assign to the network interface. If not specified, AWS will automatically assign IP addresses based on private_ip_address_count. Forces replacement.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>ID of the instance.</summary>
    [JsonPropertyName("secondaryInterfaceId")]
    public string? SecondaryInterfaceId { get; set; }

    /// <summary>ID of the instance.</summary>
    [JsonPropertyName("secondaryNetworkId")]
    public string? SecondaryNetworkId { get; set; }

    /// <summary>ID of the secondary subnet in which to create the network interface. Forces replacement.</summary>
    [JsonPropertyName("secondarySubnetId")]
    public string? SecondarySubnetId { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusAtProvider
{
    /// <summary>AMI to use for the instance. Required unless launch_template is specified and the Launch Template specifes an AMI. If an AMI is specified in the Launch Template, setting ami will override the AMI specified in the Launch Template.</summary>
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    /// <summary>ARN of the instance.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Whether to associate a public IP address with an instance in a VPC.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>AZ to start the instance in.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>Describes an instance&apos;s Capacity Reservation targeting option. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2InstanceStatusAtProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public V1beta2InstanceStatusAtProviderCpuOptions? CpuOptions { get; set; }

    /// <summary>Configuration block for customizing the credit specification of the instance. See Credit Specification below for more details. Removing this configuration on existing instances will only stop managing it. It will not change the configuration back to the default for the instance type.</summary>
    [JsonPropertyName("creditSpecification")]
    public V1beta2InstanceStatusAtProviderCreditSpecification? CreditSpecification { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>If true, enables EC2 Instance Termination Protection.</summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>One or more configuration blocks with additional EBS block devices to attach to the instance. Block device configurations only apply on resource creation. See Block Devices below for details on attributes and drift detection. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2InstanceStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized. Note that if this is not set on an instance type that is optimized by default then this will show as disabled but if the instance type is optimized by default then there is no need to set this and there is no effect to disabling it. See the EBS Optimized section of the AWS User Guide for more information.</summary>
    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    /// <summary>Whether to assign a primary IPv6 Global Unicast Address (GUA) to the instance when launched in a dual-stack or IPv6-only subnet. A primary IPv6 address ensures a consistent IPv6 address for the instance and is automatically assigned by AWS to the ENI. Once enabled, the first IPv6 GUA becomes the primary IPv6 address and cannot be disabled. The primary IPv6 address remains until the instance is terminated or the ENI is detached. Disabling enable_primary_ipv6 after it has been enabled forces recreation of the instance.</summary>
    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public V1beta2InstanceStatusAtProviderEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>One or more configuration blocks to customize Ephemeral (also known as &quot;Instance Store&quot;) volumes on the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a set of objects.</summary>
    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2InstanceStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    /// <summary>Destroys instance even if disable_api_termination or disable_api_stop is set to true. Defaults to false. If setting this field in the same operation that would require replacing the instance or destroying the instance, this flag will not work.</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>If true, wait for password data to become available and retrieve it. Useful for getting the administrator password for instances running Microsoft Windows. The password data is exported to the password_data attribute. See GetPasswordData for more information.</summary>
    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    /// <summary>If true, the launched EC2 instance will support hibernation.</summary>
    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>ID of a dedicated host that the instance will be assigned to. Use when an instance is to be launched on a specific dedicated host.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>ARN of the host resource group in which to launch the instances. If you specify an ARN, omit the tenancy parameter or set it to host.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>IAM Instance Profile to launch the instance with. Specified as the name of the Instance Profile. Ensure your credentials have the correct permission to assign the instance profile according to the EC2 documentation, notably iam:PassRole.</summary>
    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>ID of the instance.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Shutdown behavior for the instance. Amazon defaults this to stop for EBS-backed instances and terminate for instance-store instances. Cannot be set on instance-store instances. See Shutdown Behavior for more information.</summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates whether this is a Spot Instance or a Scheduled Instance.</summary>
    [JsonPropertyName("instanceLifecycle")]
    public string? InstanceLifecycle { get; set; }

    /// <summary>Describes the market (purchasing) option for the instances. See Market Options below for details on attributes.</summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1beta2InstanceStatusAtProviderInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>State of the instance. One of: pending, running, shutting-down, terminated, stopping, stopped. See Instance Lifecycle for more information.</summary>
    [JsonPropertyName("instanceState")]
    public string? InstanceState { get; set; }

    /// <summary>Instance type to use for the instance. Required unless launch_template is specified and the Launch Template specifies an instance type. If an instance type is specified in the Launch Template, setting instance_type will override the instance type specified in the Launch Template. Updates to this field will trigger a stop/start of the EC2 instance.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Number of IPv6 addresses to associate with the primary network interface. Amazon EC2 chooses the IPv6 addresses from the range of your subnet.</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>Specify one or more IPv6 addresses from the range of the subnet to associate with the primary network interface</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>Key name of the Key Pair to use for the instance; which can be managed using the .</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>Specifies a Launch Template to configure the instance. Parameters configured on this resource will override the corresponding parameters in the Launch Template. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplate")]
    public V1beta2InstanceStatusAtProviderLaunchTemplate? LaunchTemplate { get; set; }

    /// <summary>Maintenance and recovery options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1beta2InstanceStatusAtProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options of the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public V1beta2InstanceStatusAtProviderMetadataOptions? MetadataOptions { get; set; }

    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled. (Available since v0.6.0)</summary>
    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    /// <summary>Customize network interfaces to be attached at instance boot time. See Network Interfaces below for more details.</summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2InstanceStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>ARN of the Outpost the instance is assigned to.</summary>
    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    /// <summary>Base-64 encoded encrypted password data for the instance. Useful for getting the administrator password for instances running Microsoft Windows. This attribute is only exported if get_password_data is true. Note that this encrypted value will be stored in the state file, as with all exported attributes. See GetPasswordData for more information.</summary>
    [JsonPropertyName("passwordData")]
    public string? PasswordData { get; set; }

    /// <summary>Placement Group to start the instance in. Conflicts with placement_group_id.</summary>
    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>Placement Group ID to start the instance in. Conflicts with placement_group.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    /// <summary>Number of the partition the instance is in. Valid only if the  strategy argument is set to &quot;partition&quot;.</summary>
    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    /// <summary>The primary network interface. See Primary Network Interface below.</summary>
    [JsonPropertyName("primaryNetworkInterface")]
    public V1beta2InstanceStatusAtProviderPrimaryNetworkInterface? PrimaryNetworkInterface { get; set; }

    /// <summary>ID of the instance&apos;s primary network interface.</summary>
    [JsonPropertyName("primaryNetworkInterfaceId")]
    public string? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>Private DNS name assigned to the instance. Can only be used inside the Amazon EC2, and only available if you&apos;ve enabled DNS hostnames for your VPC.</summary>
    [JsonPropertyName("privateDns")]
    public string? PrivateDns { get; set; }

    /// <summary>Options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2InstanceStatusAtProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>Private IP address to associate with the instance in a VPC.</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>Public DNS name assigned to the instance. For EC2-VPC, this is only available if you&apos;ve enabled DNS hostnames for your VPC.</summary>
    [JsonPropertyName("publicDns")]
    public string? PublicDns { get; set; }

    /// <summary>Public IP address assigned to the instance, if applicable. NOTE: If you are using an aws_eip with your instance, you should refer to the EIP&apos;s address directly and not use public_ip as this field will change after the EIP is attached.</summary>
    [JsonPropertyName("publicIp")]
    public string? PublicIp { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block to customize details about the root block device of the instance. See Block Devices below for details. When accessing this as an attribute reference, it is a list containing one object.</summary>
    [JsonPropertyName("rootBlockDevice")]
    public V1beta2InstanceStatusAtProviderRootBlockDevice? RootBlockDevice { get; set; }

    /// <summary>One or more secondary network interfaces to attach to the instance at launch time. See Secondary Network Interface below for more details.</summary>
    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta2InstanceStatusAtProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

    /// <summary>List of secondary private IPv4 addresses to assign to the instance&apos;s primary network interface (eth0) in a VPC. Can only be assigned to the primary network interface (eth0) attached at instance creation, not a pre-existing network interface i.e., referenced in a network_interface block. Refer to the Elastic network interfaces documentation to see the maximum number of private IP addresses allowed per instance type.</summary>
    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    /// <summary>List of security group names to associate with.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Controls if traffic is routed to the instance when the destination address does not match the instance. Used for NAT or VPNs. Defaults true.</summary>
    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>If the request is a Spot Instance request, the ID of the request.</summary>
    [JsonPropertyName("spotInstanceRequestId")]
    public string? SpotInstanceRequestId { get; set; }

    /// <summary>VPC Subnet ID to launch in.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Tenancy of the instance (if the instance is running in a VPC). An instance with a tenancy of dedicated runs on single-tenant hardware. The host tenancy is not supported for the import-instance command. Valid values are default, dedicated, and host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    /// <summary>User data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see user_data_base64 instead. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate of the EC2 instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>Can be used instead of user_data to pass base64-encoded binary data directly. Use this instead of user_data whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption. Updates to this field will trigger a stop/start of the EC2 instance by default. If the user_data_replace_on_change is set then updates to this field will trigger a destroy and recreate of the EC2 instance.</summary>
    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    /// <summary>When used in combination with user_data or user_data_base64 will trigger a destroy and recreate of the EC2 instance when set to true. Defaults to false if not set.</summary>
    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>Map of tags to assign, at instance-creation time, to root and EBS volumes.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>List of security group IDs to associate with.</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatusConditions
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

/// <summary>InstanceStatus defines the observed state of Instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InstanceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Instance is the Schema for the Instances API. Provides an EC2 instance resource. This allows instances to be created, updated, and deleted. Instances also support provisioning.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Instance : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceSpec>, IStatus<V1beta2InstanceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Instance";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "instances";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Instance";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceSpec defines the desired state of Instance</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InstanceSpec Spec { get; set; }

    /// <summary>InstanceStatus defines the observed state of Instance.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceStatus? Status { get; set; }
}