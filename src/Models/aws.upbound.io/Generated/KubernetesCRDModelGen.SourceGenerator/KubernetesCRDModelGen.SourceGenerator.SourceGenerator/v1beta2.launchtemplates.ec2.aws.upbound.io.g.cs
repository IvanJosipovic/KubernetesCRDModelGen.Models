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
/// <summary>LaunchTemplate is the Schema for the LaunchTemplates API. Provides an EC2 launch template resource. Can be used to create instances or auto scaling groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LaunchTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2LaunchTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LaunchTemplateList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "launchtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LaunchTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2LaunchTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2LaunchTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2LaunchTemplateSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelector
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
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure EBS volume properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbs
{
    /// <summary>
    /// Whether the volume should be destroyed on instance termination.
    /// See Preserving Amazon EBS Volumes on Instance Termination for more information.
    /// </summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>
    /// Enables EBS encryption on the volume.
    /// Cannot be used with snapshot_id.
    /// </summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>
    /// The amount of provisioned IOPS.
    /// This must be set with a volume_type of &quot;io1/io2/gp3&quot;.
    /// </summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>
    /// Identifier (key ID, key alias, key ARN, or alias ARN) of the customer managed KMS key to use for EBS encryption.
    /// encrypted must be set to true when this is set.
    /// </summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbsKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput to provision for a gp3 volume in MiB/s (specified as an integer, e.g., 500), with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The volume initialization rate in MiB/s (specified as an integer, e.g. 100), with a minimum of 100 MiB/s and maximum of 300 MiB/s.</summary>
    [JsonPropertyName("volumeInitializationRate")]
    public double? VolumeInitializationRate { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>
    /// The volume type.
    /// Can be one of standard, gp2, gp3, io1, io2, sc1 or st1.
    /// </summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderBlockDeviceMappings
{
    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configure EBS volume properties.</summary>
    [JsonPropertyName("ebs")]
    public V1beta2LaunchTemplateSpecForProviderBlockDeviceMappingsEbs? Ebs { get; set; }

    /// <summary>Suppresses the specified device included in the AMI&apos;s block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    /// <summary>
    /// The Instance Store Device
    /// Name
    /// (e.g., &quot;ephemeral0&quot;).
    /// </summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Used to target a specific Capacity Reservation:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>The ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance&apos;s Capacity Reservation preferences. Can be capacity-reservations-only, open or none. If capacity_reservation_id or capacity_reservation_resource_group_arn is specified in capacity_reservation_target block, either omit capacity_reservation_preference or set it to capacity-reservations-only.</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Used to target a specific Capacity Reservation:</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2LaunchTemplateSpecForProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>The number of CPU cores for the instance.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Indicates whether to enable the instance for nested virtualization. Nested virtualization is supported on 8th generation Intel-based instance types (C8i, M8i, R8i, and their flex variants) only. When nested virtualization is enabled, Virtual Secure Mode (VSM) is automatically disabled for the instance. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    /// <summary>
    /// The number of threads per CPU core.
    /// To disable Intel Hyper-Threading Technology for the instance, specify a value of 1.
    /// Otherwise, specify the default value of 2.
    /// </summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary>
/// Customize the credit specification of the instance. See Credit
/// Specification below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderCreditSpecification
{
    /// <summary>
    /// The credit option for CPU usage.
    /// Can be standard or unlimited.
    /// T3 instances are launched as unlimited by default.
    /// T2 instances are launched as standard by default.
    /// </summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderEnclaveOptions
{
    /// <summary>If set to true, Nitro Enclaves will be enabled on the instance.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderHibernationOptions
{
    /// <summary>If set to true, the launched EC2 instance will hibernation enabled.</summary>
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelector
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
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelector
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
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The IAM Instance Profile to launch the instance with. See Instance Profile
/// below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderIamInstanceProfile
{
    /// <summary>The Amazon Resource Name (ARN) of the instance profile. Conflicts with name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnRef? ArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileArnSelector? ArnSelector { get; set; }

    /// <summary>The name of the instance profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameRef? NameRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfileNameSelector? NameSelector { get; set; }
}

/// <summary>The options for Spot Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The required duration in minutes. This value must be a multiple of 60.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary>
    /// The behavior when a Spot Instance is interrupted. Can be hibernate,
    /// stop, or terminate. (Default: terminate).
    /// </summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price you&apos;re willing to pay for the Spot Instances.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Can be one-time, or persistent.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>
/// The market (purchasing) option for the instance. See Market Options
/// below for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceMarketOptions
{
    /// <summary>The market type. Can be spot.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instance</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta2LaunchTemplateSpecForProviderInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderLicenseSpecification
{
    /// <summary>ARN of the license configuration.</summary>
    [JsonPropertyName("licenseConfigurationArn")]
    public string? LicenseConfigurationArn { get; set; }
}

/// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderMaintenanceOptions
{
    /// <summary>Disables the automatic recovery behavior of your instance or sets it to default. Can be &quot;default&quot; or &quot;disabled&quot;. See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Can be &quot;enabled&quot; or &quot;disabled&quot;. (Default: &quot;enabled&quot;).</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Enables or disables the IPv6 endpoint for the instance metadata service. Can be &quot;enabled&quot; or &quot;disabled&quot;.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from 1 to 64. (Default: 1).</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Can be &quot;optional&quot; or &quot;required&quot;. (Default: &quot;optional&quot;).</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Can be &quot;enabled&quot; or &quot;disabled&quot;.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderMonitoring
{
    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The Connection Tracking Configuration for the network interface. See Amazon EC2 security group connection tracking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesConnectionTrackingSpecification
{
    /// <summary>Timeout (in seconds) for idle TCP connections in an established state. Min: 60 seconds. Max: 432000 seconds (5 days). Default: 432000 seconds. Recommended: Less than 432000 seconds.</summary>
    [JsonPropertyName("tcpEstablishedTimeout")]
    public double? TcpEstablishedTimeout { get; set; }

    /// <summary>Timeout (in seconds) for idle UDP flows classified as streams which have seen more than one request-response transaction. Min: 60 seconds. Max: 180 seconds (3 minutes). Default: 180 seconds.</summary>
    [JsonPropertyName("udpStreamTimeout")]
    public double? UdpStreamTimeout { get; set; }

    /// <summary>Timeout (in seconds) for idle UDP flows that have seen traffic only in a single direction or a single request-response transaction. Min: 30 seconds. Max: 60 seconds. Default: 30 seconds.</summary>
    [JsonPropertyName("udpTimeout")]
    public double? UdpTimeout { get; set; }
}

/// <summary>Configuration for ENA Express UDP optimization. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification
{
    /// <summary>Whether to enable UDP traffic optimization through ENA Express. Requires ena_srd_enabled to be true.</summary>
    [JsonPropertyName("enaSrdUdpEnabled")]
    public bool? EnaSrdUdpEnabled { get; set; }
}

/// <summary>Configuration for Elastic Network Adapter (ENA) Express settings. Applies to network interfaces that use the ena Express feature. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesEnaSrdSpecification
{
    /// <summary>Whether to enable ENA Express. ENA Express uses AWS Scalable Reliable Datagram (SRD) technology to improve the performance of TCP traffic.</summary>
    [JsonPropertyName("enaSrdEnabled")]
    public bool? EnaSrdEnabled { get; set; }

    /// <summary>Configuration for ENA Express UDP optimization. See details below.</summary>
    [JsonPropertyName("enaSrdUdpSpecification")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelector
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
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelector
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
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelector
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
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkInterfaces
{
    /// <summary>Associate a Carrier IP address with eth0 for a new network interface. Use this option when you launch an instance in a Wavelength Zone and want to associate a Carrier IP address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associateCarrierIpAddress")]
    public string? AssociateCarrierIpAddress { get; set; }

    /// <summary>Associate a public ip address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public string? AssociatePublicIpAddress { get; set; }

    /// <summary>The Connection Tracking Configuration for the network interface. See Amazon EC2 security group connection tracking</summary>
    [JsonPropertyName("connectionTrackingSpecification")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesConnectionTrackingSpecification? ConnectionTrackingSpecification { get; set; }

    /// <summary>Whether the network interface should be destroyed on instance termination.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Description of the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integer index of the network interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Configuration for Elastic Network Adapter (ENA) Express settings. Applies to network interfaces that use the ena Express feature. See details below.</summary>
    [JsonPropertyName("enaSrdSpecification")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesEnaSrdSpecification? EnaSrdSpecification { get; set; }

    /// <summary>The type of network interface. To create an Elastic Fabric Adapter (EFA), specify efa.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>The number of secondary private IPv4 addresses to assign to a network interface. Conflicts with ipv4_addresses</summary>
    [JsonPropertyName("ipv4AddressCount")]
    public double? Ipv4AddressCount { get; set; }

    /// <summary>One or more private IPv4 addresses to associate. Conflicts with ipv4_address_count</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The number of IPv4 prefixes to be automatically assigned to the network interface. Conflicts with ipv4_prefixes</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes to be assigned to the network interface. Conflicts with ipv4_prefix_count</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>The number of IPv6 addresses to assign to a network interface. Conflicts with ipv6_addresses</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Conflicts with ipv6_address_count</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>The number of IPv6 prefixes to be automatically assigned to the network interface. Conflicts with ipv6_prefixes</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes to be assigned to the network interface. Conflicts with ipv6_prefix_count</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>The index of the network card. Some instance types support multiple network cards. The primary network interface must be assigned to network card index 0. The default is network card index 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary>Whether the first IPv6 GUA will be made the primary IPv6 address.</summary>
    [JsonPropertyName("primaryIpv6")]
    public string? PrimaryIpv6 { get; set; }

    /// <summary>The primary private IPv4 address.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>A list of security group IDs to associate.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The VPC Subnet ID to associate.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2LaunchTemplateSpecForProviderNetworkInterfacesSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderNetworkPerformanceOptions
{
    /// <summary>Specify the bandwidth weighting option to boost the associated type of baseline bandwidth. Valid values: default, vpc-1, ebs-1. Default value is default. Setting vpc-1 boosts networking baseline bandwidth and reduces EBS baseline bandwidth. Setting ebs-1 boosts EBS baseline bandwidth and reduces networking baseline bandwidth. Only supported on select instance types. See AWS Documentation for more information.</summary>
    [JsonPropertyName("bandwidthWeighting")]
    public string? BandwidthWeighting { get; set; }
}

/// <summary>The placement of the instance. See Placement below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderPlacement
{
    /// <summary>The affinity setting for an instance on a Dedicated Host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>The Availability Zone for the instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The ID of the placement group for the instance. Conflicts with group_name.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>The name of the placement group for the instance. Conflicts with group_id.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>The ID of the Dedicated Host for the instance.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>The ARN of the Host Resource Group in which to launch instances.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>The number of the partition the instance should launch in. Valid only if the placement group strategy is set to partition.</summary>
    [JsonPropertyName("partitionNumber")]
    public double? PartitionNumber { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    /// <summary>The tenancy of the instance (if the instance is running in a VPC). Can be default, dedicated, or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderSecondaryInterfaces
{
    /// <summary>Whether the secondary interface is deleted when the instance is terminated. The only supported value is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device index for the secondary interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Type of secondary interface. The only supported value is: secondary.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Index of the network card.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>Number of private IPv4 addresses to assign to the secondary interface.</summary>
    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>Private IPv4 addresses to assign to the secondary interface.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>ID of the secondary subnet.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelector
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
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderTagSpecifications
{
    /// <summary>The type of resource to tag.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A map of tags to assign to the resource.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelector
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
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecForProvider
{
    /// <summary>
    /// Specify volumes to attach to the instance besides the volumes specified by the AMI.
    /// See Block Devices below for details.
    /// </summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1beta2LaunchTemplateSpecForProviderBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2LaunchTemplateSpecForProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public V1beta2LaunchTemplateSpecForProviderCpuOptions? CpuOptions { get; set; }

    /// <summary>
    /// Customize the credit specification of the instance. See Credit
    /// Specification below for more details.
    /// </summary>
    [JsonPropertyName("creditSpecification")]
    public V1beta2LaunchTemplateSpecForProviderCreditSpecification? CreditSpecification { get; set; }

    /// <summary>Default Version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public double? DefaultVersion { get; set; }

    /// <summary>Description of the launch template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>
    /// If true, enables EC2 Instance
    /// Termination Protection
    /// </summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public string? EbsOptimized { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public V1beta2LaunchTemplateSpecForProviderEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
    [JsonPropertyName("hibernationOptions")]
    public V1beta2LaunchTemplateSpecForProviderHibernationOptions? HibernationOptions { get; set; }

    /// <summary>
    /// The IAM Instance Profile to launch the instance with. See Instance Profile
    /// below for more details.
    /// </summary>
    [JsonPropertyName("iamInstanceProfile")]
    public V1beta2LaunchTemplateSpecForProviderIamInstanceProfile? IamInstanceProfile { get; set; }

    /// <summary>The AMI from which to launch the instance or use a Systems Manager parameter convention e.g. resolve:ssm:parameter-name. See docs for more details.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>
    /// Shutdown behavior for the instance. Can be stop or terminate.
    /// (Default: stop).
    /// </summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The market (purchasing) option for the instance. See Market Options
    /// below for details.
    /// </summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1beta2LaunchTemplateSpecForProviderInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta2LaunchTemplateSpecForProviderInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>The type of the instance. If present then instance_requirements cannot be present.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The kernel ID.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>The key name to use for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A list of license specifications to associate with. See License Specification below for more details.</summary>
    [JsonPropertyName("licenseSpecification")]
    public IList<V1beta2LaunchTemplateSpecForProviderLicenseSpecification>? LicenseSpecification { get; set; }

    /// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1beta2LaunchTemplateSpecForProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public V1beta2LaunchTemplateSpecForProviderMetadataOptions? MetadataOptions { get; set; }

    /// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta2LaunchTemplateSpecForProviderMonitoring? Monitoring { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customize network interfaces to be attached at instance boot time. See Network
    /// Interfaces below for more details.
    /// </summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta2LaunchTemplateSpecForProviderNetworkInterfaces>? NetworkInterfaces { get; set; }

    [JsonPropertyName("networkPerformanceOptions")]
    public V1beta2LaunchTemplateSpecForProviderNetworkPerformanceOptions? NetworkPerformanceOptions { get; set; }

    /// <summary>The placement of the instance. See Placement below for more details.</summary>
    [JsonPropertyName("placement")]
    public V1beta2LaunchTemplateSpecForProviderPlacement? Placement { get; set; }

    /// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2LaunchTemplateSpecForProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The ID of the RAM disk.</summary>
    [JsonPropertyName("ramDiskId")]
    public string? RamDiskId { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// Secondary interfaces to associate with instances launched from the template. See Secondary
    /// Interfaces below for more details.
    /// </summary>
    [JsonPropertyName("secondaryInterfaces")]
    public IList<V1beta2LaunchTemplateSpecForProviderSecondaryInterfaces>? SecondaryInterfaces { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameRefs")]
    public IList<V1beta2LaunchTemplateSpecForProviderSecurityGroupNameRefs>? SecurityGroupNameRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameSelector")]
    public V1beta2LaunchTemplateSpecForProviderSecurityGroupNameSelector? SecurityGroupNameSelector { get; set; }

    /// <summary>
    /// A list of security group names to associate with. If you are creating Instances in a VPC, use
    /// vpc_security_group_ids instead.
    /// </summary>
    [JsonPropertyName("securityGroupNames")]
    public IList<string>? SecurityGroupNames { get; set; }

    /// <summary>The tags to apply to the resources during launch. See Tag Specifications below for more details. Default tags are currently not propagated to ASG created resources so you may wish to inject your default tags into this variable against the relevant child resource types created.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta2LaunchTemplateSpecForProviderTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to update Default Version each update. Conflicts with default_version.</summary>
    [JsonPropertyName("updateDefaultVersion")]
    public bool? UpdateDefaultVersion { get; set; }

    /// <summary>The base64-encoded user data to provide when launching the instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2LaunchTemplateSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>A list of security group IDs to associate with. Conflicts with network_interfaces.security_groups</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelector
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
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelectorPolicy? Policy { get; set; }
}

/// <summary>Configure EBS volume properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbs
{
    /// <summary>
    /// Whether the volume should be destroyed on instance termination.
    /// See Preserving Amazon EBS Volumes on Instance Termination for more information.
    /// </summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>
    /// Enables EBS encryption on the volume.
    /// Cannot be used with snapshot_id.
    /// </summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>
    /// The amount of provisioned IOPS.
    /// This must be set with a volume_type of &quot;io1/io2/gp3&quot;.
    /// </summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>
    /// Identifier (key ID, key alias, key ARN, or alias ARN) of the customer managed KMS key to use for EBS encryption.
    /// encrypted must be set to true when this is set.
    /// </summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdRef")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdRef? KmsKeyIdRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyId.</summary>
    [JsonPropertyName("kmsKeyIdSelector")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbsKmsKeyIdSelector? KmsKeyIdSelector { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput to provision for a gp3 volume in MiB/s (specified as an integer, e.g., 500), with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The volume initialization rate in MiB/s (specified as an integer, e.g. 100), with a minimum of 100 MiB/s and maximum of 300 MiB/s.</summary>
    [JsonPropertyName("volumeInitializationRate")]
    public double? VolumeInitializationRate { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>
    /// The volume type.
    /// Can be one of standard, gp2, gp3, io1, io2, sc1 or st1.
    /// </summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappings
{
    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configure EBS volume properties.</summary>
    [JsonPropertyName("ebs")]
    public V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappingsEbs? Ebs { get; set; }

    /// <summary>Suppresses the specified device included in the AMI&apos;s block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    /// <summary>
    /// The Instance Store Device
    /// Name
    /// (e.g., &quot;ephemeral0&quot;).
    /// </summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Used to target a specific Capacity Reservation:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>The ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance&apos;s Capacity Reservation preferences. Can be capacity-reservations-only, open or none. If capacity_reservation_id or capacity_reservation_resource_group_arn is specified in capacity_reservation_target block, either omit capacity_reservation_preference or set it to capacity-reservations-only.</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Used to target a specific Capacity Reservation:</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2LaunchTemplateSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>The number of CPU cores for the instance.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Indicates whether to enable the instance for nested virtualization. Nested virtualization is supported on 8th generation Intel-based instance types (C8i, M8i, R8i, and their flex variants) only. When nested virtualization is enabled, Virtual Secure Mode (VSM) is automatically disabled for the instance. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    /// <summary>
    /// The number of threads per CPU core.
    /// To disable Intel Hyper-Threading Technology for the instance, specify a value of 1.
    /// Otherwise, specify the default value of 2.
    /// </summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary>
/// Customize the credit specification of the instance. See Credit
/// Specification below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderCreditSpecification
{
    /// <summary>
    /// The credit option for CPU usage.
    /// Can be standard or unlimited.
    /// T3 instances are launched as unlimited by default.
    /// T2 instances are launched as standard by default.
    /// </summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderEnclaveOptions
{
    /// <summary>If set to true, Nitro Enclaves will be enabled on the instance.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderHibernationOptions
{
    /// <summary>If set to true, the launched EC2 instance will hibernation enabled.</summary>
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelector
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
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelector
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
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The IAM Instance Profile to launch the instance with. See Instance Profile
/// below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderIamInstanceProfile
{
    /// <summary>The Amazon Resource Name (ARN) of the instance profile. Conflicts with name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnRef? ArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileArnSelector? ArnSelector { get; set; }

    /// <summary>The name of the instance profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameRef? NameRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfileNameSelector? NameSelector { get; set; }
}

/// <summary>The options for Spot Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The required duration in minutes. This value must be a multiple of 60.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary>
    /// The behavior when a Spot Instance is interrupted. Can be hibernate,
    /// stop, or terminate. (Default: terminate).
    /// </summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price you&apos;re willing to pay for the Spot Instances.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Can be one-time, or persistent.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>
/// The market (purchasing) option for the instance. See Market Options
/// below for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceMarketOptions
{
    /// <summary>The market type. Can be spot.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instance</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderLicenseSpecification
{
    /// <summary>ARN of the license configuration.</summary>
    [JsonPropertyName("licenseConfigurationArn")]
    public string? LicenseConfigurationArn { get; set; }
}

/// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderMaintenanceOptions
{
    /// <summary>Disables the automatic recovery behavior of your instance or sets it to default. Can be &quot;default&quot; or &quot;disabled&quot;. See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Can be &quot;enabled&quot; or &quot;disabled&quot;. (Default: &quot;enabled&quot;).</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Enables or disables the IPv6 endpoint for the instance metadata service. Can be &quot;enabled&quot; or &quot;disabled&quot;.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from 1 to 64. (Default: 1).</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Can be &quot;optional&quot; or &quot;required&quot;. (Default: &quot;optional&quot;).</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Can be &quot;enabled&quot; or &quot;disabled&quot;.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderMonitoring
{
    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The Connection Tracking Configuration for the network interface. See Amazon EC2 security group connection tracking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesConnectionTrackingSpecification
{
    /// <summary>Timeout (in seconds) for idle TCP connections in an established state. Min: 60 seconds. Max: 432000 seconds (5 days). Default: 432000 seconds. Recommended: Less than 432000 seconds.</summary>
    [JsonPropertyName("tcpEstablishedTimeout")]
    public double? TcpEstablishedTimeout { get; set; }

    /// <summary>Timeout (in seconds) for idle UDP flows classified as streams which have seen more than one request-response transaction. Min: 60 seconds. Max: 180 seconds (3 minutes). Default: 180 seconds.</summary>
    [JsonPropertyName("udpStreamTimeout")]
    public double? UdpStreamTimeout { get; set; }

    /// <summary>Timeout (in seconds) for idle UDP flows that have seen traffic only in a single direction or a single request-response transaction. Min: 30 seconds. Max: 60 seconds. Default: 30 seconds.</summary>
    [JsonPropertyName("udpTimeout")]
    public double? UdpTimeout { get; set; }
}

/// <summary>Configuration for ENA Express UDP optimization. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification
{
    /// <summary>Whether to enable UDP traffic optimization through ENA Express. Requires ena_srd_enabled to be true.</summary>
    [JsonPropertyName("enaSrdUdpEnabled")]
    public bool? EnaSrdUdpEnabled { get; set; }
}

/// <summary>Configuration for Elastic Network Adapter (ENA) Express settings. Applies to network interfaces that use the ena Express feature. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesEnaSrdSpecification
{
    /// <summary>Whether to enable ENA Express. ENA Express uses AWS Scalable Reliable Datagram (SRD) technology to improve the performance of TCP traffic.</summary>
    [JsonPropertyName("enaSrdEnabled")]
    public bool? EnaSrdEnabled { get; set; }

    /// <summary>Configuration for ENA Express UDP optimization. See details below.</summary>
    [JsonPropertyName("enaSrdUdpSpecification")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelector
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
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelector
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
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelector
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
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkInterfaces
{
    /// <summary>Associate a Carrier IP address with eth0 for a new network interface. Use this option when you launch an instance in a Wavelength Zone and want to associate a Carrier IP address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associateCarrierIpAddress")]
    public string? AssociateCarrierIpAddress { get; set; }

    /// <summary>Associate a public ip address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public string? AssociatePublicIpAddress { get; set; }

    /// <summary>The Connection Tracking Configuration for the network interface. See Amazon EC2 security group connection tracking</summary>
    [JsonPropertyName("connectionTrackingSpecification")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesConnectionTrackingSpecification? ConnectionTrackingSpecification { get; set; }

    /// <summary>Whether the network interface should be destroyed on instance termination.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Description of the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integer index of the network interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Configuration for Elastic Network Adapter (ENA) Express settings. Applies to network interfaces that use the ena Express feature. See details below.</summary>
    [JsonPropertyName("enaSrdSpecification")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesEnaSrdSpecification? EnaSrdSpecification { get; set; }

    /// <summary>The type of network interface. To create an Elastic Fabric Adapter (EFA), specify efa.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>The number of secondary private IPv4 addresses to assign to a network interface. Conflicts with ipv4_addresses</summary>
    [JsonPropertyName("ipv4AddressCount")]
    public double? Ipv4AddressCount { get; set; }

    /// <summary>One or more private IPv4 addresses to associate. Conflicts with ipv4_address_count</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The number of IPv4 prefixes to be automatically assigned to the network interface. Conflicts with ipv4_prefixes</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes to be assigned to the network interface. Conflicts with ipv4_prefix_count</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>The number of IPv6 addresses to assign to a network interface. Conflicts with ipv6_addresses</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Conflicts with ipv6_address_count</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>The number of IPv6 prefixes to be automatically assigned to the network interface. Conflicts with ipv6_prefixes</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes to be assigned to the network interface. Conflicts with ipv6_prefix_count</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>The index of the network card. Some instance types support multiple network cards. The primary network interface must be assigned to network card index 0. The default is network card index 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Reference to a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdRef")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdRef? NetworkInterfaceIdRef { get; set; }

    /// <summary>Selector for a NetworkInterface in ec2 to populate networkInterfaceId.</summary>
    [JsonPropertyName("networkInterfaceIdSelector")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesNetworkInterfaceIdSelector? NetworkInterfaceIdSelector { get; set; }

    /// <summary>Whether the first IPv6 GUA will be made the primary IPv6 address.</summary>
    [JsonPropertyName("primaryIpv6")]
    public string? PrimaryIpv6 { get; set; }

    /// <summary>The primary private IPv4 address.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>A list of security group IDs to associate.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The VPC Subnet ID to associate.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkInterfacesSubnetIdSelector? SubnetIdSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderNetworkPerformanceOptions
{
    /// <summary>Specify the bandwidth weighting option to boost the associated type of baseline bandwidth. Valid values: default, vpc-1, ebs-1. Default value is default. Setting vpc-1 boosts networking baseline bandwidth and reduces EBS baseline bandwidth. Setting ebs-1 boosts EBS baseline bandwidth and reduces networking baseline bandwidth. Only supported on select instance types. See AWS Documentation for more information.</summary>
    [JsonPropertyName("bandwidthWeighting")]
    public string? BandwidthWeighting { get; set; }
}

/// <summary>The placement of the instance. See Placement below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderPlacement
{
    /// <summary>The affinity setting for an instance on a Dedicated Host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>The Availability Zone for the instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The ID of the placement group for the instance. Conflicts with group_name.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>The name of the placement group for the instance. Conflicts with group_id.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>The ID of the Dedicated Host for the instance.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>The ARN of the Host Resource Group in which to launch instances.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>The number of the partition the instance should launch in. Valid only if the placement group strategy is set to partition.</summary>
    [JsonPropertyName("partitionNumber")]
    public double? PartitionNumber { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    /// <summary>The tenancy of the instance (if the instance is running in a VPC). Can be default, dedicated, or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderSecondaryInterfaces
{
    /// <summary>Whether the secondary interface is deleted when the instance is terminated. The only supported value is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device index for the secondary interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Type of secondary interface. The only supported value is: secondary.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Index of the network card.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>Number of private IPv4 addresses to assign to the secondary interface.</summary>
    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>Private IPv4 addresses to assign to the secondary interface.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>ID of the secondary subnet.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelector
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
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderTagSpecifications
{
    /// <summary>The type of resource to tag.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A map of tags to assign to the resource.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelector
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
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2LaunchTemplateSpecInitProvider
{
    /// <summary>
    /// Specify volumes to attach to the instance besides the volumes specified by the AMI.
    /// See Block Devices below for details.
    /// </summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1beta2LaunchTemplateSpecInitProviderBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2LaunchTemplateSpecInitProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public V1beta2LaunchTemplateSpecInitProviderCpuOptions? CpuOptions { get; set; }

    /// <summary>
    /// Customize the credit specification of the instance. See Credit
    /// Specification below for more details.
    /// </summary>
    [JsonPropertyName("creditSpecification")]
    public V1beta2LaunchTemplateSpecInitProviderCreditSpecification? CreditSpecification { get; set; }

    /// <summary>Default Version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public double? DefaultVersion { get; set; }

    /// <summary>Description of the launch template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>
    /// If true, enables EC2 Instance
    /// Termination Protection
    /// </summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public string? EbsOptimized { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public V1beta2LaunchTemplateSpecInitProviderEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
    [JsonPropertyName("hibernationOptions")]
    public V1beta2LaunchTemplateSpecInitProviderHibernationOptions? HibernationOptions { get; set; }

    /// <summary>
    /// The IAM Instance Profile to launch the instance with. See Instance Profile
    /// below for more details.
    /// </summary>
    [JsonPropertyName("iamInstanceProfile")]
    public V1beta2LaunchTemplateSpecInitProviderIamInstanceProfile? IamInstanceProfile { get; set; }

    /// <summary>The AMI from which to launch the instance or use a Systems Manager parameter convention e.g. resolve:ssm:parameter-name. See docs for more details.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>
    /// Shutdown behavior for the instance. Can be stop or terminate.
    /// (Default: stop).
    /// </summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The market (purchasing) option for the instance. See Market Options
    /// below for details.
    /// </summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta2LaunchTemplateSpecInitProviderInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>The type of the instance. If present then instance_requirements cannot be present.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The kernel ID.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>The key name to use for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>A list of license specifications to associate with. See License Specification below for more details.</summary>
    [JsonPropertyName("licenseSpecification")]
    public IList<V1beta2LaunchTemplateSpecInitProviderLicenseSpecification>? LicenseSpecification { get; set; }

    /// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1beta2LaunchTemplateSpecInitProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public V1beta2LaunchTemplateSpecInitProviderMetadataOptions? MetadataOptions { get; set; }

    /// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta2LaunchTemplateSpecInitProviderMonitoring? Monitoring { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customize network interfaces to be attached at instance boot time. See Network
    /// Interfaces below for more details.
    /// </summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta2LaunchTemplateSpecInitProviderNetworkInterfaces>? NetworkInterfaces { get; set; }

    [JsonPropertyName("networkPerformanceOptions")]
    public V1beta2LaunchTemplateSpecInitProviderNetworkPerformanceOptions? NetworkPerformanceOptions { get; set; }

    /// <summary>The placement of the instance. See Placement below for more details.</summary>
    [JsonPropertyName("placement")]
    public V1beta2LaunchTemplateSpecInitProviderPlacement? Placement { get; set; }

    /// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2LaunchTemplateSpecInitProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The ID of the RAM disk.</summary>
    [JsonPropertyName("ramDiskId")]
    public string? RamDiskId { get; set; }

    /// <summary>
    /// Secondary interfaces to associate with instances launched from the template. See Secondary
    /// Interfaces below for more details.
    /// </summary>
    [JsonPropertyName("secondaryInterfaces")]
    public IList<V1beta2LaunchTemplateSpecInitProviderSecondaryInterfaces>? SecondaryInterfaces { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameRefs")]
    public IList<V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameRefs>? SecurityGroupNameRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroupNames.</summary>
    [JsonPropertyName("securityGroupNameSelector")]
    public V1beta2LaunchTemplateSpecInitProviderSecurityGroupNameSelector? SecurityGroupNameSelector { get; set; }

    /// <summary>
    /// A list of security group names to associate with. If you are creating Instances in a VPC, use
    /// vpc_security_group_ids instead.
    /// </summary>
    [JsonPropertyName("securityGroupNames")]
    public IList<string>? SecurityGroupNames { get; set; }

    /// <summary>The tags to apply to the resources during launch. See Tag Specifications below for more details. Default tags are currently not propagated to ASG created resources so you may wish to inject your default tags into this variable against the relevant child resource types created.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta2LaunchTemplateSpecInitProviderTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Whether to update Default Version each update. Conflicts with default_version.</summary>
    [JsonPropertyName("updateDefaultVersion")]
    public bool? UpdateDefaultVersion { get; set; }

    /// <summary>The base64-encoded user data to provide when launching the instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2LaunchTemplateSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    /// <summary>A list of security group IDs to associate with. Conflicts with network_interfaces.security_groups</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2LaunchTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2LaunchTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2LaunchTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2LaunchTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2LaunchTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2LaunchTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2LaunchTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>LaunchTemplateSpec defines the desired state of LaunchTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateSpec
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
    public V1beta2LaunchTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2LaunchTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2LaunchTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2LaunchTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2LaunchTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2LaunchTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure EBS volume properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderBlockDeviceMappingsEbs
{
    /// <summary>
    /// Whether the volume should be destroyed on instance termination.
    /// See Preserving Amazon EBS Volumes on Instance Termination for more information.
    /// </summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>
    /// Enables EBS encryption on the volume.
    /// Cannot be used with snapshot_id.
    /// </summary>
    [JsonPropertyName("encrypted")]
    public string? Encrypted { get; set; }

    /// <summary>
    /// The amount of provisioned IOPS.
    /// This must be set with a volume_type of &quot;io1/io2/gp3&quot;.
    /// </summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>
    /// Identifier (key ID, key alias, key ARN, or alias ARN) of the customer managed KMS key to use for EBS encryption.
    /// encrypted must be set to true when this is set.
    /// </summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Snapshot ID to mount.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The throughput to provision for a gp3 volume in MiB/s (specified as an integer, e.g., 500), with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The volume initialization rate in MiB/s (specified as an integer, e.g. 100), with a minimum of 100 MiB/s and maximum of 300 MiB/s.</summary>
    [JsonPropertyName("volumeInitializationRate")]
    public double? VolumeInitializationRate { get; set; }

    /// <summary>The size of the volume in gigabytes.</summary>
    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    /// <summary>
    /// The volume type.
    /// Can be one of standard, gp2, gp3, io1, io2, sc1 or st1.
    /// </summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderBlockDeviceMappings
{
    /// <summary>The name of the device to mount.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Configure EBS volume properties.</summary>
    [JsonPropertyName("ebs")]
    public V1beta2LaunchTemplateStatusAtProviderBlockDeviceMappingsEbs? Ebs { get; set; }

    /// <summary>Suppresses the specified device included in the AMI&apos;s block device mapping.</summary>
    [JsonPropertyName("noDevice")]
    public string? NoDevice { get; set; }

    /// <summary>
    /// The Instance Store Device
    /// Name
    /// (e.g., &quot;ephemeral0&quot;).
    /// </summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>Used to target a specific Capacity Reservation:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The ID of the Capacity Reservation in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    /// <summary>The ARN of the Capacity Reservation resource group in which to run the instance.</summary>
    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

/// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderCapacityReservationSpecification
{
    /// <summary>Indicates the instance&apos;s Capacity Reservation preferences. Can be capacity-reservations-only, open or none. If capacity_reservation_id or capacity_reservation_resource_group_arn is specified in capacity_reservation_target block, either omit capacity_reservation_preference or set it to capacity-reservations-only.</summary>
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    /// <summary>Used to target a specific Capacity Reservation:</summary>
    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2LaunchTemplateStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

/// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderCpuOptions
{
    /// <summary>Indicates whether to enable the instance for AMD SEV-SNP. AMD SEV-SNP is supported with M6a, R6a, and C6a instance types only. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    /// <summary>The number of CPU cores for the instance.</summary>
    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    /// <summary>Indicates whether to enable the instance for nested virtualization. Nested virtualization is supported on 8th generation Intel-based instance types (C8i, M8i, R8i, and their flex variants) only. When nested virtualization is enabled, Virtual Secure Mode (VSM) is automatically disabled for the instance. Valid values are enabled and disabled.</summary>
    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    /// <summary>
    /// The number of threads per CPU core.
    /// To disable Intel Hyper-Threading Technology for the instance, specify a value of 1.
    /// Otherwise, specify the default value of 2.
    /// </summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

/// <summary>
/// Customize the credit specification of the instance. See Credit
/// Specification below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderCreditSpecification
{
    /// <summary>
    /// The credit option for CPU usage.
    /// Can be standard or unlimited.
    /// T3 instances are launched as unlimited by default.
    /// T2 instances are launched as standard by default.
    /// </summary>
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

/// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderEnclaveOptions
{
    /// <summary>If set to true, Nitro Enclaves will be enabled on the instance.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderHibernationOptions
{
    /// <summary>If set to true, the launched EC2 instance will hibernation enabled.</summary>
    [JsonPropertyName("configured")]
    public bool? Configured { get; set; }
}

/// <summary>
/// The IAM Instance Profile to launch the instance with. See Instance Profile
/// below for more details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderIamInstanceProfile
{
    /// <summary>The Amazon Resource Name (ARN) of the instance profile. Conflicts with name.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The name of the instance profile.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>The options for Spot Instance</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceMarketOptionsSpotOptions
{
    /// <summary>The required duration in minutes. This value must be a multiple of 60.</summary>
    [JsonPropertyName("blockDurationMinutes")]
    public double? BlockDurationMinutes { get; set; }

    /// <summary>
    /// The behavior when a Spot Instance is interrupted. Can be hibernate,
    /// stop, or terminate. (Default: terminate).
    /// </summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    /// <summary>The maximum hourly price you&apos;re willing to pay for the Spot Instances.</summary>
    [JsonPropertyName("maxPrice")]
    public string? MaxPrice { get; set; }

    /// <summary>The Spot Instance request type. Can be one-time, or persistent.</summary>
    [JsonPropertyName("spotInstanceType")]
    public string? SpotInstanceType { get; set; }

    /// <summary>The end date of the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }
}

/// <summary>
/// The market (purchasing) option for the instance. See Market Options
/// below for details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceMarketOptions
{
    /// <summary>The market type. Can be spot.</summary>
    [JsonPropertyName("marketType")]
    public string? MarketType { get; set; }

    /// <summary>The options for Spot Instance</summary>
    [JsonPropertyName("spotOptions")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceMarketOptionsSpotOptions? SpotOptions { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorTotalMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsBaselineEbsBandwidthMbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsMemoryGibPerVcpu
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsMemoryMib
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsNetworkBandwidthGbps
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsNetworkInterfaceCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsTotalLocalStorageGb
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

    /// <summary>List of accelerator types. Default is any accelerator type.</summary>
    [JsonPropertyName("acceleratorTypes")]
    public IList<string>? AcceleratorTypes { get; set; }

    /// <summary>List of instance types to apply your specified attributes against. All other instance types are ignored, even if they match your specified attributes. You can use strings with one or more wild cards, represented by an asterisk (*), to allow an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are allowing the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are allowing all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is all instance types.</summary>
    [JsonPropertyName("allowedInstanceTypes")]
    public IList<string>? AllowedInstanceTypes { get; set; }

    /// <summary>Indicate whether bare metal instace types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("bareMetal")]
    public string? BareMetal { get; set; }

    /// <summary>Block describing the minimum and maximum baseline EBS bandwidth, in Mbps. Default is no minimum or maximum.</summary>
    [JsonPropertyName("baselineEbsBandwidthMbps")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

    /// <summary>Indicate whether burstable performance instance types should be included, excluded, or required. Default is excluded.</summary>
    [JsonPropertyName("burstablePerformance")]
    public string? BurstablePerformance { get; set; }

    /// <summary>List of CPU manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("cpuManufacturers")]
    public IList<string>? CpuManufacturers { get; set; }

    /// <summary>List of instance types to exclude. You can use strings with one or more wild cards, represented by an asterisk (*), to exclude an instance type, size, or generation. The following are examples: m5.8xlarge, c5*.*, m5a.*, r*, *3*. For example, if you specify c5*, you are excluding the entire C5 instance family, which includes all C5a and C5n instance types. If you specify m5a.*, you are excluding all the M5a instance types, but not the M5n instance types. Maximum of 400 entries in the list; each entry is limited to 30 characters. Default is no excluded instance types.</summary>
    [JsonPropertyName("excludedInstanceTypes")]
    public IList<string>? ExcludedInstanceTypes { get; set; }

    /// <summary>List of instance generation names. Default is any generation.</summary>
    [JsonPropertyName("instanceGenerations")]
    public IList<string>? InstanceGenerations { get; set; }

    /// <summary>Indicate whether instance types with local storage volumes are included, excluded, or required. Default is included.</summary>
    [JsonPropertyName("localStorage")]
    public string? LocalStorage { get; set; }

    /// <summary>List of local storage type names. Default any storage type.</summary>
    [JsonPropertyName("localStorageTypes")]
    public IList<string>? LocalStorageTypes { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Conflicts with spot_max_price_percentage_over_lowest_price</summary>
    [JsonPropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice")]
    public double? MaxSpotPriceAsPercentageOfOptimalOnDemandPrice { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100. Conflicts with max_spot_price_as_percentage_of_optimal_on_demand_price</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderLicenseSpecification
{
    /// <summary>ARN of the license configuration.</summary>
    [JsonPropertyName("licenseConfigurationArn")]
    public string? LicenseConfigurationArn { get; set; }
}

/// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderMaintenanceOptions
{
    /// <summary>Disables the automatic recovery behavior of your instance or sets it to default. Can be &quot;default&quot; or &quot;disabled&quot;. See Recover your instance for more details.</summary>
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

/// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderMetadataOptions
{
    /// <summary>Whether the metadata service is available. Can be &quot;enabled&quot; or &quot;disabled&quot;. (Default: &quot;enabled&quot;).</summary>
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    /// <summary>Enables or disables the IPv6 endpoint for the instance metadata service. Can be &quot;enabled&quot; or &quot;disabled&quot;.</summary>
    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    /// <summary>The desired HTTP PUT response hop limit for instance metadata requests. The larger the number, the further instance metadata requests can travel. Can be an integer from 1 to 64. (Default: 1).</summary>
    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    /// <summary>Whether or not the metadata service requires session tokens, also referred to as Instance Metadata Service Version 2 (IMDSv2). Can be &quot;optional&quot; or &quot;required&quot;. (Default: &quot;optional&quot;).</summary>
    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Enables or disables access to instance tags from the instance metadata service. Can be &quot;enabled&quot; or &quot;disabled&quot;.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

/// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderMonitoring
{
    /// <summary>If true, the launched EC2 instance will have detailed monitoring enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>The Connection Tracking Configuration for the network interface. See Amazon EC2 security group connection tracking</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderNetworkInterfacesConnectionTrackingSpecification
{
    /// <summary>Timeout (in seconds) for idle TCP connections in an established state. Min: 60 seconds. Max: 432000 seconds (5 days). Default: 432000 seconds. Recommended: Less than 432000 seconds.</summary>
    [JsonPropertyName("tcpEstablishedTimeout")]
    public double? TcpEstablishedTimeout { get; set; }

    /// <summary>Timeout (in seconds) for idle UDP flows classified as streams which have seen more than one request-response transaction. Min: 60 seconds. Max: 180 seconds (3 minutes). Default: 180 seconds.</summary>
    [JsonPropertyName("udpStreamTimeout")]
    public double? UdpStreamTimeout { get; set; }

    /// <summary>Timeout (in seconds) for idle UDP flows that have seen traffic only in a single direction or a single request-response transaction. Min: 30 seconds. Max: 60 seconds. Default: 30 seconds.</summary>
    [JsonPropertyName("udpTimeout")]
    public double? UdpTimeout { get; set; }
}

/// <summary>Configuration for ENA Express UDP optimization. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification
{
    /// <summary>Whether to enable UDP traffic optimization through ENA Express. Requires ena_srd_enabled to be true.</summary>
    [JsonPropertyName("enaSrdUdpEnabled")]
    public bool? EnaSrdUdpEnabled { get; set; }
}

/// <summary>Configuration for Elastic Network Adapter (ENA) Express settings. Applies to network interfaces that use the ena Express feature. See details below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderNetworkInterfacesEnaSrdSpecification
{
    /// <summary>Whether to enable ENA Express. ENA Express uses AWS Scalable Reliable Datagram (SRD) technology to improve the performance of TCP traffic.</summary>
    [JsonPropertyName("enaSrdEnabled")]
    public bool? EnaSrdEnabled { get; set; }

    /// <summary>Configuration for ENA Express UDP optimization. See details below.</summary>
    [JsonPropertyName("enaSrdUdpSpecification")]
    public V1beta2LaunchTemplateStatusAtProviderNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecification { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderNetworkInterfaces
{
    /// <summary>Associate a Carrier IP address with eth0 for a new network interface. Use this option when you launch an instance in a Wavelength Zone and want to associate a Carrier IP address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associateCarrierIpAddress")]
    public string? AssociateCarrierIpAddress { get; set; }

    /// <summary>Associate a public ip address with the network interface. Boolean value, can be left unset.</summary>
    [JsonPropertyName("associatePublicIpAddress")]
    public string? AssociatePublicIpAddress { get; set; }

    /// <summary>The Connection Tracking Configuration for the network interface. See Amazon EC2 security group connection tracking</summary>
    [JsonPropertyName("connectionTrackingSpecification")]
    public V1beta2LaunchTemplateStatusAtProviderNetworkInterfacesConnectionTrackingSpecification? ConnectionTrackingSpecification { get; set; }

    /// <summary>Whether the network interface should be destroyed on instance termination.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public string? DeleteOnTermination { get; set; }

    /// <summary>Description of the network interface.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The integer index of the network interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Configuration for Elastic Network Adapter (ENA) Express settings. Applies to network interfaces that use the ena Express feature. See details below.</summary>
    [JsonPropertyName("enaSrdSpecification")]
    public V1beta2LaunchTemplateStatusAtProviderNetworkInterfacesEnaSrdSpecification? EnaSrdSpecification { get; set; }

    /// <summary>The type of network interface. To create an Elastic Fabric Adapter (EFA), specify efa.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>The number of secondary private IPv4 addresses to assign to a network interface. Conflicts with ipv4_addresses</summary>
    [JsonPropertyName("ipv4AddressCount")]
    public double? Ipv4AddressCount { get; set; }

    /// <summary>One or more private IPv4 addresses to associate. Conflicts with ipv4_address_count</summary>
    [JsonPropertyName("ipv4Addresses")]
    public IList<string>? Ipv4Addresses { get; set; }

    /// <summary>The number of IPv4 prefixes to be automatically assigned to the network interface. Conflicts with ipv4_prefixes</summary>
    [JsonPropertyName("ipv4PrefixCount")]
    public double? Ipv4PrefixCount { get; set; }

    /// <summary>One or more IPv4 prefixes to be assigned to the network interface. Conflicts with ipv4_prefix_count</summary>
    [JsonPropertyName("ipv4Prefixes")]
    public IList<string>? Ipv4Prefixes { get; set; }

    /// <summary>The number of IPv6 addresses to assign to a network interface. Conflicts with ipv6_addresses</summary>
    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    /// <summary>One or more specific IPv6 addresses from the IPv6 CIDR block range of your subnet. Conflicts with ipv6_address_count</summary>
    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    /// <summary>The number of IPv6 prefixes to be automatically assigned to the network interface. Conflicts with ipv6_prefixes</summary>
    [JsonPropertyName("ipv6PrefixCount")]
    public double? Ipv6PrefixCount { get; set; }

    /// <summary>One or more IPv6 prefixes to be assigned to the network interface. Conflicts with ipv6_prefix_count</summary>
    [JsonPropertyName("ipv6Prefixes")]
    public IList<string>? Ipv6Prefixes { get; set; }

    /// <summary>The index of the network card. Some instance types support multiple network cards. The primary network interface must be assigned to network card index 0. The default is network card index 0.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The ID of the network interface to attach.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }

    /// <summary>Whether the first IPv6 GUA will be made the primary IPv6 address.</summary>
    [JsonPropertyName("primaryIpv6")]
    public string? PrimaryIpv6 { get; set; }

    /// <summary>The primary private IPv4 address.</summary>
    [JsonPropertyName("privateIpAddress")]
    public string? PrivateIpAddress { get; set; }

    /// <summary>A list of security group IDs to associate.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>The VPC Subnet ID to associate.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderNetworkPerformanceOptions
{
    /// <summary>Specify the bandwidth weighting option to boost the associated type of baseline bandwidth. Valid values: default, vpc-1, ebs-1. Default value is default. Setting vpc-1 boosts networking baseline bandwidth and reduces EBS baseline bandwidth. Setting ebs-1 boosts EBS baseline bandwidth and reduces networking baseline bandwidth. Only supported on select instance types. See AWS Documentation for more information.</summary>
    [JsonPropertyName("bandwidthWeighting")]
    public string? BandwidthWeighting { get; set; }
}

/// <summary>The placement of the instance. See Placement below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderPlacement
{
    /// <summary>The affinity setting for an instance on a Dedicated Host.</summary>
    [JsonPropertyName("affinity")]
    public string? Affinity { get; set; }

    /// <summary>The Availability Zone for the instance.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The ID of the placement group for the instance. Conflicts with group_name.</summary>
    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    /// <summary>The name of the placement group for the instance. Conflicts with group_id.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>The ID of the Dedicated Host for the instance.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    /// <summary>The ARN of the Host Resource Group in which to launch instances.</summary>
    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    /// <summary>The number of the partition the instance should launch in. Valid only if the placement group strategy is set to partition.</summary>
    [JsonPropertyName("partitionNumber")]
    public double? PartitionNumber { get; set; }

    /// <summary>Reserved for future use.</summary>
    [JsonPropertyName("spreadDomain")]
    public string? SpreadDomain { get; set; }

    /// <summary>The tenancy of the instance (if the instance is running in a VPC). Can be default, dedicated, or host.</summary>
    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }
}

/// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderPrivateDnsNameOptions
{
    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS A records.</summary>
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    /// <summary>Indicates whether to respond to DNS queries for instance hostnames with DNS AAAA records.</summary>
    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    /// <summary>The type of hostname for Amazon EC2 instances. For IPv4 only subnets, an instance DNS name must be based on the instance IPv4 address. For IPv6 native subnets, an instance DNS name must be based on the instance ID. For dual-stack subnets, you can specify whether DNS names use the instance IPv4 address or the instance ID. Valid values: ip-name and resource-name.</summary>
    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderSecondaryInterfaces
{
    /// <summary>Whether the secondary interface is deleted when the instance is terminated. The only supported value is true.</summary>
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>Device index for the secondary interface attachment.</summary>
    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>Type of secondary interface. The only supported value is: secondary.</summary>
    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    /// <summary>Index of the network card.</summary>
    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>Number of private IPv4 addresses to assign to the secondary interface.</summary>
    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>Private IPv4 addresses to assign to the secondary interface.</summary>
    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>ID of the secondary subnet.</summary>
    [JsonPropertyName("secondarySubnetId")]
    public string? SecondarySubnetId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProviderTagSpecifications
{
    /// <summary>The type of resource to tag.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>A map of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the launch template.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// Specify volumes to attach to the instance besides the volumes specified by the AMI.
    /// See Block Devices below for details.
    /// </summary>
    [JsonPropertyName("blockDeviceMappings")]
    public IList<V1beta2LaunchTemplateStatusAtProviderBlockDeviceMappings>? BlockDeviceMappings { get; set; }

    /// <summary>Targeting for EC2 capacity reservations. See Capacity Reservation Specification below for more details.</summary>
    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2LaunchTemplateStatusAtProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    /// <summary>The CPU options for the instance. See CPU Options below for more details.</summary>
    [JsonPropertyName("cpuOptions")]
    public V1beta2LaunchTemplateStatusAtProviderCpuOptions? CpuOptions { get; set; }

    /// <summary>
    /// Customize the credit specification of the instance. See Credit
    /// Specification below for more details.
    /// </summary>
    [JsonPropertyName("creditSpecification")]
    public V1beta2LaunchTemplateStatusAtProviderCreditSpecification? CreditSpecification { get; set; }

    /// <summary>Default Version of the launch template.</summary>
    [JsonPropertyName("defaultVersion")]
    public double? DefaultVersion { get; set; }

    /// <summary>Description of the launch template.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>If true, enables EC2 Instance Stop Protection.</summary>
    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    /// <summary>
    /// If true, enables EC2 Instance
    /// Termination Protection
    /// </summary>
    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    /// <summary>If true, the launched EC2 instance will be EBS-optimized.</summary>
    [JsonPropertyName("ebsOptimized")]
    public string? EbsOptimized { get; set; }

    /// <summary>Enable Nitro Enclaves on launched instances. See Enclave Options below for more details.</summary>
    [JsonPropertyName("enclaveOptions")]
    public V1beta2LaunchTemplateStatusAtProviderEnclaveOptions? EnclaveOptions { get; set; }

    /// <summary>The hibernation options for the instance. See Hibernation Options below for more details.</summary>
    [JsonPropertyName("hibernationOptions")]
    public V1beta2LaunchTemplateStatusAtProviderHibernationOptions? HibernationOptions { get; set; }

    /// <summary>
    /// The IAM Instance Profile to launch the instance with. See Instance Profile
    /// below for more details.
    /// </summary>
    [JsonPropertyName("iamInstanceProfile")]
    public V1beta2LaunchTemplateStatusAtProviderIamInstanceProfile? IamInstanceProfile { get; set; }

    /// <summary>The ID of the launch template.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The AMI from which to launch the instance or use a Systems Manager parameter convention e.g. resolve:ssm:parameter-name. See docs for more details.</summary>
    [JsonPropertyName("imageId")]
    public string? ImageId { get; set; }

    /// <summary>
    /// Shutdown behavior for the instance. Can be stop or terminate.
    /// (Default: stop).
    /// </summary>
    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>
    /// The market (purchasing) option for the instance. See Market Options
    /// below for details.
    /// </summary>
    [JsonPropertyName("instanceMarketOptions")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceMarketOptions? InstanceMarketOptions { get; set; }

    /// <summary>The attribute requirements for the type of instance. If present then instance_type cannot be present.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta2LaunchTemplateStatusAtProviderInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>The type of the instance. If present then instance_requirements cannot be present.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The kernel ID.</summary>
    [JsonPropertyName("kernelId")]
    public string? KernelId { get; set; }

    /// <summary>The key name to use for the instance.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>The latest version of the launch template.</summary>
    [JsonPropertyName("latestVersion")]
    public double? LatestVersion { get; set; }

    /// <summary>A list of license specifications to associate with. See License Specification below for more details.</summary>
    [JsonPropertyName("licenseSpecification")]
    public IList<V1beta2LaunchTemplateStatusAtProviderLicenseSpecification>? LicenseSpecification { get; set; }

    /// <summary>The maintenance options for the instance. See Maintenance Options below for more details.</summary>
    [JsonPropertyName("maintenanceOptions")]
    public V1beta2LaunchTemplateStatusAtProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    /// <summary>Customize the metadata options for the instance. See Metadata Options below for more details.</summary>
    [JsonPropertyName("metadataOptions")]
    public V1beta2LaunchTemplateStatusAtProviderMetadataOptions? MetadataOptions { get; set; }

    /// <summary>The monitoring option for the instance. See Monitoring below for more details.</summary>
    [JsonPropertyName("monitoring")]
    public V1beta2LaunchTemplateStatusAtProviderMonitoring? Monitoring { get; set; }

    /// <summary>The name of the launch template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Customize network interfaces to be attached at instance boot time. See Network
    /// Interfaces below for more details.
    /// </summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta2LaunchTemplateStatusAtProviderNetworkInterfaces>? NetworkInterfaces { get; set; }

    [JsonPropertyName("networkPerformanceOptions")]
    public V1beta2LaunchTemplateStatusAtProviderNetworkPerformanceOptions? NetworkPerformanceOptions { get; set; }

    /// <summary>The placement of the instance. See Placement below for more details.</summary>
    [JsonPropertyName("placement")]
    public V1beta2LaunchTemplateStatusAtProviderPlacement? Placement { get; set; }

    /// <summary>The options for the instance hostname. The default values are inherited from the subnet. See Private DNS Name Options below for more details.</summary>
    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2LaunchTemplateStatusAtProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The ID of the RAM disk.</summary>
    [JsonPropertyName("ramDiskId")]
    public string? RamDiskId { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Secondary interfaces to associate with instances launched from the template. See Secondary
    /// Interfaces below for more details.
    /// </summary>
    [JsonPropertyName("secondaryInterfaces")]
    public IList<V1beta2LaunchTemplateStatusAtProviderSecondaryInterfaces>? SecondaryInterfaces { get; set; }

    /// <summary>
    /// A list of security group names to associate with. If you are creating Instances in a VPC, use
    /// vpc_security_group_ids instead.
    /// </summary>
    [JsonPropertyName("securityGroupNames")]
    public IList<string>? SecurityGroupNames { get; set; }

    /// <summary>The tags to apply to the resources during launch. See Tag Specifications below for more details. Default tags are currently not propagated to ASG created resources so you may wish to inject your default tags into this variable against the relevant child resource types created.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta2LaunchTemplateStatusAtProviderTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Whether to update Default Version each update. Conflicts with default_version.</summary>
    [JsonPropertyName("updateDefaultVersion")]
    public bool? UpdateDefaultVersion { get; set; }

    /// <summary>The base64-encoded user data to provide when launching the instance.</summary>
    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    /// <summary>A list of security group IDs to associate with. Conflicts with network_interfaces.security_groups</summary>
    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatusConditions
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

/// <summary>LaunchTemplateStatus defines the observed state of LaunchTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2LaunchTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2LaunchTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2LaunchTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>LaunchTemplate is the Schema for the LaunchTemplates API. Provides an EC2 launch template resource. Can be used to create instances or auto scaling groups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2LaunchTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2LaunchTemplateSpec>, IStatus<V1beta2LaunchTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "LaunchTemplate";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "launchtemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LaunchTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LaunchTemplateSpec defines the desired state of LaunchTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2LaunchTemplateSpec Spec { get; set; }

    /// <summary>LaunchTemplateStatus defines the observed state of LaunchTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2LaunchTemplateStatus? Status { get; set; }
}