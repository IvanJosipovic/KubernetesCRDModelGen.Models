#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ec2.aws.m.upbound.io;
/// <summary>SpotInstanceRequest is the Schema for the SpotInstanceRequests API. Provides a Spot Instance Request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1SpotInstanceRequestList : IKubernetesObject<V1ListMeta>, IItems<V1beta1SpotInstanceRequest>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpotInstanceRequestList";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "spotinstancerequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpotInstanceRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1SpotInstanceRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1SpotInstanceRequest> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("capacityReservationTarget")]
    public V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderCpuOptions
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
public partial class V1beta1SpotInstanceRequestSpecForProviderCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderEbsBlockDevice
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
public partial class V1beta1SpotInstanceRequestSpecForProviderEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderEphemeralBlockDevice
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
public partial class V1beta1SpotInstanceRequestSpecForProviderLaunchTemplate
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
public partial class V1beta1SpotInstanceRequestSpecForProviderMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderMetadataOptions
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
public partial class V1beta1SpotInstanceRequestSpecForProviderNetworkInterface
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
public partial class V1beta1SpotInstanceRequestSpecForProviderPrivateDnsNameOptions
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
public partial class V1beta1SpotInstanceRequestSpecForProviderRootBlockDevice
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
public partial class V1beta1SpotInstanceRequestSpecForProviderSecondaryNetworkInterface
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelector
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
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelector
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
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecForProvider
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta1SpotInstanceRequestSpecForProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    [JsonPropertyName("cpuOptions")]
    public V1beta1SpotInstanceRequestSpecForProviderCpuOptions? CpuOptions { get; set; }

    [JsonPropertyName("creditSpecification")]
    public V1beta1SpotInstanceRequestSpecForProviderCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    [JsonPropertyName("enclaveOptions")]
    public V1beta1SpotInstanceRequestSpecForProviderEnclaveOptions? EnclaveOptions { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

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
    public V1beta1SpotInstanceRequestSpecForProviderLaunchTemplate? LaunchTemplate { get; set; }

    [JsonPropertyName("maintenanceOptions")]
    public V1beta1SpotInstanceRequestSpecForProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1SpotInstanceRequestSpecForProviderMetadataOptions? MetadataOptions { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta1SpotInstanceRequestSpecForProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

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
    public V1beta1SpotInstanceRequestSpecForProviderRootBlockDevice? RootBlockDevice { get; set; }

    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta1SpotInstanceRequestSpecForProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

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
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1SpotInstanceRequestSpecForProviderSubnetIdSelector? SubnetIdSelector { get; set; }

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
    public IList<V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1SpotInstanceRequestSpecForProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("capacityReservationTarget")]
    public V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderCpuOptions
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderEbsBlockDevice
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderEphemeralBlockDevice
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderLaunchTemplate
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderMetadataOptions
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderNetworkInterface
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderPrivateDnsNameOptions
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderRootBlockDevice
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
public partial class V1beta1SpotInstanceRequestSpecInitProviderSecondaryNetworkInterface
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelector
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
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum>))]
public enum V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelector
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
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1SpotInstanceRequestSpecInitProvider
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("capacityReservationSpecification")]
    public V1beta1SpotInstanceRequestSpecInitProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    [JsonPropertyName("cpuOptions")]
    public V1beta1SpotInstanceRequestSpecInitProviderCpuOptions? CpuOptions { get; set; }

    [JsonPropertyName("creditSpecification")]
    public V1beta1SpotInstanceRequestSpecInitProviderCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    [JsonPropertyName("enclaveOptions")]
    public V1beta1SpotInstanceRequestSpecInitProviderEnclaveOptions? EnclaveOptions { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

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
    public V1beta1SpotInstanceRequestSpecInitProviderLaunchTemplate? LaunchTemplate { get; set; }

    [JsonPropertyName("maintenanceOptions")]
    public V1beta1SpotInstanceRequestSpecInitProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1SpotInstanceRequestSpecInitProviderMetadataOptions? MetadataOptions { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("placementGroupId")]
    public string? PlacementGroupId { get; set; }

    [JsonPropertyName("placementPartitionNumber")]
    public double? PlacementPartitionNumber { get; set; }

    [JsonPropertyName("privateDnsNameOptions")]
    public V1beta1SpotInstanceRequestSpecInitProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

    /// <summary>The private IP address assigned to the instance</summary>
    [JsonPropertyName("privateIp")]
    public string? PrivateIp { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public V1beta1SpotInstanceRequestSpecInitProviderRootBlockDevice? RootBlockDevice { get; set; }

    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta1SpotInstanceRequestSpecInitProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

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
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdRef? SubnetIdRef { get; set; }

    /// <summary>Selector for a Subnet in ec2 to populate subnetId.</summary>
    [JsonPropertyName("subnetIdSelector")]
    public V1beta1SpotInstanceRequestSpecInitProviderSubnetIdSelector? SubnetIdSelector { get; set; }

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
    public IList<V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdRefs>? VpcSecurityGroupIdRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate vpcSecurityGroupIds.</summary>
    [JsonPropertyName("vpcSecurityGroupIdSelector")]
    public V1beta1SpotInstanceRequestSpecInitProviderVpcSecurityGroupIdSelector? VpcSecurityGroupIdSelector { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1SpotInstanceRequestSpecManagementPoliciesEnum>))]
public enum V1beta1SpotInstanceRequestSpecManagementPoliciesEnum
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
public partial class V1beta1SpotInstanceRequestSpecProviderConfigRef
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
public partial class V1beta1SpotInstanceRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SpotInstanceRequestSpec defines the desired state of SpotInstanceRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1SpotInstanceRequestSpecForProvider ForProvider { get; set; }

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
    public V1beta1SpotInstanceRequestSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1SpotInstanceRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1SpotInstanceRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1SpotInstanceRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget
{
    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("capacityReservationId")]
    public string? CapacityReservationId { get; set; }

    [JsonPropertyName("capacityReservationResourceGroupArn")]
    public string? CapacityReservationResourceGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecification
{
    [JsonPropertyName("capacityReservationPreference")]
    public string? CapacityReservationPreference { get; set; }

    [JsonPropertyName("capacityReservationTarget")]
    public V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderCpuOptions
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderCreditSpecification
{
    [JsonPropertyName("cpuCredits")]
    public string? CpuCredits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderEbsBlockDevice
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderEnclaveOptions
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderEphemeralBlockDevice
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderLaunchTemplate
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderMaintenanceOptions
{
    [JsonPropertyName("autoRecovery")]
    public string? AutoRecovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderMetadataOptions
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderNetworkInterface
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderPrimaryNetworkInterface
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The Spot Instance Request ID.</summary>
    [JsonPropertyName("networkInterfaceId")]
    public string? NetworkInterfaceId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1SpotInstanceRequestStatusAtProviderPrivateDnsNameOptions
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderRootBlockDevice
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
public partial class V1beta1SpotInstanceRequestStatusAtProviderSecondaryNetworkInterface
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
public partial class V1beta1SpotInstanceRequestStatusAtProvider
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
    public V1beta1SpotInstanceRequestStatusAtProviderCapacityReservationSpecification? CapacityReservationSpecification { get; set; }

    [JsonPropertyName("cpuOptions")]
    public V1beta1SpotInstanceRequestStatusAtProviderCpuOptions? CpuOptions { get; set; }

    [JsonPropertyName("creditSpecification")]
    public V1beta1SpotInstanceRequestStatusAtProviderCreditSpecification? CreditSpecification { get; set; }

    [JsonPropertyName("disableApiStop")]
    public bool? DisableApiStop { get; set; }

    [JsonPropertyName("disableApiTermination")]
    public bool? DisableApiTermination { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("enablePrimaryIpv6")]
    public bool? EnablePrimaryIpv6 { get; set; }

    [JsonPropertyName("enclaveOptions")]
    public V1beta1SpotInstanceRequestStatusAtProviderEnclaveOptions? EnclaveOptions { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

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
    public V1beta1SpotInstanceRequestStatusAtProviderLaunchTemplate? LaunchTemplate { get; set; }

    [JsonPropertyName("maintenanceOptions")]
    public V1beta1SpotInstanceRequestStatusAtProviderMaintenanceOptions? MaintenanceOptions { get; set; }

    [JsonPropertyName("metadataOptions")]
    public V1beta1SpotInstanceRequestStatusAtProviderMetadataOptions? MetadataOptions { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("networkInterface")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

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
    public IList<V1beta1SpotInstanceRequestStatusAtProviderPrimaryNetworkInterface>? PrimaryNetworkInterface { get; set; }

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
    public V1beta1SpotInstanceRequestStatusAtProviderPrivateDnsNameOptions? PrivateDnsNameOptions { get; set; }

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
    public V1beta1SpotInstanceRequestStatusAtProviderRootBlockDevice? RootBlockDevice { get; set; }

    [JsonPropertyName("secondaryNetworkInterface")]
    public IList<V1beta1SpotInstanceRequestStatusAtProviderSecondaryNetworkInterface>? SecondaryNetworkInterface { get; set; }

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
public partial class V1beta1SpotInstanceRequestStatusConditions
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
public partial class V1beta1SpotInstanceRequestStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1SpotInstanceRequestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1SpotInstanceRequestStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1SpotInstanceRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1SpotInstanceRequestSpec>, IStatus<V1beta1SpotInstanceRequestStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "SpotInstanceRequest";
    public const string KubeGroup = "ec2.aws.m.upbound.io";
    public const string KubePluralName = "spotinstancerequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpotInstanceRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpotInstanceRequestSpec defines the desired state of SpotInstanceRequest</summary>
    [JsonPropertyName("spec")]
    public required V1beta1SpotInstanceRequestSpec Spec { get; set; }

    /// <summary>SpotInstanceRequestStatus defines the observed state of SpotInstanceRequest.</summary>
    [JsonPropertyName("status")]
    public V1beta1SpotInstanceRequestStatus? Status { get; set; }
}