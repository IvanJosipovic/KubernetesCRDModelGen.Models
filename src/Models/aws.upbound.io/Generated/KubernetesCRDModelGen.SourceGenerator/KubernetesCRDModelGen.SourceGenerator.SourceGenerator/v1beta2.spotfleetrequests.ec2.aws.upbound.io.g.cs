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
/// <summary>SpotFleetRequest is the Schema for the SpotFleetRequests API. Provides a Spot Fleet Request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpotFleetRequestList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SpotFleetRequest>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpotFleetRequestList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "spotfleetrequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpotFleetRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SpotFleetRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SpotFleetRequest> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecDeletionPolicyEnum>))]
public enum V1beta2SpotFleetRequestSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationEbsBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationEphemeralBlockDevice
{
    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelector
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
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationRootBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchSpecification
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>takes aws_iam_instance_profile attribute arn as input.</summary>
    [JsonPropertyName("iamInstanceProfileArn")]
    public string? IamInstanceProfileArn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnRef")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnRef? IamInstanceProfileArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnSelector")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationIamInstanceProfileArnSelector? IamInstanceProfileArnSelector { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta2SpotFleetRequestSpecForProviderLaunchSpecificationRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector
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
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector
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
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector? IdSelector { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Unlike the autoscaling equivalent, does not support $Latest or $Default, so use the launch_template resource&apos;s attribute, e.g., &quot;${aws_launch_template.foo.latest_version}&quot;. It will use the default version if omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector? VersionSelector { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb
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
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The instance requirements. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

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
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

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

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverrides
{
    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The instance requirements. See below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverridesInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The priority for the launch template override. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfig
{
    /// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>One or more override configurations. See Overrides below for more details.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfigOverrides>? Overrides { get; set; }
}

/// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderSpotMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for spot fleets with fleet_type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }
}

/// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProviderSpotMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public V1beta2SpotFleetRequestSpecForProviderSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecForProvider
{
    /// <summary>
    /// Indicates how to allocate the target capacity across
    /// the Spot pools specified by the Spot fleet request. Valid values: lowestPrice, diversified, capacityOptimized, capacityOptimizedPrioritized, and priceCapacityOptimized. The default is
    /// lowestPrice.
    /// </summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated if the target capacity of the Spot fleet
    /// request is decreased below the current size of the Spot fleet.
    /// </summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>
    /// The type of fleet request. Indicates whether the Spot Fleet only requests the target
    /// capacity or also attempts to maintain it. Default is maintain.
    /// </summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>
    /// Grants the Spot fleet permission to terminate
    /// Spot instances on your behalf when you cancel its Spot fleet request using
    /// CancelSpotFleetRequests or when the Spot fleet request expires, if you set
    /// terminateInstancesWithExpiration.
    /// </summary>
    [JsonPropertyName("iamFleetRole")]
    public string? IamFleetRole { get; set; }

    /// <summary>
    /// Indicates whether a Spot
    /// instance stops or terminates when it is interrupted. Default is
    /// terminate.
    /// </summary>
    [JsonPropertyName("instanceInterruptionBehaviour")]
    public string? InstanceInterruptionBehaviour { get; set; }

    /// <summary>
    /// The number of Spot pools across which to allocate your target Spot capacity.
    /// Valid only when allocation_strategy is set to lowestPrice. Spot Fleet selects
    /// the cheapest Spot pools and evenly allocates your target Spot capacity across
    /// the number of Spot pools that you specify.
    /// </summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// Used to define the launch configuration of the
    /// spot-fleet request. Can be specified multiple times to define different bids
    /// across different markets and instance types. Conflicts with launch_template_config. At least one of launch_specification or launch_template_config is required.
    /// </summary>
    [JsonPropertyName("launchSpecification")]
    public IList<V1beta2SpotFleetRequestSpecForProviderLaunchSpecification>? LaunchSpecification { get; set; }

    /// <summary>Launch template configuration block. See Launch Template Configs below for more details. Conflicts with launch_specification. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta2SpotFleetRequestSpecForProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>A list of elastic load balancer names to add to the Spot fleet.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. the possible values are: lowestPrice and prioritized. the default is lowestPrice.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you&apos;re willing to pay. When the maximum amount you&apos;re willing to pay is reached, the fleet stops launching instances even if it hasn’t met the target capacity.</summary>
    [JsonPropertyName("onDemandMaxTotalPrice")]
    public string? OnDemandMaxTotalPrice { get; set; }

    /// <summary>The number of On-Demand units to request. If the request type is maintain, you can specify a target capacity of 0 and add capacity later.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Indicates whether Spot fleet should replace unhealthy instances. Default false.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("spotMaintenanceStrategies")]
    public V1beta2SpotFleetRequestSpecForProviderSpotMaintenanceStrategies? SpotMaintenanceStrategies { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The number of units to request. You can choose to set the
    /// target capacity in terms of instances or a performance characteristic that is
    /// important to your application workload, such as vCPUs, memory, or I/O.
    /// </summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. This can only be done with instance_requirements defined</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>A list of aws_alb_target_group ARNs, for use with Application Load Balancing.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated when the resource is deleted (and the Spot fleet request cancelled).
    /// If no value is specified, the value of the terminate_instances_with_expiration argument is used.
    /// </summary>
    [JsonPropertyName("terminateInstancesOnDelete")]
    public string? TerminateInstancesOnDelete { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated when the Spot fleet request expires.
    /// </summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationEbsBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationEphemeralBlockDevice
{
    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelector
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
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationRootBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchSpecification
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>takes aws_iam_instance_profile attribute arn as input.</summary>
    [JsonPropertyName("iamInstanceProfileArn")]
    public string? IamInstanceProfileArn { get; set; }

    /// <summary>Reference to a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnRef")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnRef? IamInstanceProfileArnRef { get; set; }

    /// <summary>Selector for a InstanceProfile in iam to populate iamInstanceProfileArn.</summary>
    [JsonPropertyName("iamInstanceProfileArnSelector")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationIamInstanceProfileArnSelector? IamInstanceProfileArnSelector { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecificationRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector
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
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector
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
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelectorPolicy? Policy { get; set; }
}

/// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idRef")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdRef? IdRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate id.</summary>
    [JsonPropertyName("idSelector")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationIdSelector? IdSelector { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Unlike the autoscaling equivalent, does not support $Latest or $Default, so use the launch_template resource&apos;s attribute, e.g., &quot;${aws_launch_template.foo.latest_version}&quot;. It will use the default version if omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>Reference to a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionRef? VersionRef { get; set; }

    /// <summary>Selector for a LaunchTemplate in ec2 to populate version.</summary>
    [JsonPropertyName("versionSelector")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecificationVersionSelector? VersionSelector { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb
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
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The instance requirements. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

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
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

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

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverrides
{
    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The instance requirements. See below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverridesInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The priority for the launch template override. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfig
{
    /// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>One or more override configurations. See Overrides below for more details.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfigOverrides>? Overrides { get; set; }
}

/// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderSpotMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for spot fleets with fleet_type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }
}

/// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecInitProviderSpotMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public V1beta2SpotFleetRequestSpecInitProviderSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance { get; set; }
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
public partial class V1beta2SpotFleetRequestSpecInitProvider
{
    /// <summary>
    /// Indicates how to allocate the target capacity across
    /// the Spot pools specified by the Spot fleet request. Valid values: lowestPrice, diversified, capacityOptimized, capacityOptimizedPrioritized, and priceCapacityOptimized. The default is
    /// lowestPrice.
    /// </summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated if the target capacity of the Spot fleet
    /// request is decreased below the current size of the Spot fleet.
    /// </summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>
    /// The type of fleet request. Indicates whether the Spot Fleet only requests the target
    /// capacity or also attempts to maintain it. Default is maintain.
    /// </summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>
    /// Grants the Spot fleet permission to terminate
    /// Spot instances on your behalf when you cancel its Spot fleet request using
    /// CancelSpotFleetRequests or when the Spot fleet request expires, if you set
    /// terminateInstancesWithExpiration.
    /// </summary>
    [JsonPropertyName("iamFleetRole")]
    public string? IamFleetRole { get; set; }

    /// <summary>
    /// Indicates whether a Spot
    /// instance stops or terminates when it is interrupted. Default is
    /// terminate.
    /// </summary>
    [JsonPropertyName("instanceInterruptionBehaviour")]
    public string? InstanceInterruptionBehaviour { get; set; }

    /// <summary>
    /// The number of Spot pools across which to allocate your target Spot capacity.
    /// Valid only when allocation_strategy is set to lowestPrice. Spot Fleet selects
    /// the cheapest Spot pools and evenly allocates your target Spot capacity across
    /// the number of Spot pools that you specify.
    /// </summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// Used to define the launch configuration of the
    /// spot-fleet request. Can be specified multiple times to define different bids
    /// across different markets and instance types. Conflicts with launch_template_config. At least one of launch_specification or launch_template_config is required.
    /// </summary>
    [JsonPropertyName("launchSpecification")]
    public IList<V1beta2SpotFleetRequestSpecInitProviderLaunchSpecification>? LaunchSpecification { get; set; }

    /// <summary>Launch template configuration block. See Launch Template Configs below for more details. Conflicts with launch_specification. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta2SpotFleetRequestSpecInitProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>A list of elastic load balancer names to add to the Spot fleet.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. the possible values are: lowestPrice and prioritized. the default is lowestPrice.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you&apos;re willing to pay. When the maximum amount you&apos;re willing to pay is reached, the fleet stops launching instances even if it hasn’t met the target capacity.</summary>
    [JsonPropertyName("onDemandMaxTotalPrice")]
    public string? OnDemandMaxTotalPrice { get; set; }

    /// <summary>The number of On-Demand units to request. If the request type is maintain, you can specify a target capacity of 0 and add capacity later.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>Indicates whether Spot fleet should replace unhealthy instances. Default false.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("spotMaintenanceStrategies")]
    public V1beta2SpotFleetRequestSpecInitProviderSpotMaintenanceStrategies? SpotMaintenanceStrategies { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// The number of units to request. You can choose to set the
    /// target capacity in terms of instances or a performance characteristic that is
    /// important to your application workload, such as vCPUs, memory, or I/O.
    /// </summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. This can only be done with instance_requirements defined</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>A list of aws_alb_target_group ARNs, for use with Application Load Balancing.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated when the resource is deleted (and the Spot fleet request cancelled).
    /// If no value is specified, the value of the terminate_instances_with_expiration argument is used.
    /// </summary>
    [JsonPropertyName("terminateInstancesOnDelete")]
    public string? TerminateInstancesOnDelete { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated when the Spot fleet request expires.
    /// </summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecManagementPoliciesEnum>))]
public enum V1beta2SpotFleetRequestSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SpotFleetRequestSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SpotFleetRequestSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SpotFleetRequestSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SpotFleetRequestSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SpotFleetRequestSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SpotFleetRequestSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SpotFleetRequestSpec defines the desired state of SpotFleetRequest</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestSpec
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
    public V1beta2SpotFleetRequestSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SpotFleetRequestSpecForProvider ForProvider { get; set; }

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
    public V1beta2SpotFleetRequestSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SpotFleetRequestSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SpotFleetRequestSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SpotFleetRequestSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchSpecificationEbsBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchSpecificationEphemeralBlockDevice
{
    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("virtualName")]
    public string? VirtualName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchSpecificationRootBlockDevice
{
    [JsonPropertyName("deleteOnTermination")]
    public bool? DeleteOnTermination { get; set; }

    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    [JsonPropertyName("volumeSize")]
    public double? VolumeSize { get; set; }

    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchSpecification
{
    [JsonPropertyName("ami")]
    public string? Ami { get; set; }

    [JsonPropertyName("associatePublicIpAddress")]
    public bool? AssociatePublicIpAddress { get; set; }

    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("ebsBlockDevice")]
    public IList<V1beta2SpotFleetRequestStatusAtProviderLaunchSpecificationEbsBlockDevice>? EbsBlockDevice { get; set; }

    [JsonPropertyName("ebsOptimized")]
    public bool? EbsOptimized { get; set; }

    [JsonPropertyName("ephemeralBlockDevice")]
    public IList<V1beta2SpotFleetRequestStatusAtProviderLaunchSpecificationEphemeralBlockDevice>? EphemeralBlockDevice { get; set; }

    [JsonPropertyName("iamInstanceProfile")]
    public string? IamInstanceProfile { get; set; }

    /// <summary>takes aws_iam_instance_profile attribute arn as input.</summary>
    [JsonPropertyName("iamInstanceProfileArn")]
    public string? IamInstanceProfileArn { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    [JsonPropertyName("monitoring")]
    public bool? Monitoring { get; set; }

    [JsonPropertyName("placementGroup")]
    public string? PlacementGroup { get; set; }

    [JsonPropertyName("placementTenancy")]
    public string? PlacementTenancy { get; set; }

    [JsonPropertyName("rootBlockDevice")]
    public IList<V1beta2SpotFleetRequestStatusAtProviderLaunchSpecificationRootBlockDevice>? RootBlockDevice { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("userData")]
    public string? UserData { get; set; }

    [JsonPropertyName("vpcSecurityGroupIds")]
    public IList<string>? VpcSecurityGroupIds { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public string? WeightedCapacity { get; set; }
}

/// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigLaunchTemplateSpecification
{
    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The name of the launch template. Conflicts with id.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Template version. Unlike the autoscaling equivalent, does not support $Latest or $Default, so use the launch_template resource&apos;s attribute, e.g., &quot;${aws_launch_template.foo.latest_version}&quot;. It will use the default version if omitted.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb
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
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount
{
    /// <summary>Maximum.</summary>
    [JsonPropertyName("max")]
    public double? Max { get; set; }

    /// <summary>Minimum.</summary>
    [JsonPropertyName("min")]
    public double? Min { get; set; }
}

/// <summary>The instance requirements. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirements
{
    /// <summary>Block describing the minimum and maximum number of accelerators (GPUs, FPGAs, or AWS Inferentia chips). Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorCount")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorCount? AcceleratorCount { get; set; }

    /// <summary>List of accelerator manufacturer names. Default is any manufacturer.</summary>
    [JsonPropertyName("acceleratorManufacturers")]
    public IList<string>? AcceleratorManufacturers { get; set; }

    /// <summary>List of accelerator names. Default is any acclerator.</summary>
    [JsonPropertyName("acceleratorNames")]
    public IList<string>? AcceleratorNames { get; set; }

    /// <summary>Block describing the minimum and maximum total memory of the accelerators. Default is no minimum or maximum.</summary>
    [JsonPropertyName("acceleratorTotalMemoryMib")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsAcceleratorTotalMemoryMib? AcceleratorTotalMemoryMib { get; set; }

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
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsBaselineEbsBandwidthMbps? BaselineEbsBandwidthMbps { get; set; }

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

    /// <summary>Block describing the minimum and maximum amount of memory (GiB) per vCPU. Default is no minimum or maximum.</summary>
    [JsonPropertyName("memoryGibPerVcpu")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryGibPerVcpu? MemoryGibPerVcpu { get; set; }

    /// <summary>Block describing the minimum and maximum amount of memory (MiB). Default is no maximum.</summary>
    [JsonPropertyName("memoryMib")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsMemoryMib? MemoryMib { get; set; }

    /// <summary>Block describing the minimum and maximum amount of network bandwidth, in gigabits per second (Gbps). Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkBandwidthGbps")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkBandwidthGbps? NetworkBandwidthGbps { get; set; }

    /// <summary>Block describing the minimum and maximum number of network interfaces. Default is no minimum or maximum.</summary>
    [JsonPropertyName("networkInterfaceCount")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsNetworkInterfaceCount? NetworkInterfaceCount { get; set; }

    /// <summary>The price protection threshold for On-Demand Instances. This is the maximum you’ll pay for an On-Demand Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 20.</summary>
    [JsonPropertyName("onDemandMaxPricePercentageOverLowestPrice")]
    public double? OnDemandMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Indicate whether instance types must support On-Demand Instance Hibernation, either true or false. Default is false.</summary>
    [JsonPropertyName("requireHibernateSupport")]
    public bool? RequireHibernateSupport { get; set; }

    /// <summary>The price protection threshold for Spot Instances. This is the maximum you’ll pay for a Spot Instance, expressed as a percentage higher than the cheapest M, C, or R instance type with your specified attributes. When Amazon EC2 Auto Scaling selects instance types with your attributes, we will exclude instance types whose price is higher than your threshold. The parameter accepts an integer, which Amazon EC2 Auto Scaling interprets as a percentage. To turn off price protection, specify a high value, such as 999999. Default is 100.</summary>
    [JsonPropertyName("spotMaxPricePercentageOverLowestPrice")]
    public double? SpotMaxPricePercentageOverLowestPrice { get; set; }

    /// <summary>Block describing the minimum and maximum total local storage (GB). Default is no minimum or maximum.</summary>
    [JsonPropertyName("totalLocalStorageGb")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsTotalLocalStorageGb? TotalLocalStorageGb { get; set; }

    /// <summary>Block describing the minimum and maximum number of vCPUs. Default is no maximum.</summary>
    [JsonPropertyName("vcpuCount")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirementsVcpuCount? VcpuCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverrides
{
    /// <summary>The availability zone in which to place the request.</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>The instance requirements. See below.</summary>
    [JsonPropertyName("instanceRequirements")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverridesInstanceRequirements? InstanceRequirements { get; set; }

    /// <summary>The type of instance to request.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>The priority for the launch template override. The lower the number, the higher the priority. If no number is set, the launch template override has the lowest priority.</summary>
    [JsonPropertyName("priority")]
    public double? Priority { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The subnet in which to launch the requested instance.</summary>
    [JsonPropertyName("subnetId")]
    public string? SubnetId { get; set; }

    /// <summary>The capacity added to the fleet by a fulfilled request.</summary>
    [JsonPropertyName("weightedCapacity")]
    public double? WeightedCapacity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfig
{
    /// <summary>Launch template specification. See Launch Template Specification below for more details.</summary>
    [JsonPropertyName("launchTemplateSpecification")]
    public V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigLaunchTemplateSpecification? LaunchTemplateSpecification { get; set; }

    /// <summary>One or more override configurations. See Overrides below for more details.</summary>
    [JsonPropertyName("overrides")]
    public IList<V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfigOverrides>? Overrides { get; set; }
}

/// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderSpotMaintenanceStrategiesCapacityRebalance
{
    /// <summary>The replacement strategy to use. Only available for spot fleets with fleet_type set to maintain. Valid values: launch.</summary>
    [JsonPropertyName("replacementStrategy")]
    public string? ReplacementStrategy { get; set; }
}

/// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProviderSpotMaintenanceStrategies
{
    /// <summary>Nested argument containing the capacity rebalance for your fleet request. Defined below.</summary>
    [JsonPropertyName("capacityRebalance")]
    public V1beta2SpotFleetRequestStatusAtProviderSpotMaintenanceStrategiesCapacityRebalance? CapacityRebalance { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusAtProvider
{
    /// <summary>
    /// Indicates how to allocate the target capacity across
    /// the Spot pools specified by the Spot fleet request. Valid values: lowestPrice, diversified, capacityOptimized, capacityOptimizedPrioritized, and priceCapacityOptimized. The default is
    /// lowestPrice.
    /// </summary>
    [JsonPropertyName("allocationStrategy")]
    public string? AllocationStrategy { get; set; }

    [JsonPropertyName("clientToken")]
    public string? ClientToken { get; set; }

    /// <summary>Reserved.</summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated if the target capacity of the Spot fleet
    /// request is decreased below the current size of the Spot fleet.
    /// </summary>
    [JsonPropertyName("excessCapacityTerminationPolicy")]
    public string? ExcessCapacityTerminationPolicy { get; set; }

    /// <summary>
    /// The type of fleet request. Indicates whether the Spot Fleet only requests the target
    /// capacity or also attempts to maintain it. Default is maintain.
    /// </summary>
    [JsonPropertyName("fleetType")]
    public string? FleetType { get; set; }

    /// <summary>
    /// Grants the Spot fleet permission to terminate
    /// Spot instances on your behalf when you cancel its Spot fleet request using
    /// CancelSpotFleetRequests or when the Spot fleet request expires, if you set
    /// terminateInstancesWithExpiration.
    /// </summary>
    [JsonPropertyName("iamFleetRole")]
    public string? IamFleetRole { get; set; }

    /// <summary>The ID of the launch template. Conflicts with name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Indicates whether a Spot
    /// instance stops or terminates when it is interrupted. Default is
    /// terminate.
    /// </summary>
    [JsonPropertyName("instanceInterruptionBehaviour")]
    public string? InstanceInterruptionBehaviour { get; set; }

    /// <summary>
    /// The number of Spot pools across which to allocate your target Spot capacity.
    /// Valid only when allocation_strategy is set to lowestPrice. Spot Fleet selects
    /// the cheapest Spot pools and evenly allocates your target Spot capacity across
    /// the number of Spot pools that you specify.
    /// </summary>
    [JsonPropertyName("instancePoolsToUseCount")]
    public double? InstancePoolsToUseCount { get; set; }

    /// <summary>
    /// Used to define the launch configuration of the
    /// spot-fleet request. Can be specified multiple times to define different bids
    /// across different markets and instance types. Conflicts with launch_template_config. At least one of launch_specification or launch_template_config is required.
    /// </summary>
    [JsonPropertyName("launchSpecification")]
    public IList<V1beta2SpotFleetRequestStatusAtProviderLaunchSpecification>? LaunchSpecification { get; set; }

    /// <summary>Launch template configuration block. See Launch Template Configs below for more details. Conflicts with launch_specification. At least one of launch_specification or launch_template_config is required.</summary>
    [JsonPropertyName("launchTemplateConfig")]
    public IList<V1beta2SpotFleetRequestStatusAtProviderLaunchTemplateConfig>? LaunchTemplateConfig { get; set; }

    /// <summary>A list of elastic load balancer names to add to the Spot fleet.</summary>
    [JsonPropertyName("loadBalancers")]
    public IList<string>? LoadBalancers { get; set; }

    /// <summary>The order of the launch template overrides to use in fulfilling On-Demand capacity. the possible values are: lowestPrice and prioritized. the default is lowestPrice.</summary>
    [JsonPropertyName("onDemandAllocationStrategy")]
    public string? OnDemandAllocationStrategy { get; set; }

    /// <summary>The maximum amount per hour for On-Demand Instances that you&apos;re willing to pay. When the maximum amount you&apos;re willing to pay is reached, the fleet stops launching instances even if it hasn’t met the target capacity.</summary>
    [JsonPropertyName("onDemandMaxTotalPrice")]
    public string? OnDemandMaxTotalPrice { get; set; }

    /// <summary>The number of On-Demand units to request. If the request type is maintain, you can specify a target capacity of 0 and add capacity later.</summary>
    [JsonPropertyName("onDemandTargetCapacity")]
    public double? OnDemandTargetCapacity { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Indicates whether Spot fleet should replace unhealthy instances. Default false.</summary>
    [JsonPropertyName("replaceUnhealthyInstances")]
    public bool? ReplaceUnhealthyInstances { get; set; }

    /// <summary>Nested argument containing maintenance strategies for managing your Spot Instances that are at an elevated risk of being interrupted. Defined below.</summary>
    [JsonPropertyName("spotMaintenanceStrategies")]
    public V1beta2SpotFleetRequestStatusAtProviderSpotMaintenanceStrategies? SpotMaintenanceStrategies { get; set; }

    /// <summary>The maximum bid price per unit hour.</summary>
    [JsonPropertyName("spotPrice")]
    public string? SpotPrice { get; set; }

    /// <summary>The state of the Spot fleet request.</summary>
    [JsonPropertyName("spotRequestState")]
    public string? SpotRequestState { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>
    /// The number of units to request. You can choose to set the
    /// target capacity in terms of instances or a performance characteristic that is
    /// important to your application workload, such as vCPUs, memory, or I/O.
    /// </summary>
    [JsonPropertyName("targetCapacity")]
    public double? TargetCapacity { get; set; }

    /// <summary>The unit for the target capacity. This can only be done with instance_requirements defined</summary>
    [JsonPropertyName("targetCapacityUnitType")]
    public string? TargetCapacityUnitType { get; set; }

    /// <summary>A list of aws_alb_target_group ARNs, for use with Application Load Balancing.</summary>
    [JsonPropertyName("targetGroupArns")]
    public IList<string>? TargetGroupArns { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated when the resource is deleted (and the Spot fleet request cancelled).
    /// If no value is specified, the value of the terminate_instances_with_expiration argument is used.
    /// </summary>
    [JsonPropertyName("terminateInstancesOnDelete")]
    public string? TerminateInstancesOnDelete { get; set; }

    /// <summary>
    /// Indicates whether running Spot
    /// instances should be terminated when the Spot fleet request expires.
    /// </summary>
    [JsonPropertyName("terminateInstancesWithExpiration")]
    public bool? TerminateInstancesWithExpiration { get; set; }

    /// <summary>The start date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). The default is to start fulfilling the request immediately.</summary>
    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    /// <summary>The end date and time of the request, in UTC RFC3339 format(for example, YYYY-MM-DDTHH:MM:SSZ). At this point, no new Spot instance requests are placed or enabled to fulfill the request.</summary>
    [JsonPropertyName("validUntil")]
    public string? ValidUntil { get; set; }

    [JsonPropertyName("waitForFulfillment")]
    public bool? WaitForFulfillment { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatusConditions
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

/// <summary>SpotFleetRequestStatus defines the observed state of SpotFleetRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SpotFleetRequestStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SpotFleetRequestStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SpotFleetRequestStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SpotFleetRequest is the Schema for the SpotFleetRequests API. Provides a Spot Fleet Request resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SpotFleetRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SpotFleetRequestSpec>, IStatus<V1beta2SpotFleetRequestStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SpotFleetRequest";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "spotfleetrequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SpotFleetRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SpotFleetRequestSpec defines the desired state of SpotFleetRequest</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SpotFleetRequestSpec Spec { get; set; }

    /// <summary>SpotFleetRequestStatus defines the observed state of SpotFleetRequest.</summary>
    [JsonPropertyName("status")]
    public V1beta2SpotFleetRequestStatus? Status { get; set; }
}