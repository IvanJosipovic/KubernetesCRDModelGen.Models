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
/// <summary>SpotInstanceRequest is the Schema for the SpotInstanceRequests API. Provides a Spot Instance Request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpotInstanceRequestList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SpotInstanceRequest>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpotInstanceRequestList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "spotinstancerequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpotInstanceRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SpotInstanceRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SpotInstanceRequest> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecDeletionPolicyEnum>))]
public enum V1beta2SpotInstanceRequestSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2SpotInstanceRequestSpecForProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderCpuOptions
{
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderEbsBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderEphemeralBlockDevice
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderLaunchTemplate
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderMetadataOptions
{
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderPrivateDnsNameOptions
{
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderRootBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderSecondaryNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelector
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
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelector
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
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecForProvider
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2SpotInstanceRequestSpecForProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    [JsonPropertyName("cpuOptions")]
    public V1beta2SpotInstanceRequestSpecForProviderCpuOptions? CpuOptions { get; set; }

    [JsonPropertyName("creditSpecification")]
    public V1beta2SpotInstanceRequestSpecForProviderCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2SpotInstanceRequestSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    [JsonPropertyName("enclaveOptions")]
    public V1beta2SpotInstanceRequestSpecForProviderEnclaveOptions? EnclaveOptions { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2SpotInstanceRequestSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates Spot instance behavior when it is interrupted. Valid values are terminate, stop, or hibernate. Default value is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// A launch group is a group of spot instances that launch together and terminate together.
    /// If left empty instances are launched and terminated individually.
    /// </summary>
    [JsonPropertyName("launchGroup")]
    public string? LaunchGroup { get; set; }

    [JsonPropertyName("launchTemplate")]
    public V1beta2SpotInstanceRequestSpecForProviderLaunchTemplate? LaunchTemplate { get; set; }

    [JsonPropertyName("maintenanceOptions")]
    public V1beta2SpotInstanceRequestSpecForProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta2SpotInstanceRequestSpecForProviderMetadataOptions? MetadataOptions { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta2SpotInstanceRequestSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2SpotInstanceRequestSpecForProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public V1beta2SpotInstanceRequestSpecForProviderRootBlockDevice? RootBlockDevice { get; set; }

    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta2SpotInstanceRequestSpecForProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>The maximum price to request on the spot market.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>
    /// If set to one-time, after
    /// the instance is terminated, the spot request will be closed.
    /// </summary>
    [JsonPropertyName("spotType")]
    public string? SpotType { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2SpotInstanceRequestSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. The default end date is 7 days from the current date.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2SpotInstanceRequestSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderCpuOptions
{
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderEbsBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderEphemeralBlockDevice
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderLaunchTemplate
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderMetadataOptions
{
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderPrivateDnsNameOptions
{
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderRootBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderSecondaryNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelector
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
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelector
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
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2SpotInstanceRequestSpecInitProvider
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2SpotInstanceRequestSpecInitProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    [JsonPropertyName("cpuOptions")]
    public V1beta2SpotInstanceRequestSpecInitProviderCpuOptions? CpuOptions { get; set; }

    [JsonPropertyName("creditSpecification")]
    public V1beta2SpotInstanceRequestSpecInitProviderCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2SpotInstanceRequestSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    [JsonPropertyName("enclaveOptions")]
    public V1beta2SpotInstanceRequestSpecInitProviderEnclaveOptions? EnclaveOptions { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2SpotInstanceRequestSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates Spot instance behavior when it is interrupted. Valid values are terminate, stop, or hibernate. Default value is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// A launch group is a group of spot instances that launch together and terminate together.
    /// If left empty instances are launched and terminated individually.
    /// </summary>
    [JsonPropertyName("launchGroup")]
    public string? LaunchGroup { get; set; }

    [JsonPropertyName("launchTemplate")]
    public V1beta2SpotInstanceRequestSpecInitProviderLaunchTemplate? LaunchTemplate { get; set; }

    [JsonPropertyName("maintenanceOptions")]
    public V1beta2SpotInstanceRequestSpecInitProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta2SpotInstanceRequestSpecInitProviderMetadataOptions? MetadataOptions { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta2SpotInstanceRequestSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2SpotInstanceRequestSpecInitProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public V1beta2SpotInstanceRequestSpecInitProviderRootBlockDevice? RootBlockDevice { get; set; }

    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta2SpotInstanceRequestSpecInitProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>The maximum price to request on the spot market.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>
    /// If set to one-time, after
    /// the instance is terminated, the spot request will be closed.
    /// </summary>
    [JsonPropertyName("spotType")]
    public string? SpotType { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdRef")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta2SpotInstanceRequestSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. The default end date is 7 days from the current date.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdRefs")]
    public IList<V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta2SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecManagementPoliciesEnum>))]
public enum V1beta2SpotInstanceRequestSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SpotInstanceRequestSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotInstanceRequestSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SpotInstanceRequestSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotInstanceRequestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotInstanceRequestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotInstanceRequestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SpotInstanceRequestSpec defines the desired state of SpotInstanceRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestSpec
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
    public V1beta2SpotInstanceRequestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SpotInstanceRequestSpecForProvider ForProvider { get; set; }

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
    public V1beta2SpotInstanceRequestSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SpotInstanceRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SpotInstanceRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SpotInstanceRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("capacityReservationTarget")]
    public V1beta2SpotInstanceRequestStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderCpuOptions
{
    [JsonPropertyName("amdSevSnp")]
    public string? AmdSevSnp { get; set; }

    [JsonPropertyName("coreCount")]
    public double? CoreCount { get; set; }

    [JsonPropertyName("nestedVirtualization")]
    public string? NestedVirtualization { get; set; }

    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderEbsBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderEphemeralBlockDevice
{
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("noDevice")]
    public bool? NoDevice { get; set; }

    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderLaunchTemplate
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderMetadataOptions
{
    [JsonPropertyName("httpEndpoint")]
    public string? HttpEndpoint { get; set; }

    [JsonPropertyName("httpProtocolIpv6")]
    public string? HttpProtocolIpv6 { get; set; }

    [JsonPropertyName("httpPutResponseHopLimit")]
    public double? HttpPutResponseHopLimit { get; set; }

    [JsonPropertyName("httpTokens")]
    public string? HttpTokens { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("instanceMetadataTags")]
    public string? InstanceMetadataTags { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderPrimaryNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderPrivateDnsNameOptions
{
    [JsonPropertyName("enableResourceNameDnsARecord")]
    public bool? EnableResourceNameDnsARecord { get; set; }

    [JsonPropertyName("enableResourceNameDnsAaaaRecord")]
    public bool? EnableResourceNameDnsAaaaRecord { get; set; }

    [JsonPropertyName("hostnameType")]
    public string? HostnameType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderRootBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("volumeId")]
    public string? VolumeId { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProviderSecondaryNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("deviceIndex")]
    public double? DeviceIndex { get; set; }

    [JsonPropertyName("interfaceType")]
    public string? InterfaceType { get; set; }

    [JsonPropertyName("macAddress")]
    public string? MacAddress { get; set; }

    [JsonPropertyName("networkCardIndex")]
    public double? NetworkCardIndex { get; set; }

    [JsonPropertyName("privateIpAddressCount")]
    public double? PrivateIpAddressCount { get; set; }

    [JsonPropertyName("privateIpAddresses")]
    public IList<string>? PrivateIpAddresses { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("secondaryInterfaceId")]
    public string? SecondaryInterfaceId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("secondaryNetworkId")]
    public string? SecondaryNetworkId { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("secondarySubnetId")]
    public string? SecondarySubnetId { get; set; }

    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusAtProvider
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta2SpotInstanceRequestStatusAtProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    [JsonPropertyName("cpuOptions")]
    public V1beta2SpotInstanceRequestStatusAtProviderCpuOptions? CpuOptions { get; set; }

    [JsonPropertyName("creditSpecification")]
    public V1beta2SpotInstanceRequestStatusAtProviderCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2SpotInstanceRequestStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    [JsonPropertyName("enclaveOptions")]
    public V1beta2SpotInstanceRequestStatusAtProviderEnclaveOptions? EnclaveOptions { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2SpotInstanceRequestStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("getPasswordData")]
    public bool? GetPasswordData { get; set; }

    [JsonPropertyName("hibernation")]
    public bool? Hibernation { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("hostId")]
    public string? HostId { get; set; }

    [JsonPropertyName("hostResourceGroupArn")]
    public string? HostResourceGroupArn { get; set; }

    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("instanceInitiatedShutdownBehavior")]
    public string? InstanceInitiatedShutdownBehavior { get; set; }

    /// <summary>Indicates Spot instance behavior when it is interrupted. Valid values are terminate, stop, or hibernate. Default value is terminate.</summary>
    [JsonPropertyName("instanceInterruptionBehavior")]
    public string? InstanceInterruptionBehavior { get; set; }

    [JsonPropertyName("instanceState")]
    public string? InstanceState { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("ipv6AddressCount")]
    public double? Ipv6AddressCount { get; set; }

    [JsonPropertyName("ipv6Addresses")]
    public IList<string>? Ipv6Addresses { get; set; }

    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// A launch group is a group of spot instances that launch together and terminate together.
    /// If left empty instances are launched and terminated individually.
    /// </summary>
    [JsonPropertyName("launchGroup")]
    public string? LaunchGroup { get; set; }

    [JsonPropertyName("launchTemplate")]
    public V1beta2SpotInstanceRequestStatusAtProviderLaunchTemplate? LaunchTemplate { get; set; }

    [JsonPropertyName("maintenanceOptions")]
    public V1beta2SpotInstanceRequestStatusAtProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta2SpotInstanceRequestStatusAtProviderMetadataOptions? MetadataOptions { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta2SpotInstanceRequestStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    [JsonPropertyName("passwordData")]
    public string? PasswordData { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    [JsonPropertyName("primaryNetworkInterface")]
    public IList<V1beta2SpotInstanceRequestStatusAtProviderPrimaryNetworkInterface>? PrimaryNetworkInterface { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("primaryNetworkInterfaceId")]
    public string? PrimaryNetworkInterfaceId { get; set; }

    /// <summary>
    /// The private DNS name assigned to the instance. Can only be
    /// used inside the Amazon EC2, and only available if you&apos;ve enabled DNS hostnames
    /// for your VPC
    /// </summary>
    [JsonPropertyName("privateDns")]
    public string? PrivateDns { get; set; }

    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta2SpotInstanceRequestStatusAtProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    /// <summary>
    /// The public DNS name assigned to the instance. For EC2-VPC, this
    /// is only available if you&apos;ve enabled DNS hostnames for your VPC
    /// </summary>
    [JsonPropertyName("publicDns")]
    public string? PublicDns { get; set; }

    /// <summary>The public IP address assigned to the instance, if applicable.</summary>
    [JsonPropertyName("publicIp")]
    public string? PublicIp { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public V1beta2SpotInstanceRequestStatusAtProviderRootBlockDevice? RootBlockDevice { get; set; }

    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta2SpotInstanceRequestStatusAtProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

    [JsonPropertyName("secondaryPrivateIps")]
    public IList<string>? SecondaryPrivateIps { get; set; }

    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    [JsonPropertyName("sourceDestCheck")]
    public bool? SourceDestCheck { get; set; }

    /// <summary>
    /// The current bid
    /// status
    /// of the Spot Instance Request.
    /// </summary>
    [JsonPropertyName("spotBidStatus")]
    public string? SpotBidStatus { get; set; }

    /// <summary>
    /// The Instance ID (if any) that is currently fulfilling
    /// the Spot Instance request.
    /// </summary>
    [JsonPropertyName("spotInstanceId")]
    public string? SpotInstanceId { get; set; }

    /// <summary>The maximum price to request on the spot market.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>
    /// The current request
    /// state
    /// of the Spot Instance Request.
    /// </summary>
    [JsonPropertyName("spotRequestState")]
    public string? SpotRequestState { get; set; }

    /// <summary>
    /// If set to one-time, after
    /// the instance is terminated, the spot request will be closed.
    /// </summary>
    [JsonPropertyName("spotType")]
    public string? SpotType { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    [JsonPropertyName("tenancy")]
    public string? Tenancy { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("userDataBase64")]
    public string? UserDataBase64 { get; set; }

    [JsonPropertyName("userDataReplaceOnChange")]
    public bool? UserDataReplaceOnChange { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request. The default end date is 7 days from the current date.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("volumeTags")]
    public IDictionary<string, string>? VolumeTags { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatusConditions
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

/// <summary>SpotInstanceRequestStatus defines the observed state of SpotInstanceRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotInstanceRequestStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SpotInstanceRequestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SpotInstanceRequestStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpotInstanceRequest is the Schema for the SpotInstanceRequests API. Provides a Spot Instance Request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpotInstanceRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SpotInstanceRequestSpec>, IStatus<V1beta2SpotInstanceRequestStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpotInstanceRequest";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "spotinstancerequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpotInstanceRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpotInstanceRequestSpec defines the desired state of SpotInstanceRequest</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SpotInstanceRequestSpec Spec { get; set; }

    /// <summary>SpotInstanceRequestStatus defines the observed state of SpotInstanceRequest.</summary>
    [JsonPropertyName("status")]
    public V1beta2SpotInstanceRequestStatus? Status { get; set; }
}