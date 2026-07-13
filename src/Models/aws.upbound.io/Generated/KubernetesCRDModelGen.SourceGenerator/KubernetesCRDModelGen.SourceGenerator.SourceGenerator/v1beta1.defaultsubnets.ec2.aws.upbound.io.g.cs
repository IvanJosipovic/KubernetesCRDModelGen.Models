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
/// <summary>DefaultSubnet is the Schema for the DefaultSubnets API. Manage a default subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultSubnetList : IKubernetesObject<V1ListMeta>, IItems<V1beta1DefaultSubnet>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultSubnetList";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "defaultsubnets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DefaultSubnetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1DefaultSubnet objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1DefaultSubnet> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DefaultSubnetSpecDeletionPolicyEnum>))]
public enum V1beta1DefaultSubnetSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecForProvider
{
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>is required</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>Whether destroying the resource deletes the default subnet. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Region is the region you&apos;d like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
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
public partial class V1beta1DefaultSubnetSpecInitProvider
{
    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>is required</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    /// <summary>Whether destroying the resource deletes the default subnet. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DefaultSubnetSpecManagementPoliciesEnum>))]
public enum V1beta1DefaultSubnetSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DefaultSubnetSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1DefaultSubnetSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1DefaultSubnetSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1DefaultSubnetSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1DefaultSubnetSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1DefaultSubnetSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1DefaultSubnetSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DefaultSubnetSpec defines the desired state of DefaultSubnet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetSpec
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
    public V1beta1DefaultSubnetSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1DefaultSubnetSpecForProvider ForProvider { get; set; }

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
    public V1beta1DefaultSubnetSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1DefaultSubnetSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1DefaultSubnetSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1DefaultSubnetSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetStatusAtProvider
{
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    [JsonPropertyName("assignIpv6AddressOnCreation")]
    public bool? AssignIpv6AddressOnCreation { get; set; }

    /// <summary>is required</summary>
    [JsonPropertyName("availabilityZone")]
    public string? AvailabilityZone { get; set; }

    /// <summary>, cidr_block and vpc_id arguments become computed attributes</summary>
    [JsonPropertyName("availabilityZoneId")]
    public string? AvailabilityZoneId { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("cidrBlock")]
    public string? CidrBlock { get; set; }

    [JsonPropertyName("customerOwnedIpv4Pool")]
    public string? CustomerOwnedIpv4Pool { get; set; }

    [JsonPropertyName("enableDns64")]
    public bool? EnableDns64 { get; set; }

    [JsonPropertyName("enableLniAtDeviceIndex")]
    public double? EnableLniAtDeviceIndex { get; set; }

    [JsonPropertyName("enableResourceNameDnsARecordOnLaunch")]
    public bool? EnableResourceNameDnsARecordOnLaunch { get; set; }

    [JsonPropertyName("enableResourceNameDnsAaaaRecordOnLaunch")]
    public bool? EnableResourceNameDnsAaaaRecordOnLaunch { get; set; }

    [JsonPropertyName("existingDefaultSubnet")]
    public bool? ExistingDefaultSubnet { get; set; }

    /// <summary>Whether destroying the resource deletes the default subnet. Default: false</summary>
    [JsonPropertyName("forceDestroy")]
    public bool? ForceDestroy { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The IPv4 CIDR block assigned to the subnet</summary>
    [JsonPropertyName("ipv6CidrBlock")]
    public string? Ipv6CidrBlock { get; set; }

    [JsonPropertyName("ipv6CidrBlockAssociationId")]
    public string? Ipv6CidrBlockAssociationId { get; set; }

    [JsonPropertyName("ipv6Native")]
    public bool? Ipv6Native { get; set; }

    [JsonPropertyName("mapCustomerOwnedIpOnLaunch")]
    public bool? MapCustomerOwnedIpOnLaunch { get; set; }

    /// <summary>is true</summary>
    [JsonPropertyName("mapPublicIpOnLaunch")]
    public bool? MapPublicIpOnLaunch { get; set; }

    [JsonPropertyName("outpostArn")]
    public string? OutpostArn { get; set; }

    [JsonPropertyName("ownerId")]
    public string? OwnerId { get; set; }

    [JsonPropertyName("privateDnsHostnameTypeOnLaunch")]
    public string? PrivateDnsHostnameTypeOnLaunch { get; set; }

    /// <summary>Region is the region you&apos;d like your resource to be created in.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The ID of the VPC the subnet is in</summary>
    [JsonPropertyName("vpcId")]
    public string? VpcId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetStatusConditions
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

/// <summary>DefaultSubnetStatus defines the observed state of DefaultSubnet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1DefaultSubnetStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1DefaultSubnetStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1DefaultSubnetStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DefaultSubnet is the Schema for the DefaultSubnets API. Manage a default subnet resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1DefaultSubnet : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1DefaultSubnetSpec>, IStatus<V1beta1DefaultSubnetStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "DefaultSubnet";
    public const string KubeGroup = "ec2.aws.upbound.io";
    public const string KubePluralName = "defaultsubnets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ec2.aws.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DefaultSubnet";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DefaultSubnetSpec defines the desired state of DefaultSubnet</summary>
    [JsonPropertyName("spec")]
    public required V1beta1DefaultSubnetSpec Spec { get; set; }

    /// <summary>DefaultSubnetStatus defines the observed state of DefaultSubnet.</summary>
    [JsonPropertyName("status")]
    public V1beta1DefaultSubnetStatus? Status { get; set; }
}